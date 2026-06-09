using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FinalProject2ndYear
{
    public partial class addUserForm : Form
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StockTrackDB;Integrated Security=True";

        public addUserForm()
        {
            InitializeComponent();
        }

        private void addUserForm_Load(object sender, EventArgs e)
        {
            LoadDropdowns();
        }

        private void LoadDropdowns()
        {
            // Roles
            string query = "SELECT RoleID, RoleName FROM Roles";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                RoleBox.DisplayMember = "RoleName";
                RoleBox.ValueMember = "RoleID";
                RoleBox.DataSource = dt;
                RoleBox.SelectedIndex = -1;
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            // Validate
            if (string.IsNullOrWhiteSpace(UsernameTextbox.Text) ||
                string.IsNullOrWhiteSpace(PasswordTextbox.Text) ||
                string.IsNullOrWhiteSpace(FirstNameBox.Text) ||
                string.IsNullOrWhiteSpace(LastNameBox.Text) ||
                RoleBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (UsernameTextbox.Text.Trim().Length < 3)
            {
                MessageBox.Show("Username must be at least 3 characters.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (PasswordTextbox.Text.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (FirstNameBox.Text.Trim().Length < 2)
            {
                MessageBox.Show("First Name must be at least 2 characters.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (LastNameBox.Text.Trim().Length < 2)
            {
                MessageBox.Show("Last Name must be at least 2 characters.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (RoleBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Role.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Check duplicate username
                using (SqlCommand check = new SqlCommand(
                    "SELECT COUNT(*) FROM Users WHERE Username = @Username", conn))
                {
                    check.Parameters.AddWithValue("@Username", UsernameTextbox.Text.Trim());
                    if ((int)check.ExecuteScalar() > 0)
                    {
                        MessageBox.Show("A user with that username already exists.", "Duplicate Entry",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                string query = @"INSERT INTO Users (Username, Password, FirstName, LastName, RoleID, Status)
                                 VALUES (@Username, @Password, @FirstName, @LastName, @RoleID, 1)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", UsernameTextbox.Text.Trim());
                    cmd.Parameters.AddWithValue("@Password", PasswordTextbox.Text.Trim());
                    cmd.Parameters.AddWithValue("@FirstName", FirstNameBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@LastName", LastNameBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@RoleID", Convert.ToInt32(RoleBox.SelectedValue));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Created!", "Successful",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
        // Username: alphanumeric + underscore only, max 50
        private void UsernameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '_' && e.KeyChar != (char)Keys.Back)
                e.Handled = true;

            if (UsernameTextbox.Text.Length >= 50 && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        // Password max 50
        private void PasswordBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (PasswordTextbox.Text.Length >= 50 && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        // First Name: letters and spaces only, max 50
        private void FirstNameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
                e.Handled = true;

            if (FirstNameBox.Text.Length >= 50 && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        // Last Name: letters and spaces only, max 50
        private void LastNameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
                e.Handled = true;

            if (LastNameBox.Text.Length >= 50 && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
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
    }
}