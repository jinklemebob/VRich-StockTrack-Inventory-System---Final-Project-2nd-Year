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

namespace FinalProject2ndYear
{
    public partial class editSupplierForm : Form
    {
        int SupplierID;
        int Status;
        String connectionString = @"Server=(localdb)\MSSQLLocalDB;Initial Catalog=StockTrackDB;Integrated Security=True";
        public editSupplierForm(int SupplierID)
        {
            InitializeComponent();
            this.SupplierID = SupplierID;
        }

        private void editSupplierForm_Load(object sender, EventArgs e)
        {
            StatusBox.Items.Add("Active");
            StatusBox.Items.Add("Inactive");

            string query = "SELECT * FROM Suppliers WHERE SupplierID = @ID";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@ID", SupplierID);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    SupplierNameTxtBox.Text = reader["SupplierName"].ToString();
                    ContactPersonTxtBox.Text = reader["ContactPerson"].ToString();
                    ContactNoTxtBox.Text = reader["ContactNo"].ToString();
                    EmailTxtBox.Text = reader["Email"].ToString();
                    if (reader["Status"].ToString() == "True")
                    {
                        StatusBox.Text = "Active";
                    }
                    else if (reader["Status"].ToString() == "False")
                    {
                        StatusBox.Text = "Inactive";
                    }
                }

            }
            }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            this.Status = StatusBox.SelectedItem.ToString() == "Active" ? 1 : 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                String Query = @"UPDATE Suppliers SET SupplierName = @SupplierName, ContactPerson = @ContactPerson, ContactNo = @ContactNo, 
                Email = @Email, Status = @Status WHERE SupplierID = @ID";
            using (SqlCommand cmd = new SqlCommand(Query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", SupplierID);
                    cmd.Parameters.AddWithValue("@SupplierName", SupplierNameTxtBox.Text);
                    cmd.Parameters.AddWithValue("@ContactPerson", ContactPersonTxtBox.Text);
                    cmd.Parameters.AddWithValue("@ContactNo", ContactNoTxtBox.Text);
                    cmd.Parameters.AddWithValue("@Email", EmailTxtBox.Text);
                    cmd.Parameters.AddWithValue("@Status", Status);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Supplier Updated! ");
                    this.DialogResult = DialogResult.OK;
                    this.Close();


                }
            }
        }
    }
}
