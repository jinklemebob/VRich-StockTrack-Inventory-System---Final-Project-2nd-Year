using System;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FinalProject2ndYear
{
    public partial class addCustomerForm : Form
    {
        string connectionString = @"Data Source=DESKTOP-K0HOPRM;Initial Catalog=StockTrackDB;Integrated Security=True;TrustServerCertificate=True";

        public addCustomerForm()
        {
            InitializeComponent();

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CustomerNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(ContactPersonTextBox.Text) ||
                string.IsNullOrWhiteSpace(ContactNoTextBox.Text) ||
                string.IsNullOrWhiteSpace(EmailTextBox.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand check = new SqlCommand(
                    "SELECT COUNT(*) FROM Customers WHERE CustomerName = @CustomerName", conn))
                {
                    check.Parameters.AddWithValue("@CustomerName", CustomerNameTextBox.Text.Trim());
                    if ((int)check.ExecuteScalar() > 0)
                    {
                        MessageBox.Show("A customer with that name already exists.", "Duplicate Entry",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                using (SqlCommand check = new SqlCommand(
                    "SELECT COUNT(*) FROM Customers WHERE Email = @Email", conn))
                {
                    check.Parameters.AddWithValue("@Email", EmailTextBox.Text.Trim());
                    if ((int)check.ExecuteScalar() > 0)
                    {
                        MessageBox.Show("A customer with that email already exists.", "Duplicate Entry",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                string query = @"INSERT INTO Customers (CustomerName, ContactPerson, ContactNo, Email, Status) 
                                 VALUES (@CustomerName, @ContactPerson, @ContactNo, @Email, @Status)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerName", CustomerNameTextBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@ContactPerson", ContactPersonTextBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@ContactNo", ContactNoTextBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email", EmailTextBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@Status", 1);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Created!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to cancel this process?", "Cancel Process", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void addCustomerForm_Load(object sender, EventArgs e)
        {

        }
    }
}