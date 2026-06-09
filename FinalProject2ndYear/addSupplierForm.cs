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
        String connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StockTrackDB;Integrated Security=True";
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
            if (SupplierNameTxtBox.Text.Trim().Length < 3)
            {
                MessageBox.Show("Supplier Name must be at least 3 characters.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ContactNoTxtBox.Text.Trim().Length != 11)
            {
                MessageBox.Show("Contact No. must be exactly 11 digits.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ContactPersonTxtBox.Text.Trim().Length < 3)
            {
                MessageBox.Show("Contact Person must be at least 3 characters.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(EmailTxtBox.Text.Trim(),
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error",
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
        // Block Supplier Name and Contact Person at 100 chars
        private void SupplierNameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (SupplierNameTxtBox.Text.Length >= 100 && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void ContactPersonBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ContactPersonTxtBox.Text.Length >= 100 && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        // Block Contact No. to numbers only, max 11 digits
        private void ContactNoBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;

            if (ContactNoTxtBox.Text.Length >= 11 && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
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

