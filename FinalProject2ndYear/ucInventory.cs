using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace FinalProject2ndYear
{
    public partial class ucInventory : UserControl
    {
        private const string ConnectionString = @"Server=(localdb)\MSSQLLocalDB;Initial Catalog=StockTrackDB;Integrated Security=True";
        private bool isLoading = true;

        public ucInventory()
        {
            InitializeComponent();
        }

        private void ucInventory_Load(object sender, EventArgs e)
        {
            isLoading = true;
            ShowDepletedBox.Checked = false;
            ShowExpiredBox.Checked = false;
            isLoading = false;
            LoadInventory();
            LoadChartValues();
        }

        public void LoadChartValues()
        {
            TotalRCount.Text = GetChartValues(@"
                SELECT COUNT(DISTINCT gri.ProductID) 
                FROM StockBatches sb 
                JOIN GoodsReceiptItems gri ON sb.ReceiptItemsID = gri.ReceiptItemsID
                WHERE sb.QtyRemaining > 0 
                AND sb.ExpiryDate >= CAST(GETDATE() AS DATE)");

            TodayValue.Text = GetChartValues(@"
                SELECT COUNT(DISTINCT gri.ProductID)
                FROM StockBatches sb
                JOIN GoodsReceiptItems gri ON sb.ReceiptItemsID = gri.ReceiptItemsID
                JOIN Products p ON gri.ProductID = p.ProductID
                WHERE sb.QtyRemaining > 0
                AND sb.ExpiryDate >= CAST(GETDATE() AS DATE)
                AND (
                    SELECT SUM(sb2.QtyRemaining)
                    FROM StockBatches sb2
                    JOIN GoodsReceiptItems gri2 ON sb2.ReceiptItemsID = gri2.ReceiptItemsID
                    WHERE gri2.ProductID = gri.ProductID
                    AND sb2.QtyRemaining > 0
                ) <= p.ReorderLvl");

            MonthCount.Text = GetChartValues(@"
                SELECT COUNT(*)
                FROM StockBatches
                WHERE ExpiryDate <= DATEADD(DAY, 30, CAST(GETDATE() AS DATE))
                AND ExpiryDate >= CAST(GETDATE() AS DATE)
                AND QtyRemaining > 0");
        }

        public string GetChartValues(string query)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                    return ((int)cmd.ExecuteScalar()).ToString();
            }
        }

        private string BuildStatusCase()
        {
            return @"CASE
                WHEN sb.ExpiryDate <= CAST(GETDATE() AS DATE) THEN 'Expired'
                WHEN sb.QtyRemaining = 0 THEN 'Depleted'
                WHEN (
                    SELECT SUM(sb2.QtyRemaining)
                    FROM StockBatches sb2
                    JOIN GoodsReceiptItems gri2 ON sb2.ReceiptItemsID = gri2.ReceiptItemsID
                    WHERE gri2.ProductID = gri.ProductID
                    AND sb2.QtyRemaining > 0
                ) <= p.ReorderLvl THEN 'Low Stock'
                WHEN sb.ExpiryDate <= DATEADD(DAY, 30, CAST(GETDATE() AS DATE)) THEN 'Expiring Soon'
                ELSE 'OK'
            END";
        }

        private string BuildStatusFilter()
        {
            string statusCase = BuildStatusCase();
            string filter = $"({statusCase} IN ('OK', 'Low Stock', 'Expiring Soon')";

            if (ShowDepletedBox.Checked)
                filter += $" OR {statusCase} = 'Depleted'";

            if (ShowExpiredBox.Checked)
                filter += $" OR {statusCase} = 'Expired'";

            filter += ")";
            return filter;
        }

        public void LoadInventory()
        {
            string query = $@"
                SELECT 'Batch ' + CAST(sb.BatchID AS VARCHAR) AS 'Batch',
                       p.Description AS 'Product',
                       c.CategoryName AS 'Category',
                       sb.QtyRemaining AS 'Quantity',
                       UPPER(u.UOMName) AS 'UoM',
                       sb.ExpiryDate AS 'Expiry Date',
                       {BuildStatusCase()} AS 'Status'
                FROM StockBatches sb
                JOIN GoodsReceiptItems gri ON sb.ReceiptItemsID = gri.ReceiptItemsID
                JOIN Products p ON gri.ProductID = p.ProductID
                JOIN Categories c ON p.CategoryID = c.CategoryID
                JOIN UOMs u ON p.UOMID = u.UOMID
                WHERE {BuildStatusFilter()}
                ORDER BY p.Description, sb.ExpiryDate ASC";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ReceiptsDataGrid.DataSource = dt;
            }

            ClearGridSelection();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            SearchLabel.Visible = string.IsNullOrWhiteSpace(SearchBox.Text);

            string baseQuery = $@"
                SELECT 'Batch ' + CAST(sb.BatchID AS VARCHAR) AS 'Batch',
                       p.Description AS 'Product',
                       c.CategoryName AS 'Category',
                       sb.QtyRemaining AS 'Quantity',
                       UPPER(u.UOMName) AS 'UoM',
                       sb.ExpiryDate AS 'Expiry Date',
                       {BuildStatusCase()} AS 'Status'
                FROM StockBatches sb
                JOIN GoodsReceiptItems gri ON sb.ReceiptItemsID = gri.ReceiptItemsID
                JOIN Products p ON gri.ProductID = p.ProductID
                JOIN Categories c ON p.CategoryID = c.CategoryID
                JOIN UOMs u ON p.UOMID = u.UOMID
                WHERE {BuildStatusFilter()}";

            string query = $@"
                SELECT * FROM ({baseQuery}) AS filtered
                WHERE [Product] LIKE @Search
                   OR [Category] LIKE @Search
                   OR [UoM] LIKE @Search
                   OR CAST([Expiry Date] AS VARCHAR) LIKE @Search
                   OR [Status] LIKE @Search
                   OR [Batch] LIKE @Search
                ORDER BY [Product], [Expiry Date] ASC";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@Search", "%" + SearchBox.Text + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                ReceiptsDataGrid.DataSource = dt;
            }

            ClearGridSelection();
        }

        private void SearchBox_Click(object sender, EventArgs e)
        {
            SearchLabel.Visible = false;
        }

        private void SearchBox_MouseLeave(object sender, EventArgs e)
        {
            SearchLabel.Visible = string.IsNullOrWhiteSpace(SearchBox.Text);
        }

        private void ClearGridSelection()
        {
            BeginInvoke(new Action(() =>
            {
                ReceiptsDataGrid.CurrentCell = null;
                ReceiptsDataGrid.ClearSelection();
            }));
        }

        private void ShowDepletedBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!isLoading) LoadInventory();
        }

        private void ShowExpiredBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!isLoading) LoadInventory();
        }

        private void ReceiptsDataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string status = ReceiptsDataGrid.Rows[e.RowIndex].Cells["Status"].Value?.ToString();

            if (status == null) return;

            switch (status)
            {
                case "Low Stock":
                    ReceiptsDataGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
                    ReceiptsDataGrid.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                    break;
                case "Expiring Soon":
                    ReceiptsDataGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Orange;
                    ReceiptsDataGrid.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                    break;
                case "Depleted":
                    ReceiptsDataGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.IndianRed;
                    ReceiptsDataGrid.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                    break;
                case "Expired":
                    ReceiptsDataGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.DarkRed;
                    ReceiptsDataGrid.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                    break;
                case "OK":
                    ReceiptsDataGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                    ReceiptsDataGrid.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                    break;
            }
        }
    }
}