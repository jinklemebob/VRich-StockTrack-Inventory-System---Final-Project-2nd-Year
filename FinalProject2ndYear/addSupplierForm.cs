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
        String connectionString = @"Data Source=DESKTOP-K0HOPRM;Initial Catalog=StockTrackDB;Integrated Security=True;TrustServerCertificate=True";
        public addSupplierForm()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SupplierNameTxtBox.Text) ||
                string.IsNullOrWhiteSpace(ContactPersonTxtBox.Text) ||
                string.IsNullOrWhiteSpace(ContactNoTxtBox.Text) ||
                string.IsNullOrWhiteSpace(EmailTxtBox.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand check = new SqlCommand(
                    "SELECT COUNT(*) FROM Suppliers WHERE SupplierName = @SupplierName", conn))
                {
                    check.Parameters.AddWithValue("@SupplierName", SupplierNameTxtBox.Text.Trim());
                    if ((int)check.ExecuteScalar() > 0)
                    {
                        MessageBox.Show("A supplier with that name already exists.", "Duplicate Entry",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                using (SqlCommand check = new SqlCommand(
                   "SELECT COUNT(*) FROM Suppliers WHERE ContactPerson = @ContactPerson", conn))
                {
                    check.Parameters.AddWithValue("@ContactPerson", ContactPersonTxtBox.Text.Trim());
                    if ((int)check.ExecuteScalar() > 0)
                    {
                        MessageBox.Show("A supplier with that contact person already exists.", "Duplicate Entry",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                using (SqlCommand check = new SqlCommand(
                    "SELECT COUNT(*) FROM Suppliers WHERE Email = @Email", conn))
                {
                    check.Parameters.AddWithValue("@Email", EmailTxtBox.Text.Trim());
                    if ((int)check.ExecuteScalar() > 0)
                    {
                        MessageBox.Show("A supplier with that email already exists.", "Duplicate Entry",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                string query = @"INSERT INTO Suppliers (SupplierName, ContactPerson, ContactNo, Email, Status) 
                         VALUES (@SupplierName, @ContactPerson, @ContactNo, @Email, @Status)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SupplierName", SupplierNameTxtBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@ContactPerson", ContactPersonTxtBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@ContactNo", ContactNoTxtBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email", EmailTxtBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@Status", 1);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Supplier Created!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void addSupplierForm_Load(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to cancel this process?", "Cancel Process", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
    }

