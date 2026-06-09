using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FinalProject2ndYear
{
    public partial class editCustomerForm : Form
    {
        int CustomerID;
        int Status;
        string connectionString = @"Data Source=DESKTOP-K0HOPRM;Initial Catalog=StockTrackDB;Integrated Security=True;TrustServerCertificate=True";

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