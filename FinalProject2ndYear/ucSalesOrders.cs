using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using Tulpep.NotificationWindow;

namespace FinalProject2ndYear
{
    public partial class ucSalesOrders : UserControl
    {
        private bool isEditing = false;
        PopupNotifier popup = new PopupNotifier();
        private const string ConnectionString = @"Data Source=DESKTOP-K0HOPRM;Initial Catalog=StockTrackDB;Integrated Security=True;TrustServerCertificate=True";

        public ucSalesOrders()
        {
            InitializeComponent();
        }

        private void ucSalesOrders_Load(object sender, EventArgs e)
        {
            LoadSalesOrders();
            LoadChartValues();
        }

        public void LoadChartValues()
        {
            TotalRCount.Text = GetChartValues("SELECT COUNT(*) FROM SalesOrders");
            TodayValue.Text = GetChartValues("SELECT COUNT(*) FROM SalesOrders WHERE CAST(CreatedAt AS DATE) = CAST(GETDATE() AS DATE)");
            MonthCount.Text = GetChartValues("SELECT COUNT(*) FROM SalesOrders WHERE MONTH(CreatedAt) = MONTH(GETDATE()) AND YEAR(CreatedAt) = YEAR(GETDATE())");
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

        public void LoadSalesOrders()
        {
            string query = @"
                SELECT 'SO-' + CAST(so.SalesOrderID AS VARCHAR) AS 'Order ID',
                       so.ReferenceNo AS 'Reference No',
                       c.CustomerName AS 'Customer',
                       so.OrderDate AS 'Order Date',
                       so.CreatedAt AS 'Created At'
                FROM SalesOrders so
                JOIN Customers c ON so.CustomerID = c.CustomerID";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ReceiptsDataGrid.DataSource = dt;
            }

            ClearGridSelection();
        }

        public void ShowNotif()
        {
            popup.TitleText = "Sales Orders";
            popup.ContentText = isEditing ? "Select an order to edit." : "";
            popup.TitleFont = new Font("Segoe UI", 11, FontStyle.Bold);
            popup.ContentFont = new Font("Segoe UI", 12, FontStyle.Regular);
            popup.Size = new Size(300, 100);
            popup.TitleColor = Color.White;
            popup.ContentColor = Color.White;
            popup.BodyColor = Color.FromArgb(13, 34, 68);
            popup.BorderColor = Color.FromArgb(91, 155, 213);
            popup.Delay = 2500;
            popup.Popup();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            ResetState();
            addSalesOrderForm aForm = new addSalesOrderForm();
            if (aForm.ShowDialog() == DialogResult.OK)
            {
                LoadSalesOrders();
                LoadChartValues();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (ReceiptsDataGrid.RowCount == 0)
            {
                popup.TitleText = "Sales Orders";
                popup.ContentText = "There are no orders available to edit.";
                popup.TitleFont = new Font("Segoe UI", 11, FontStyle.Bold);
                popup.ContentFont = new Font("Segoe UI", 12, FontStyle.Regular);
                popup.Size = new Size(300, 100);
                popup.TitleColor = Color.White;
                popup.ContentColor = Color.White;
                popup.BodyColor = Color.FromArgb(13, 34, 68);
                popup.BorderColor = Color.FromArgb(91, 155, 213);
                popup.Delay = 2500;
                popup.Popup();
            }
            else if (!isEditing)
            {
                isEditing = true;
                ShowNotif();
                EditButton.Text = "Cancel";
                EditButton.Padding = new Padding(0, 0, 0, 0);
                ReceiptsDataGrid.Enabled = true;
                EditIcon.Visible = false;
            }
            else
            {
                ResetState();
            }
        }

        private void ReceiptsDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string rawID = ReceiptsDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            int salesOrderID = Convert.ToInt32(rawID.Replace("SO-", ""));

            if (isEditing)
            {
                editSalesOrderForm eForm = new editSalesOrderForm(salesOrderID);
                if (eForm.ShowDialog() == DialogResult.OK)
                {
                    LoadSalesOrders();
                    LoadChartValues();
                }
                ResetState();
            }
            else
            {
                viewSalesOrderForm vForm = new viewSalesOrderForm(salesOrderID);
                vForm.ShowDialog();
            }

            ClearGridSelection();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            SearchLabel.Visible = string.IsNullOrWhiteSpace(SearchBox.Text);

            string query = @"
                SELECT 'SO-' + CAST(so.SalesOrderID AS VARCHAR) AS 'Order ID',
                       so.ReferenceNo AS 'Reference No',
                       c.CustomerName AS 'Customer',
                       so.OrderDate AS 'Order Date',
                       so.CreatedAt AS 'Created At'
                FROM SalesOrders so
                JOIN Customers c ON so.CustomerID = c.CustomerID
                WHERE so.ReferenceNo LIKE @Search
                   OR c.CustomerName LIKE @Search
                   OR CAST(so.OrderDate AS VARCHAR) LIKE @Search";

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

        private void ResetState()
        {
            isEditing = false;
            EditButton.Text = "Edit";
            EditButton.Padding = new Padding(10, 0, 0, 0);
            EditIcon.Visible = true;
            ClearGridSelection();
        }

        private void ClearGridSelection()
        {
            BeginInvoke(new Action(() =>
            {
                ReceiptsDataGrid.CurrentCell = null;
                ReceiptsDataGrid.ClearSelection();
            }));
        }

        private void ReceiptsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}