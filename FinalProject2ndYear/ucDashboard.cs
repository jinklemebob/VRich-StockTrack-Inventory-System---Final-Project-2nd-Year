using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FinalProject2ndYear
{
    public partial class ucDashboard : UserControl
    {
        public string Username;
        private const string ConnectionString = @"Server=(localdb)\MSSQLLocalDB;Initial Catalog=StockTrackDB;Integrated Security=True";

        public ucDashboard()
        {
            InitializeComponent();
        }

        public ucDashboard(string Username)
        {
            InitializeComponent();
            this.Username = Username;
        }

        private void ucDashboard_Load(object sender, EventArgs e)
        {
            WelcomeLabel.Text = "Welcome, " + Username + "!";
            LoadBarChart();
            LoadCharts();
            LoadLowStocks();
            LoadExpiringSoon();
        }
        public void LoadBarChart()
        {
            DashboardChart.Series.Clear();
            DashboardChart.ChartAreas.Clear();

            ChartArea chartArea = new ChartArea();
            chartArea.AxisX.Title = "Month";
            chartArea.AxisY.Title = "Count";
            chartArea.AxisX.Interval = 1;
            chartArea.BackColor = Color.FromArgb(230, 241, 251);
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.LineColor = Color.FromArgb(133, 183, 235);
            DashboardChart.ChartAreas.Add(chartArea);

            Series receiptSeries = new Series("Goods Receipts");
            receiptSeries.ChartType = SeriesChartType.Column;
            receiptSeries.Color = Color.FromArgb(55, 138, 221);

            Series orderSeries = new Series("Sales Orders");
            orderSeries.ChartType = SeriesChartType.Column;
            orderSeries.Color = Color.FromArgb(29, 158, 117);

            string receiptQuery = @"
        SELECT MONTH(CreatedAt) AS Month, COUNT(*) AS Count
        FROM GoodsReceipts
        WHERE YEAR(CreatedAt) = YEAR(GETDATE())
        GROUP BY MONTH(CreatedAt)
        ORDER BY MONTH(CreatedAt)";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(receiptQuery, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    string month = new DateTime(2000, Convert.ToInt32(row["Month"]), 1).ToString("MMM");
                    receiptSeries.Points.AddXY(month, Convert.ToInt32(row["Count"]));
                }
            }

            string orderQuery = @"
        SELECT MONTH(CreatedAt) AS Month, COUNT(*) AS Count
        FROM SalesOrders
        WHERE YEAR(CreatedAt) = YEAR(GETDATE())
        GROUP BY MONTH(CreatedAt)
        ORDER BY MONTH(CreatedAt)";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(orderQuery, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    string month = new DateTime(2000, Convert.ToInt32(row["Month"]), 1).ToString("MMM");
                    orderSeries.Points.AddXY(month, Convert.ToInt32(row["Count"]));
                }
            }

            DashboardChart.Series.Add(receiptSeries);
            DashboardChart.Series.Add(orderSeries);
            DashboardChart.BackColor = Color.FromArgb(230, 241, 251);
            DashboardChart.Legends.Clear();
            Legend legend = new Legend();
            legend.BackColor = Color.FromArgb(230, 241, 251);
            DashboardChart.Legends.Add(legend);

            // Chart title
            DashboardChart.Titles.Clear();
            Title title = new Title();
            title.Text = "Goods Receipts vs Sales Orders (This Year)";
            title.Font = new Font("Arial Rounded MT", 12);
            title.ForeColor = Color.FromArgb(12, 68, 124);
            DashboardChart.Titles.Add(title);

            // Data labels on bars
            receiptSeries.IsValueShownAsLabel = true;
            receiptSeries.LabelForeColor = Color.FromArgb(12, 68, 124);
            orderSeries.IsValueShownAsLabel = true;
            orderSeries.LabelForeColor = Color.FromArgb(15, 110, 86);

            DashboardChart.BackColor = Color.FromArgb(230, 241, 251);
            DashboardChart.ChartAreas[0].BackColor = Color.FromArgb(230, 241, 251);
        }
        public void LoadCharts()
        {
            TotProdValue.Text = GetValues("SELECT COUNT(*) FROM Products WHERE Status = 1");
            TotSupValue.Text = GetValues("SELECT COUNT(*) FROM Suppliers WHERE Status = 1");
            TotCusValue.Text = GetValues("SELECT COUNT(*) FROM Customers WHERE Status = 1");
            TotOrdValue.Text = GetValues("SELECT COUNT(*) FROM SalesOrders");
            TotRecValue.Text = GetValues("SELECT COUNT(*) FROM GoodsReceipts");
            ExpIteValue.Text = GetValues(@"
    SELECT COUNT(*) 
    FROM StockBatches 
    WHERE ExpiryDate <= CAST(GETDATE() AS DATE)
    AND QtyRemaining > 0");
        }

        public string GetValues(string query)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                    return ((int)cmd.ExecuteScalar()).ToString();
            }
        }

        public void LoadLowStocks()
        {
            string query = @"
                SELECT p.Description AS 'Product',
                       c.CategoryName AS 'Category',
                       SUM(sb.QtyRemaining) AS 'Total Qty',
                       UPPER(u.UOMName) AS 'UoM',
                       p.ReorderLvl AS 'Reord. Lvl'
                FROM StockBatches sb
                JOIN GoodsReceiptItems gri ON sb.ReceiptItemsID = gri.ReceiptItemsID
                JOIN Products p ON gri.ProductID = p.ProductID
                JOIN Categories c ON p.CategoryID = c.CategoryID
                JOIN UOMs u ON p.UOMID = u.UOMID
                WHERE sb.QtyRemaining > 0
                AND sb.ExpiryDate >= CAST(GETDATE() AS DATE)
                GROUP BY p.ProductID, p.Description, c.CategoryName, u.UOMName, p.ReorderLvl
                HAVING SUM(sb.QtyRemaining) <= p.ReorderLvl
                ORDER BY p.Description";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                LowStockGrid.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    LowStockGrid.Visible = false;
                    NoLowStockLabel.Visible = true;
                }
                else
                {
                    LowStockGrid.Visible = true;
                    NoLowStockLabel.Visible = false;
                }

            }

            ClearGridSelection(LowStockGrid);
        }

        public void LoadExpiringSoon()
        {
            string query = @"
    SELECT p.Description AS 'Product',
           'Batch ' + CAST(sb.BatchID AS VARCHAR) AS 'Batch',
           sb.QtyRemaining AS 'Qty Remaining',
           UPPER(u.UOMName) AS 'UoM',
           sb.ExpiryDate AS 'Expiry Date'
    FROM StockBatches sb
    JOIN GoodsReceiptItems gri ON sb.ReceiptItemsID = gri.ReceiptItemsID
    JOIN Products p ON gri.ProductID = p.ProductID
    JOIN UOMs u ON p.UOMID = u.UOMID
    WHERE sb.ExpiryDate <= DATEADD(DAY, 30, CAST(GETDATE() AS DATE))
    AND sb.ExpiryDate > CAST(GETDATE() AS DATE)
    AND sb.QtyRemaining > 0
    ORDER BY sb.ExpiryDate ASC";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ExpiringSoonGrid.DataSource = dt;
                ExpiringSoonGrid.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    ExpiringSoonGrid.Visible = false;
                    NoExpiringSoonLabel.Visible = true;
                }
                else
                {
                    ExpiringSoonGrid.Visible = true;
                    NoExpiringSoonLabel.Visible = false;
                }
            }

            ClearGridSelection(ExpiringSoonGrid);
        }

        private void ClearGridSelection(DataGridView grid)
        {
            BeginInvoke(new Action(() =>
            {
                grid.CurrentCell = null;
                grid.ClearSelection();
            }));
        }
    }
}