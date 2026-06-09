using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using Tulpep.NotificationWindow;

namespace FinalProject2ndYear
{
    public partial class ucSuppliers : UserControl
    {
        private bool isEditing = false;
        private bool isDeleting = false;
        PopupNotifier popup = new PopupNotifier();
        private const string ConnectionString = @"Data Source=DESKTOP-K0HOPRM;Initial Catalog=StockTrackDB;Integrated Security=True;TrustServerCertificate=True";

        public ucSuppliers()
        {
            InitializeComponent();
        }

        private void ucSuppliers_Load(object sender, EventArgs e)
        {
            LoadSuppliers();
        }

        public void LoadSuppliers()
        {
            string query = @"
                SELECT 'SP-' + CAST(SupplierID AS VARCHAR) AS 'ID',
                       SupplierName AS 'Name', ContactPerson AS 'Contact', ContactNo AS 'Contact No.', Email,
                       CASE WHEN Status = 1 THEN 'Active' ELSE 'Inactive' END AS Status
                FROM Suppliers";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                SupplierDataGrid.DataSource = dt;
            }

            RefreshCounts();
            ClearGridSelection();
        }

        private void RefreshCounts()
        {
            TotalSuppliersCount.Text = GetCount("SELECT COUNT(*) FROM Suppliers").ToString();
            ActiveCount.Text = GetCount("SELECT COUNT(*) FROM Suppliers WHERE Status = 1").ToString();
            InactiveCount.Text = GetCount("SELECT COUNT(*) FROM Suppliers WHERE Status = 0").ToString();
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
                popup.TitleText = "Suppliers";
                popup.ContentText = "Select a supplier to edit.";
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
                popup.TitleText = "Suppliers";
                popup.ContentText = "Select a supplier to delete.";
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

            addSupplierForm aForm = new addSupplierForm();
            if (aForm.ShowDialog() == DialogResult.OK)
                LoadSuppliers();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (SupplierDataGrid.RowCount == 0)
            {
                popup.TitleText = "Suppliers";
                popup.ContentText = "There are no suppliers available to edit.";
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
            else if (!isEditing && SupplierDataGrid.RowCount >= 1)
            {
                isEditing = true;
                isDeleting = false;
                ShowNotif();
                EditButton.Text = "Cancel";
                EditButton.Padding = new Padding(0, 0, 0, 0);
                DeleteButton.Text = "Delete";
                DeleteButton.Padding = new Padding(15, 0, 0, 0);
                SupplierDataGrid.Enabled = true;
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
            if (SupplierDataGrid.RowCount == 0)
            {
                popup.TitleText = "Suppliers";
                popup.ContentText = "There are no suppliers available to delete.";
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
            else if (!isDeleting && SupplierDataGrid.RowCount >= 1)
            {
                isDeleting = true;
                isEditing = false;
                ShowNotif();
                DeleteButton.Text = "Cancel";
                DeleteButton.Padding = new Padding(0, 0, 0, 0);
                EditButton.Text = "Edit";
                EditButton.Padding = new Padding(10, 0, 0, 0);
                SupplierDataGrid.Enabled = true;
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

            string rawID = SupplierDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            int supplierID = Convert.ToInt32(rawID.Replace("SP-", ""));

            if (isEditing)
            {
                editSupplierForm eForm = new editSupplierForm(supplierID);
                if (eForm.ShowDialog() == DialogResult.OK)
                    LoadSuppliers();

                ResetState();
                
            }
            else if (isDeleting)
            {
                DialogResult confirm = MessageBox.Show(
                    $"Are you sure you want to delete {rawID}?",
                    "Delete Supplier",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(ConnectionString))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand("DELETE FROM Suppliers WHERE SupplierID = @ID", conn))
                        {
                            cmd.Parameters.AddWithValue("@ID", supplierID);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Supplier deleted.","Deletion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    LoadSuppliers();
                }

                ResetState();
               
            }
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            SearchLabel.Visible = string.IsNullOrWhiteSpace(SearchBox.Text);

            string query = @"
                SELECT 'SP-' + CAST(SupplierID AS VARCHAR(10)) AS SupplierID,
                       SupplierName, ContactPerson, ContactNo, Email,
                       CASE WHEN Status = 1 THEN 'Active' ELSE 'Inactive' END AS Status
                FROM Suppliers
                WHERE SupplierID    LIKE @Search
                   OR SupplierName  LIKE @Search
                   OR ContactPerson LIKE @Search
                   OR ContactNo     LIKE @Search
                   OR Email         LIKE @Search";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@Search", "%" + SearchBox.Text + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                SupplierDataGrid.DataSource = dt;
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
            SupplierDataGrid.Enabled = false;
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
                SupplierDataGrid.CurrentCell = null;
                SupplierDataGrid.ClearSelection();
            }));
        }

        private void SupplierDataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string status = SupplierDataGrid.Rows[e.RowIndex].Cells["Status"].Value?.ToString();

            if (status == null) return;

            switch (status)
            {
                case "Active":
                    SupplierDataGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                    SupplierDataGrid.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                    break;
                case "Inactive":
                    SupplierDataGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.IndianRed;
                    SupplierDataGrid.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                    break;
            }
        }

        private void SupplierDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}