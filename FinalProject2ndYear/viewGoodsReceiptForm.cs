using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FinalProject2ndYear
{
    public partial class viewGoodsReceiptForm : Form
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StockTrackDB;Integrated Security=True";
        private int receiptID;

        public viewGoodsReceiptForm(int receiptID)
        {
            InitializeComponent();
            this.receiptID = receiptID;
        }

        private void viewGoodsReceiptForm_Load(object sender, EventArgs e)
        {
            LoadReceiptDetails();
            LoadReceiptItems();
            ClearGridSelection();
        }

        private void LoadReceiptDetails()
        {
            string query = @"
                SELECT 'GR-' + CAST(gr.ReceiptID AS VARCHAR) AS ReceiptID,
                       gr.ReferenceNo,
                       s.SupplierName,
                       gr.ReceiptDate
                FROM GoodsReceipts gr
                JOIN Suppliers s ON gr.SupplierID = s.SupplierID
                WHERE gr.ReceiptID = @ReceiptID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ReceiptID", receiptID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            ReceiptID.Text = reader["ReceiptID"].ToString();
                            ReferenceNo.Text = reader["ReferenceNo"].ToString();
                            Supplier.Text = reader["SupplierName"].ToString();
                            ReceiptDate.Text = Convert.ToDateTime(reader["ReceiptDate"]).ToString("MM/dd/yyyy");
                        }
                    }
                }
            }
        }

        private void LoadReceiptItems()
        {
            string query = @"
                SELECT p.Description AS 'Product',
                gri.Qty AS 'Qty',
                u.UOMName AS 'UoM',
                sb.ExpiryDate AS 'Expiry Date'
                FROM GoodsReceiptItems gri
                JOIN Products p ON gri.ProductID = p.ProductID
                JOIN UOMs u ON p.UOMID = u.UOMID
                JOIN StockBatches sb ON sb.ReceiptItemsID = gri.ReceiptItemsID
                WHERE gri.ReceiptID = @ReceiptID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@ReceiptID", receiptID);
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