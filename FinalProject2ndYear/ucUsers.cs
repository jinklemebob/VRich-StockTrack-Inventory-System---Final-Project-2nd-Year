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

        PopupNotifier popup = new PopupNotifier();

        private const string ConnectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StockTrackDB;Integrated Security=True";

        public ucUsers()
        {
            InitializeComponent();
        }

        private void ucUsers_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        // =========================
        // LOAD USERS (WITH FILTER)
        // =========================
        public void LoadUsers()
        {
            bool showInactive = chkShowInactive.Checked;

            string query = @"
                SELECT 'US-' + CAST(u.UserID AS VARCHAR) AS 'ID',
                       u.Username,
                       u.FirstName AS 'First Name',
                       u.LastName AS 'Last Name',
                       r.RoleName AS 'Role',
                       u.CreatedAt AS 'Created At',
                       CASE WHEN u.Status = 1 THEN 'Active' ELSE 'Inactive' END AS Status
                FROM Users u
                JOIN Roles r ON u.RoleID = r.RoleID
                WHERE (@ShowInactive = 1 OR u.Status = 1)";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@ShowInactive", showInactive ? 1 : 0);

                DataTable dt = new DataTable();
                da.Fill(dt);

                UsersDataGrid.DataSource = dt;
                UsersDataGrid.Visible = true;
                UsersDataGrid.Enabled = false;
            }

            RefreshCounts();
            ClearGridSelection();
        }

        // =========================
        // COUNTS
        // =========================
        private void RefreshCounts()
        {
            TotalUsersCount.Text =
                GetCount("SELECT COUNT(*) FROM Users").ToString();

            ActiveCount.Text =
                GetCount("SELECT COUNT(*) FROM Users WHERE Status = 1").ToString();

            InactiveCount.Text =
                GetCount("SELECT COUNT(*) FROM Users WHERE Status = 0").ToString();
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

        // =========================
        // ADD
        // =========================
        private void AddButton_Click(object sender, EventArgs e)
        {
            ResetState();

            addUserForm form = new addUserForm();
            if (form.ShowDialog() == DialogResult.OK)
                LoadUsers();
        }

        // =========================
        // EDIT ONLY MODE
        // =========================
        private void EditButton_Click(object sender, EventArgs e)
        {
            if (!isEditing)
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
                    return;
                }

                // rows exist — enter edit mode
                isEditing = true;

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

                EditButton.Text = "Cancel";
                UsersDataGrid.Enabled = true;
                EditIcon.Visible = false;
            }
            else
            {
                ResetState();
            }
        }

        // =========================
        // GRID CLICK (EDIT ONLY)
        // =========================
        private void UsersDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string rawID = UsersDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            int userID = Convert.ToInt32(rawID.Replace("US-", ""));

            if (isEditing)
            {
                editUserForm form = new editUserForm(userID);
                if (form.ShowDialog() == DialogResult.OK)
                    LoadUsers();

                ResetState();
            }
        }

        // =========================
        // SEARCH
        // =========================
        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            SearchLabel.Visible = string.IsNullOrWhiteSpace(SearchBox.Text);

            string query = @"
                SELECT 'US-' + CAST(u.UserID AS VARCHAR) AS 'ID',
                       u.Username,
                       u.FirstName AS 'First Name',
                       u.LastName AS 'Last Name',
                       r.RoleName AS 'Role',
                       u.CreatedAt AS 'Created At',
                       CASE WHEN u.Status = 1 THEN 'Active' ELSE 'Inactive' END AS Status
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

        // =========================
        // SHOW INACTIVE TOGGLE
        // =========================
        private void ShowInactive_CheckedChanged(object sender, EventArgs e)
        {
            LoadUsers();
        }

        // =========================
        // RESET STATE
        // =========================
        private void ResetState()
        {
            isEditing = false;

            EditButton.Text = "Edit";

            UsersDataGrid.Enabled = false;

            EditIcon.Visible = true;

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

        // =========================
        // STATUS COLOR
        // =========================
        private void UsersDataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string status = UsersDataGrid.Rows[e.RowIndex].Cells["Status"].Value?.ToString();
            if (status == null) return;

            if (status == "Active")
            {
                UsersDataGrid.Rows[e.RowIndex].Cells["Status"].Style.BackColor = Color.LightGreen;
                UsersDataGrid.Rows[e.RowIndex].Cells["Status"].Style.ForeColor = Color.Black;
            }
            else if (status == "Inactive")
            {
                UsersDataGrid.Rows[e.RowIndex].Cells["Status"].Style.BackColor = Color.IndianRed;
                UsersDataGrid.Rows[e.RowIndex].Cells["Status"].Style.ForeColor = Color.White;
            }
        }
    }
}