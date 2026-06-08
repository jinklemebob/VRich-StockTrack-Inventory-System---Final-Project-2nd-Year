using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using Tulpep.NotificationWindow;

namespace FinalProject2ndYear
{
    public partial class ucUsers : UserControl
    {
        private bool isEditing = false;
        private bool isDeleting = false;
        PopupNotifier popup = new PopupNotifier();
        private const string ConnectionString = @"Server=(localdb)\MSSQLLocalDB;Initial Catalog=StockTrackDB;Integrated Security=True";

        public ucUsers()
        {
            InitializeComponent();
        }

        private void ucUsers_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        public void LoadUsers()
        {
            string query = @"
        SELECT 'US-' + CAST(u.UserID AS VARCHAR) AS 'ID',
               u.Username, u.FirstName AS 'First Name', 
               u.LastName AS 'Last Name',
               r.RoleName AS 'Role',
               CASE WHEN u.Status = 1 THEN 'Active' ELSE 'Inactive' END AS 'Status',
               u.CreatedAt AS 'Created At'
        FROM Users u 
        JOIN Roles r ON u.RoleID = r.RoleID";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                UsersDataGrid.DataSource = dt;
            }

            RefreshCounts();
            ClearGridSelection();
        }
        private void RefreshCounts()
        {
            TotalSuppliersCount.Text = GetCount("SELECT COUNT(*) FROM Users").ToString();
            ActiveCount.Text = GetCount("SELECT COUNT(*) FROM Users WHERE Status = 1").ToString();
            InactiveCount.Text = GetCount("SELECT COUNT(*) FROM Users WHERE Status = 0").ToString();
        }

        private int GetCount(string query)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                    return (int)cmd.ExecuteScalar();
            }
        }

        public void ShowNotif()
        {
            if (isEditing)
            {
                popup.TitleText = "Users";
                popup.ContentText = "Select a user to edit.";
                popup.TitleFont = new Font("Segoe UI", 11, FontStyle.Bold);
                popup.ContentFont = new Font("Segoe UI", 12, FontStyle.Regular);
                popup.Size = new Size(300, 100);
                popup.TitleColor = Color.White;
                popup.ContentColor = Color.White;
                popup.BodyColor = Color.FromArgb(13, 34, 68);
                popup.BorderColor = Color.FromArgb(91, 155, 213);
                popup.Delay = 2500;
                popup.Popup();
            }
            else if (isDeleting)
            {
                popup.TitleText = "Users";
                popup.ContentText = "Select a user to delete.";
                popup.TitleFont = new Font("Segoe UI", 11, FontStyle.Bold);
                popup.ContentFont = new Font("Segoe UI", 12, FontStyle.Regular);
                popup.Size = new Size(300, 100);
                popup.TitleColor = Color.White;
                popup.ContentColor = Color.White;
                popup.BodyColor = Color.FromArgb(13, 34, 68);
                popup.BorderColor = Color.FromArgb(91, 155, 213);
                popup.Delay = 2500;
                popup.Popup();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            ResetState();
            addUserForm aForm = new addUserForm();
            if (aForm.ShowDialog() == DialogResult.OK)
                LoadUsers();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (UsersDataGrid.RowCount == 0)
            {
                popup.TitleText = "Users";
                popup.ContentText = "There are no users available to edit.";
                popup.TitleFont = new Font("Segoe UI", 11, FontStyle.Bold);
                popup.ContentFont = new Font("Segoe UI", 12, FontStyle.Regular);
                popup.Size = new Size(300, 100);
                popup.TitleColor = Color.White;
                popup.ContentColor = Color.White;
                popup.BodyColor = Color.FromArgb(13, 34, 68);
                popup.BorderColor = Color.FromArgb(91, 155, 213);
                popup.Delay = 2500;
                popup.Popup();
            }
            else if (!isEditing && UsersDataGrid.RowCount >= 1)
            {
                isEditing = true;
                isDeleting = false;
                ShowNotif();
                EditButton.Text = "Cancel";
                EditButton.Padding = new Padding(0, 0, 0, 0);
                DeleteButton.Text = "Delete";
                DeleteButton.Padding = new Padding(15, 0, 0, 0);
                UsersDataGrid.Enabled = true;
                EditIcon.Visible = false;
                DeleteIcon.Visible = true;
            }
            else
            {
                ResetState();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (UsersDataGrid.RowCount == 0)
            {
                popup.TitleText = "Users";
                popup.ContentText = "There are no users available to delete.";
                popup.TitleFont = new Font("Segoe UI", 11, FontStyle.Bold);
                popup.ContentFont = new Font("Segoe UI", 12, FontStyle.Regular);
                popup.Size = new Size(300, 100);
                popup.TitleColor = Color.White;
                popup.ContentColor = Color.White;
                popup.BodyColor = Color.FromArgb(13, 34, 68);
                popup.BorderColor = Color.FromArgb(91, 155, 213);
                popup.Delay = 2500;
                popup.Popup();
            }
            else if (!isDeleting && UsersDataGrid.RowCount >= 1)
            {
                isDeleting = true;
                isEditing = false;
                ShowNotif();
                DeleteButton.Text = "Cancel";
                DeleteButton.Padding = new Padding(0, 0, 0, 0);
                EditButton.Text = "Edit";
                EditButton.Padding = new Padding(10, 0, 0, 0);
                UsersDataGrid.Enabled = true;
                DeleteIcon.Visible = false;
                EditIcon.Visible = true;
            }
            else
            {
                ResetState();
            }
        }

        private void SupplierDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string rawID = UsersDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            int userID = Convert.ToInt32(rawID.Replace("US-", ""));

            if (isEditing)
            {
                editUserForm eForm = new editUserForm(userID);
                if (eForm.ShowDialog() == DialogResult.OK)
                    LoadUsers();
                ResetState();
            }
            else if (isDeleting)
            {
                DialogResult confirm = MessageBox.Show(
                    $"Are you sure you want to delete {rawID}?",
                    "Delete User",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(ConnectionString))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand("DELETE FROM Users WHERE UserID = @ID", conn))
                        {
                            cmd.Parameters.AddWithValue("@ID", userID);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("User deleted.", "Deletion Successful",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUsers();
                }

                ResetState();
            }
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            SearchLabel.Visible = string.IsNullOrWhiteSpace(SearchBox.Text);

            string query = @"
                SELECT 'US-' + CAST(u.UserID AS VARCHAR) AS 'ID',
                       u.Username, u.FirstName AS 'First Name',
                       u.LastName AS 'Last Name',
                       r.RoleName AS 'Role',
                       u.CreatedAt AS 'Created At'
                FROM Users u
                JOIN Roles r ON u.RoleID = r.RoleID
                WHERE u.Username LIKE @Search
                   OR u.FirstName LIKE @Search
                   OR u.LastName LIKE @Search
                   OR r.RoleName LIKE @Search";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@Search", "%" + SearchBox.Text + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                UsersDataGrid.DataSource = dt;
            }

            ClearGridSelection();
        }

        private void SearchBox_Click(object sender, EventArgs e)
        {
            SearchLabel.Visible = false;
        }

        private void SearchBox_MouseLeave(object sender, EventArgs e)
        {
            SearchLabel.Visible = string.IsNullOrWhiteSpace(SearchBox.Text);
        }

        private void ResetState()
        {
            isEditing = false;
            isDeleting = false;
            EditButton.Text = "Edit";
            DeleteButton.Text = "Delete";
            UsersDataGrid.Enabled = false;
            EditIcon.Visible = true;
            DeleteIcon.Visible = true;
            DeleteButton.Padding = new Padding(15, 0, 0, 0);
            EditButton.Padding = new Padding(10, 0, 0, 0);
            ClearGridSelection();
        }

        private void ClearGridSelection()
        {
            BeginInvoke(new Action(() =>
            {
                UsersDataGrid.CurrentCell = null;
                UsersDataGrid.ClearSelection();
            }));
        }

        private void UsersDataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string status = UsersDataGrid.Rows[e.RowIndex].Cells["Status"].Value?.ToString();

            if (status == null) return;

            switch (status)
            {
                case "Active":
                    UsersDataGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                    UsersDataGrid.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                    break;
                case "Inactive":
                    UsersDataGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.IndianRed;
                    UsersDataGrid.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                    break;
            }
        }
    }
}