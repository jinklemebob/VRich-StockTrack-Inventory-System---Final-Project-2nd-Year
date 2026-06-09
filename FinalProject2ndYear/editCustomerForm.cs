using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FinalProject2ndYear
{
    public partial class editCustomerForm : Form
    {
        int CustomerID;
        int Status;
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StockTrackDB;Integrated Security=True";

        public editCustomerForm(int CustomerID)
        {
            InitializeComponent();
            this.CustomerID = CustomerID;
        }

        private void editCustomerForm_Load(object sender, EventArgs e)
        {
            StatusBox.Items.Add("Active");
            StatusBox.Items.Add("Inactive");

            string query = "SELECT * FROM Customers WHERE CustomerID = @ID";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@ID", CustomerID);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    CustomerNameTextBox.Text = reader["CustomerName"].ToString();
                    ContactPersonTextBox.Text = reader["ContactPerson"].ToString();
                    ContactNoTextBox.Text = reader["ContactNo"].ToString();
                    EmailTextBox.Text = reader["Email"].ToString();
                    StatusBox.Text = reader["Status"].ToString() == "True" ? "Active" : "Inactive";
                }
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CustomerNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(ContactPersonTextBox.Text) ||
                string.IsNullOrWhiteSpace(ContactNoTextBox.Text) ||
                string.IsNullOrWhiteSpace(EmailTextBox.Text) ||
                string.IsNullOrWhiteSpace(StatusBox.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (CustomerNameTextBox.Text.Trim().Length < 3)
            {
                MessageBox.Show("Customer Name must be at least 3 characters.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ContactNoTextBox.Text.Trim().Length != 11)
            {
                MessageBox.Show("Contact No. must be exactly 11 digits.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ContactPersonTextBox.Text.Trim().Length < 3)
            {
                MessageBox.Show("Contact Person must be at least 3 characters.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(EmailTextBox.Text.Trim(),
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
                    "SELECT COUNT(*) FROM Customers WHERE CustomerName = @CustomerName AND CustomerID != @ID", conn))
                {
                    check.Parameters.AddWithValue("@CustomerName", CustomerNameTextBox.Text.Trim());
                    check.Parameters.AddWithValue("@ID", CustomerID);
                    if ((int)check.ExecuteScalar() > 0)
                    {
                        MessageBox.Show("A customer with that name already exists.", "Duplicate Entry",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

    
                using (SqlCommand check = new SqlCommand(
                    "SELECT COUNT(*) FROM Customers WHERE Email = @Email AND CustomerID != @ID", conn))
                {
                    check.Parameters.AddWithValue("@Email", EmailTextBox.Text.Trim());
                    check.Parameters.AddWithValue("@ID", CustomerID);
                    if ((int)check.ExecuteScalar() > 0)
                    {
                        MessageBox.Show("A customer with that email already exists.", "Duplicate Entry",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

              
                this.Status = StatusBox.Text == "Active" ? 1 : 0;
                string query = @"UPDATE Customers 
                                 SET CustomerName  = @CustomerName,
                                     ContactPerson = @ContactPerson,
                                     ContactNo     = @ContactNo,
                                     Email         = @Email,
                                     Status        = @Status
                                 WHERE CustomerID  = @ID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", CustomerID);
                    cmd.Parameters.AddWithValue("@CustomerName", CustomerNameTextBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@ContactPerson", ContactPersonTextBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@ContactNo", ContactNoTextBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email", EmailTextBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@Status", Status);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Updated!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
        private void addCustomerForm_Load(object sender, EventArgs e)
        {

        }
        // Block Contact No. to numbers only, max 11 digits
        private void ContactNoBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;

            if (ContactNoTextBox.Text.Length >= 11 && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        // Block Customer Name and Contact Person at 100 chars
        private void CustomerNameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CustomerNameTextBox.Text.Length >= 100 && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void ContactPersonBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ContactPersonTextBox.Text.Length >= 100 && e.KeyChar != (char)Keys.Back)
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