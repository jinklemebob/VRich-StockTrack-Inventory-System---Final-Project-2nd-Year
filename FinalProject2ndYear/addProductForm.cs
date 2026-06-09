using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FinalProject2ndYear
{
    public partial class addProductForm : Form
    {
        string connectionString = @"Data Source=DESKTOP-K0HOPRM;Initial Catalog=StockTrackDB;Integrated Security=True;TrustServerCertificate=True";

        public addProductForm()
        {
            InitializeComponent();
        }

        private void addProductForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadUOM();
        }

        public void LoadCategories()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM Categories ORDER BY CategoryName", conn);
                adp.Fill(dt);
            }
            CategoryBox.DataSource = dt;
            CategoryBox.DisplayMember = "CategoryName";
            CategoryBox.ValueMember = "CategoryID";
            CategoryBox.SelectedIndex = -1;
        }

        public void LoadUOM()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM UOMs ORDER BY UOMName", conn);
                adp.Fill(dt);
            }
            UOMBox.DataSource = dt;
            UOMBox.DisplayMember = "UOMName";
            UOMBox.ValueMember = "UOMID";
            UOMBox.SelectedIndex = -1;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ProductDescBox.Text) ||
                string.IsNullOrWhiteSpace(ReorderLvlBox.Text) ||
                CategoryBox.SelectedIndex == -1 ||
                UOMBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(ReorderLvlBox.Text, out int reorderLvl) || reorderLvl < 0)
            {
                MessageBox.Show("Reorder Level must be a non-negative whole number.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();


                using (SqlCommand check = new SqlCommand(
                    "SELECT COUNT(*) FROM Products WHERE Description = @Description", conn))
                {
                    check.Parameters.AddWithValue("@Description", ProductDescBox.Text.Trim());
                    if ((int)check.ExecuteScalar() > 0)
                    {
                        MessageBox.Show("A product with that description already exists.", "Duplicate Entry",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }


                string query = @"INSERT INTO Products (Description, CategoryID, ReorderLvl, UOMID) 
                                 VALUES (@Description, @CategoryID, @ReorderLvl, @UOMID)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Description", ProductDescBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@CategoryID", CategoryBox.SelectedValue);
                    cmd.Parameters.AddWithValue("@ReorderLvl", reorderLvl);
                    cmd.Parameters.AddWithValue("@UOMID", UOMBox.SelectedValue);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Created!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void UOMBox_SelectedIndexChanged(object sender, EventArgs e) { }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to cancel this process?", "Cancel Process", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ReorderLvlLabel_Click(object sender, EventArgs e)
        {

        }
    }
}