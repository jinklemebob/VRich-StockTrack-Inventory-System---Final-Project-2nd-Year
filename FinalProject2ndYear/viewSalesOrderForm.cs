using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FinalProject2ndYear
{
    public partial class viewSalesOrderForm : Form
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StockTrackDB;Integrated Security=True";
        private int salesOrderID;

        public viewSalesOrderForm(int salesOrderID)
        {
            InitializeComponent();
            this.salesOrderID = salesOrderID;
        }

        private void viewSalesOrderForm_Load(object sender, EventArgs e)
        {
            LoadOrderDetails();
            LoadOrderItems();
            ClearGridSelection();
        }

        private void LoadOrderDetails()
        {
            string query = @"
                SELECT 'SO-' + CAST(so.SalesOrderID AS VARCHAR) AS SalesOrderID,
                       so.ReferenceNo,
                       c.CustomerName,
                       so.OrderDate
                FROM SalesOrders so
                JOIN Customers c ON so.CustomerID = c.CustomerID
                WHERE so.SalesOrderID = @SalesOrderID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SalesOrderID", salesOrderID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            ReceiptID.Text = reader["SalesOrderID"].ToString();
                            ReferenceNo.Text = reader["ReferenceNo"].ToString();
                            Supplier.Text = reader["CustomerName"].ToString();
                            ReceiptDate.Text = Convert.ToDateTime(reader["OrderDate"]).ToString("MM/dd/yyyy");
                        }
                    }
                }
            }
        }

        private void LoadOrderItems()
        {
            string query = @"
               SELECT p.Description AS 'Product',
               soi.Qty AS 'Qty',
               u.UOMName AS 'UoM'
               FROM SalesOrderItems soi
               JOIN Products p ON soi.ProductID = p.ProductID
               JOIN UOMs u ON p.UOMID = u.UOMID
               WHERE soi.SalesOrderID = @SalesOrderID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@SalesOrderID", salesOrderID);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ItemsDataGrid.DataSource = dt;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearGridSelection()
        {
            BeginInvoke(new Action(() =>
            {
                ItemsDataGrid.CurrentCell = null;
                ItemsDataGrid.ClearSelection();
            }));
        }
    }
}