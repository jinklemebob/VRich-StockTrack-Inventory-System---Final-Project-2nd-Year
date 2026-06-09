using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using Tulpep.NotificationWindow;

namespace FinalProject2ndYear
{
    public partial class ucCustomers : UserControl
    {
        private bool isEditing = false;

        PopupNotifier popup = new PopupNotifier();

        private const string ConnectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StockTrackDB;Integrated Security=True";

        public ucCustomers()
        {
            InitializeComponent();
        }

        private void ucCustomers_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        // =========================
        // LOAD CUSTOMERS (WITH FILTER)
        // =========================
        public void LoadCustomers()
        {
            bool showInactive = chkShowInactive.Checked;

            string query = @"
                SELECT 'CS-' + CAST(CustomerID AS VARCHAR) AS 'ID',
                       CustomerName AS 'Name',
                       ContactPerson AS 'Contact',
                       ContactNo AS 'Contact No.',
                       Email,
                       CASE WHEN Status = 1 THEN 'Active' ELSE 'Inactive' END AS Status
                FROM Customers
                WHERE (@ShowInactive = 1 OR Status = 1)";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@ShowInactive", showInactive ? 1 : 0);

                DataTable dt = new DataTable();
                da.Fill(dt);

                CustomerDataGrid.DataSource = dt;
                CustomerDataGrid.Visible = true;
                CustomerDataGrid.Enabled = false;
            }

            RefreshCounts();
            ClearGridSelection();
        }

        // =========================
        // COUNTS
        // =========================
        private void RefreshCounts()
        {
            TotalCustomersCount.Text =
                GetCount("SELECT COUNT(*) FROM Customers").ToString();

            ActiveCount.Text =
                GetCount("SELECT COUNT(*) FROM Customers WHERE Status = 1").ToString();

            InactiveCount.Text =
                GetCount("SELECT COUNT(*) FROM Customers WHERE Status = 0").ToString();
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

            addCustomerForm form = new addCustomerForm();
            if (form.ShowDialog() == DialogResult.OK)
                LoadCustomers();
        }

        // =========================
        // EDIT MODE ONLY
        // =========================
        private void EditButton_Click(object sender, EventArgs e)
        {
            if (!isEditing)
            {
                if (CustomerDataGrid.RowCount == 0)
                {
                    popup.TitleText = "Customers";
                    popup.ContentText = "There are no customers available to edit.";
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

                isEditing = true;
                ShowNotif();

                EditButton.Text = "Cancel";
                CustomerDataGrid.Enabled = true;
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
        private void CustomerDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string rawID = CustomerDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            int customerID = Convert.ToInt32(rawID.Replace("CS-", ""));

            if (isEditing)
            {
                editCustomerForm form = new editCustomerForm(customerID);
                if (form.ShowDialog() == DialogResult.OK)
                    LoadCustomers();

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
                SELECT 'CS-' + CAST(CustomerID AS VARCHAR(10)) AS 'ID',
                       CustomerName AS 'Name',
                       ContactPerson AS 'Contact',
                       ContactNo AS 'Contact No.',
                       Email,
                       CASE WHEN Status = 1 THEN 'Active' ELSE 'Inactive' END AS Status
                FROM Customers
                WHERE CustomerID LIKE @Search
                   OR CustomerName LIKE @Search
                   OR ContactPerson LIKE @Search
                   OR ContactNo LIKE @Search
                   OR Email LIKE @Search";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@Search", "%" + SearchBox.Text + "%");

                DataTable dt = new DataTable();
                da.Fill(dt);

                CustomerDataGrid.DataSource = dt;
            }

            ClearGridSelection();
        }
        public void ShowNotif()
        {
            popup.TitleText = "Customers";
            popup.ContentText = isEditing ? "Select a customer to edit." : "";
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
            LoadCustomers();
        }

        // =========================
        // RESET
        // =========================
        private void ResetState()
        {
            isEditing = false;

            EditButton.Text = "Edit";

            CustomerDataGrid.Enabled = false;

            ClearGridSelection();
        }

        private void ClearGridSelection()
        {
            BeginInvoke(new Action(() =>
            {
                CustomerDataGrid.CurrentCell = null;
                CustomerDataGrid.ClearSelection();
            }));
        }

        // =========================
        // COLOR STATUS
        // =========================
        private void CustomerDataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string status = CustomerDataGrid.Rows[e.RowIndex].Cells["Status"].Value?.ToString();
            if (status == null) return;

            if (status == "Active")
            {
                CustomerDataGrid.Rows[e.RowIndex].Cells["Status"].Style.BackColor = Color.LightGreen;
                CustomerDataGrid.Rows[e.RowIndex].Cells["Status"].Style.ForeColor = Color.Black;
            }
            else if (status == "Inactive")
            {
                CustomerDataGrid.Rows[e.RowIndex].Cells["Status"].Style.BackColor = Color.IndianRed;
                CustomerDataGrid.Rows[e.RowIndex].Cells["Status"].Style.ForeColor = Color.White;
            }
        }
    }
}