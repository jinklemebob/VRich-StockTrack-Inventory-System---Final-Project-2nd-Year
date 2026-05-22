using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalProject2ndYear
{
    public partial class addProductForm : Form
    {
        String connectionString = @"Server=(localdb)\MSSQLLocalDB;Initial Catalog=StockTrackDB;Integrated Security=True";
        public addProductForm()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
           
           
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                String Query = @"INSERT INTO Products (Description, CategoryID, ReorderLvl, UOMID) VALUES (@Description, @CategoryID, @ReorderLvl, @UOMID)";
            using (SqlCommand cmd = new SqlCommand(Query, conn))
                {
                    cmd.Parameters.AddWithValue("@Description", ProductDescBox.Text);
                    cmd.Parameters.AddWithValue("@CategoryID", CategoryBox.SelectedValue);
                    cmd.Parameters.AddWithValue("@ReorderLvl", ReorderLvlBox.Text);
                    cmd.Parameters.AddWithValue("@UOMID", UOMBox.SelectedValue);
                

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Supplier Created!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void addProductForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadUOM();
            
        }   

        public void LoadCategories()
        {
            DataTable dt = new DataTable();

            String Query = @"SELECT * FROM Categories";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adp = new SqlDataAdapter(Query, conn);
                adp.Fill(dt);
            }
            CategoryBox.Text = "Select Category...";
            CategoryBox.DataSource = dt;
            CategoryBox.DisplayMember = "CategoryName";
            CategoryBox.ValueMember = "CategoryID";

        }
        public void LoadUOM()
        {
            DataTable dt = new DataTable();

            String Query = @"SELECT * FROM UOMs";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adp = new SqlDataAdapter(Query, conn);
                adp.Fill(dt);
            }

            UOMBox.Text = "Select Unit of Measurement...";
            UOMBox.DataSource = dt;
            UOMBox.DisplayMember = "UOMName";
            UOMBox.ValueMember = "UOMID";
            UOMBox.SelectedIndex = -1;
            

        }

        private void UOMBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
