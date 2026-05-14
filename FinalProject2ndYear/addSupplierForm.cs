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
    public partial class addSupplierForm : Form
    {
        String connectionString = @"Server=(localdb)\MSSQLLocalDB;Initial Catalog=StockTrackDB;Integrated Security=True";
        public addSupplierForm()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
           
           
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                String Query = @"INSERT INTO Suppliers (SupplierName, ContactPerson, ContactNo, Email, Status) VALUES (@SupplierName, @ContactPerson, @ContactNo, @Email, @Status)";
            using (SqlCommand cmd = new SqlCommand(Query, conn))
                {
                    cmd.Parameters.AddWithValue("@SupplierName", SupplierNameTxtBox.Text);
                    cmd.Parameters.AddWithValue("@ContactPerson", ContactPersonTxtBox.Text);
                    cmd.Parameters.AddWithValue("@ContactNo", ContactNoTxtBox.Text);
                    cmd.Parameters.AddWithValue("@Email", EmailTxtBox.Text);
                    cmd.Parameters.AddWithValue("@Status", 1);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Supplier Created!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
    }
}
