using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FinalProject2ndYear
{
    public partial class editProductForm : Form
    {
        int ProductID;
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StockTrackDB;Integrated Security=True";

        public editProductForm(int ProductID)
        {
            InitializeComponent();
            this.ProductID = ProductID;
        }

        private void editProductForm_Load(object sender, EventArgs e)
        {
            LoadDropdowns();

            string query = "SELECT * FROM Products WHERE ProductID = @ID";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@ID", ProductID);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    ProductDescBox.Text = reader["Description"].ToString();
                    ReorderLvlBox.Text = reader["ReorderLvl"].ToString();
                    CategoryBox.SelectedValue = reader["CategoryID"];
                    UOMBox.SelectedValue = reader["UOMID"];
                    StatusBox.SelectedIndex = Convert.ToInt32(reader["Status"]) == 1 ? 0 : 1;

                    // pre-select the supplier
                    if (reader["SupplierID"] != DBNull.Value)
                        SupplierBox.SelectedValue = reader["SupplierID"];
                    else
                        SupplierBox.SelectedIndex = -1;
                }
            }
        }

        private void LoadDropdowns()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("SELECT CategoryID, CategoryName FROM Categories ORDER BY CategoryName", conn))
            {
                conn.Open();
                DataTable dtCat = new DataTable();
                dtCat.Load(cmd.ExecuteReader());
                CategoryBox.DataSource = dtCat;
                CategoryBox.DisplayMember = "CategoryName";
                CategoryBox.ValueMember = "CategoryID";
                CategoryBox.SelectedIndex = -1;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("SELECT UOMID, UOMName FROM UOMs ORDER BY UOMName", conn))
            {
                conn.Open();
                DataTable dtUOM = new DataTable();
                dtUOM.Load(cmd.ExecuteReader());
                UOMBox.DataSource = dtUOM;
                UOMBox.DisplayMember = "UOMName";
                UOMBox.ValueMember = "UOMID";
                UOMBox.SelectedIndex = -1;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(@"
        SELECT SupplierID, 
               SupplierName + CASE WHEN Status = 0 THEN ' (Inactive)' ELSE '' END AS DisplayName
        FROM Suppliers
        ORDER BY Status DESC, SupplierName", conn))
            {
                conn.Open();
                DataTable dtSup = new DataTable();
                dtSup.Load(cmd.ExecuteReader());
                SupplierBox.DataSource = dtSup;
                SupplierBox.DisplayMember = "DisplayName";
                SupplierBox.ValueMember = "SupplierID";
                SupplierBox.SelectedIndex = -1;
            }

            StatusBox.Items.Clear();
            StatusBox.Items.Add("Active");
            StatusBox.Items.Add("Inactive");
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ProductDescBox.Text) ||
                string.IsNullOrWhiteSpace(ReorderLvlBox.Text) ||
                CategoryBox.SelectedIndex == -1 ||
                UOMBox.SelectedIndex == -1 ||
                StatusBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(ReorderLvlBox.Text, out int reorderLvl) || reorderLvl <= 0)
            {
                MessageBox.Show("Invalid Reorder Level.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int newStatus = StatusBox.SelectedIndex == 0 ? 1 : 0;

            if (newStatus == 0)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand check = new SqlCommand(@"
                SELECT COUNT(*) FROM StockBatches sb
                JOIN GoodsReceiptItems gri ON sb.ReceiptItemsID = gri.ReceiptItemsID
                WHERE gri.ProductID = @ID AND sb.QtyRemaining > 0", conn))
                    {
                        check.Parameters.AddWithValue("@ID", ProductID);
                        int remainingStock = (int)check.ExecuteScalar();
                        if (remainingStock > 0)
                        {
                            MessageBox.Show("This product cannot be set as inactive because it still has remaining stock in the inventory.",
                                            "Cannot Deactivate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand check = new SqlCommand(
                    "SELECT COUNT(*) FROM Products WHERE Description = @Description AND ProductID != @ID", conn))
                {
                    check.Parameters.AddWithValue("@Description", ProductDescBox.Text.Trim());
                    check.Parameters.AddWithValue("@ID", ProductID);
                    if (ProductDescBox.Text.Trim().Length < 3)
                    {
                        MessageBox.Show("Product description must be at least 3 characters.", "Validation Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if ((int)check.ExecuteScalar() > 0)
                    {
                        MessageBox.Show("A product with that description already exists.", "Duplicate Entry",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                string query = @"UPDATE Products 
                         SET Description = @Description,
                             ReorderLvl  = @ReorderLvl,
                             CategoryID  = @CategoryID,
                             UOMID       = @UOMID,
                             SupplierID  = @SupplierID,
                             Status      = @Status
                         WHERE ProductID = @ID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", ProductID);
                    cmd.Parameters.AddWithValue("@Description", ProductDescBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@ReorderLvl", reorderLvl);
                    cmd.Parameters.AddWithValue("@CategoryID", Convert.ToInt32(CategoryBox.SelectedValue));
                    cmd.Parameters.AddWithValue("@UOMID", Convert.ToInt32(UOMBox.SelectedValue));

                    // SupplierID is optional — keep existing value if nothing selected
                    if (SupplierBox.SelectedIndex != -1)
                        cmd.Parameters.AddWithValue("@SupplierID", Convert.ToInt32(SupplierBox.SelectedValue));
                    else
                        cmd.Parameters.AddWithValue("@SupplierID", DBNull.Value);

                    cmd.Parameters.AddWithValue("@Status", newStatus);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Updated!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to cancel this process?",
                                    "Cancel Process", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ProductDescBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("Product description must be at least 3 characters.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;

        }
    }
}