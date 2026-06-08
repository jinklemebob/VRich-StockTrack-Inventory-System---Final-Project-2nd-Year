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
        private bool isDeleting = false;
        PopupNotifier popup = new PopupNotifier();
        private const string ConnectionString = @"Server=(localdb)\MSSQLLocalDB;Initial Catalog=StockTrackDB;Integrated Security=True";

        public ucCustomers()
        {
            InitializeComponent();
        }

        private void ucCustomers_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        public void LoadCustomers()
        {

            string query = @"
                SELECT 'CS-' + CAST(CustomerID AS VARCHAR) AS 'ID',
                       CustomerName AS 'Name', ContactPerson AS 'Contact Person', ContactNo AS 'Contact No.', Email,
                       CASE WHEN Status = 1 THEN 'Active' ELSE 'Inactive' END AS Status
                FROM Customers";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                CustomerDataGrid.DataSource = dt;
                CustomerDataGrid.Visible = true;
                CustomerDataGrid.Enabled = false;
            }

            RefreshCounts();
            ClearGridSelection();
        }

        private void RefreshCounts()
        {
            TotalCustomersCount.Text = GetCount("SELECT COUNT(*) FROM Customers").ToString();
            ActiveCount.Text = GetCount("SELECT COUNT(*) FROM Customers WHERE Status = 1").ToString();
            InactiveCount.Text = GetCount("SELECT COUNT(*) FROM Customers WHERE Status = 0").ToString();
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
            if (isEditing == true)
            {
                popup.TitleText = "Customers";
                popup.ContentText = "Select a customer to edit.";
                popup.TitleFont = new Font("Segoe UI", 11, FontStyle.Bold);
                popup.ContentFont = new Font("Segoe UI", 12, FontStyle.Regular);

                // Size
                popup.Size = new Size(300, 100);

                // Colors to match your UI
                popup.TitleColor = Color.White;
                popup.ContentColor = Color.White;
                popup.BodyColor = Color.FromArgb(13, 34, 68);  // your navy
                popup.BorderColor = Color.FromArgb(91, 155, 213);
                popup.Delay = 2500;
                popup.Popup();
            }
            else if (isDeleting == true)
            {
                popup.TitleText = "Customers";
                popup.ContentText = "Select a customer to delete.";
                popup.TitleFont = new Font("Segoe UI", 11, FontStyle.Bold);
                popup.ContentFont = new Font("Segoe UI", 12, FontStyle.Regular);

                // Size
                popup.Size = new Size(300, 100);
                // Colors to match your UI
                popup.TitleColor = Color.White;
                popup.ContentColor = Color.White;
                popup.BodyColor = Color.FromArgb(13, 34, 68);  // your navy
                popup.BorderColor = Color.FromArgb(91, 155, 213);
                popup.Delay = 2500;
                popup.Popup();
            }
         
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            ResetState();

            addCustomerForm aForm = new addCustomerForm();
            if (aForm.ShowDialog() == DialogResult.OK)
                LoadCustomers();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (CustomerDataGrid.RowCount == 0)
            {
                popup.TitleText = "Customers";
                popup.ContentText = "There are no customers available to edit.";
                popup.TitleFont = new Font("Segoe UI", 11, FontStyle.Bold);
                popup.ContentFont = new Font("Segoe UI", 12, FontStyle.Regular);

                // Size
                popup.Size = new Size(300, 100);
                // Colors to match your UI
                popup.TitleColor = Color.White;
                popup.ContentColor = Color.White;
                popup.BodyColor = Color.FromArgb(13, 34, 68);  // your navy
                popup.BorderColor = Color.FromArgb(91, 155, 213);
                popup.Delay = 2500;
                popup.Popup();
            }
            else if (!isEditing && CustomerDataGrid.RowCount >= 1)
            {
                isEditing = true;
                isDeleting = false;
                ShowNotif();
                EditButton.Text = "Cancel";
                EditButton.Padding = new Padding(0, 0, 0, 0);
                DeleteButton.Text = "Delete";
                DeleteButton.Padding = new Padding(15, 0, 0, 0);
                CustomerDataGrid.Enabled = true;
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
            if (CustomerDataGrid.RowCount == 0)
            {
                popup.TitleText = "Customers";
                popup.ContentText = "There are no customers available to delete.";
                popup.TitleFont = new Font("Segoe UI", 11, FontStyle.Bold);
                popup.ContentFont = new Font("Segoe UI", 12, FontStyle.Regular);

                // Size
                popup.Size = new Size(300, 100);
                // Colors to match your UI
                popup.TitleColor = Color.White;
                popup.ContentColor = Color.White;
                popup.BodyColor = Color.FromArgb(13, 34, 68);  // your navy
                popup.BorderColor = Color.FromArgb(91, 155, 213);
                popup.Delay = 2500;
                popup.Popup();
            }
            else if (!isDeleting && CustomerDataGrid.RowCount >= 1)
            {
                isDeleting = true;
                isEditing = false;
                ShowNotif();
                DeleteButton.Text = "Cancel";
                DeleteButton.Padding = new Padding(0, 0, 0, 0);
                EditButton.Text = "Edit";
                EditButton.Padding = new Padding(10, 0, 0, 0);
                CustomerDataGrid.Enabled = true;
                DeleteIcon.Visible = false;
                EditIcon.Visible = true;
            }
            else
            {
                ResetState();
             
                
            }
        }

        private void CustomerDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string rawID = CustomerDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            int customerID = Convert.ToInt32(rawID.Replace("CS-", ""));

            if (isEditing)
            {
                editCustomerForm eForm = new editCustomerForm(customerID);
                if (eForm.ShowDialog() == DialogResult.OK)
                    LoadCustomers();
                ResetState();
            }
            else if (isDeleting)
            {
                DialogResult confirm = MessageBox.Show(
                    $"Are you sure you want to delete {rawID}?",
                    "Delete Customer",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(ConnectionString))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand("DELETE FROM Customers WHERE CustomerID = @ID", conn))
                        {
                            cmd.Parameters.AddWithValue("@ID", customerID);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Customer deleted.", "Deletion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCustomers();
                }
                ResetState();
            }
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            SearchLabel.Visible = string.IsNullOrWhiteSpace(SearchBox.Text);

            string query = @"
                SELECT 'CS-' + CAST(CustomerID AS VARCHAR(10)) AS 'ID',
                       CustomerName AS 'Name', ContactPerson AS 'Contact Person', ContactNo AS 'Contact No.', Email,
                       CASE WHEN Status = 1 THEN 'Active' ELSE 'Inactive' END AS Status
                FROM Customers
                WHERE CustomerID    LIKE @Search
                   OR CustomerName  LIKE @Search
                   OR ContactPerson LIKE @Search
                   OR ContactNo     LIKE @Search
                   OR Email         LIKE @Search";

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
            CustomerDataGrid.Enabled = false;
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
                CustomerDataGrid.CurrentCell = null;
                CustomerDataGrid.ClearSelection();
            }));
        }

        private void CustomerDataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string status = CustomerDataGrid.Rows[e.RowIndex].Cells["Status"].Value?.ToString();

            if (status == null) return;

            switch (status)
            {
                case "Active":
                    CustomerDataGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                    CustomerDataGrid.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                    break;
                case "Inactive":
                    CustomerDataGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.IndianRed;
                    CustomerDataGrid.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                    break;
            }
            }
    }
}