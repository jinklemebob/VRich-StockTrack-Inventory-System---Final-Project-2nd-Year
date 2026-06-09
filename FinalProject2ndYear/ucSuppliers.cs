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

        PopupNotifier popup = new PopupNotifier();

        private const string ConnectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StockTrackDB;Integrated Security=True";

        public ucSuppliers()
        {
            InitializeComponent();
        }

        private void ucSuppliers_Load(object sender, EventArgs e)
        {
            LoadSuppliers();
        }

        // =========================
        // LOAD SUPPLIERS (WITH FILTER)
        // =========================
        public void LoadSuppliers()
        {
            bool showInactive = chkShowInactive.Checked;

            string query = @"
                SELECT 'SP-' + CAST(SupplierID AS VARCHAR) AS 'ID',
                       SupplierName AS 'Name',
                       ContactPerson AS 'Contact',
                       ContactNo AS 'Contact No.',
                       Email,
                       CASE WHEN Status = 1 THEN 'Active' ELSE 'Inactive' END AS Status
                FROM Suppliers
                WHERE (@ShowInactive = 1 OR Status = 1)";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@ShowInactive", showInactive ? 1 : 0);

                DataTable dt = new DataTable();
                da.Fill(dt);

                SupplierDataGrid.DataSource = dt;
                SupplierDataGrid.Visible = true;
                SupplierDataGrid.Enabled = false;
            }

            RefreshCounts();
            ClearGridSelection();
        }

        // =========================
        // COUNTS
        // =========================
        private void RefreshCounts()
        {
            TotalSuppliersCount.Text =
                GetCount("SELECT COUNT(*) FROM Suppliers").ToString();

            ActiveCount.Text =
                GetCount("SELECT COUNT(*) FROM Suppliers WHERE Status = 1").ToString();

            InactiveCount.Text =
                GetCount("SELECT COUNT(*) FROM Suppliers WHERE Status = 0").ToString();
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

            addSupplierForm form = new addSupplierForm();
            if (form.ShowDialog() == DialogResult.OK)
                LoadSuppliers();
        }

        // =========================
        // EDIT ONLY MODE
        // =========================
        private void EditButton_Click(object sender, EventArgs e)
        {
            if (!isEditing)
            {
                if (SupplierDataGrid.RowCount == 0)
                {
                    popup.TitleText = "Suppliers";
                    popup.ContentText = "There are no suppliers available to edit.";
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

                popup.TitleText = "Suppliers";
                popup.ContentText = "Select a supplier to edit.";
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
                SupplierDataGrid.Enabled = true;
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
        private void SupplierDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string rawID = SupplierDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            int supplierID = Convert.ToInt32(rawID.Replace("SP-", ""));

            if (isEditing)
            {
                editSupplierForm form = new editSupplierForm(supplierID);
                if (form.ShowDialog() == DialogResult.OK)
                    LoadSuppliers();

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
                SELECT 'SP-' + CAST(SupplierID AS VARCHAR(10)) AS 'ID',
                       SupplierName AS 'Name',
                       ContactPerson AS 'Contact',
                       ContactNo AS 'Contact No.',
                       Email,
                       CASE WHEN Status = 1 THEN 'Active' ELSE 'Inactive' END AS Status
                FROM Suppliers
                WHERE SupplierID LIKE @Search
                   OR SupplierName LIKE @Search
                   OR ContactPerson LIKE @Search
                   OR ContactNo LIKE @Search
                   OR Email LIKE @Search";

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

        // =========================
        // SHOW INACTIVE TOGGLE
        // =========================
        private void ShowInactive_CheckedChanged(object sender, EventArgs e)
        {
            LoadSuppliers();
        }

        // =========================
        // RESET STATE
        // =========================
        private void ResetState()
        {
            isEditing = false;

            EditButton.Text = "Edit";

            SupplierDataGrid.Enabled = false;

            EditIcon.Visible = true;

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

        // =========================
        // STATUS COLOR
        // =========================
        private void SupplierDataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string status = SupplierDataGrid.Rows[e.RowIndex].Cells["Status"].Value?.ToString();
            if (status == null) return;

            if (status == "Active")
            {
                SupplierDataGrid.Rows[e.RowIndex].Cells["Status"].Style.BackColor = Color.LightGreen;
                SupplierDataGrid.Rows[e.RowIndex].Cells["Status"].Style.ForeColor = Color.Black;
            }
            else if (status == "Inactive")
            {
                SupplierDataGrid.Rows[e.RowIndex].Cells["Status"].Style.BackColor = Color.IndianRed;
                SupplierDataGrid.Rows[e.RowIndex].Cells["Status"].Style.ForeColor = Color.White;
            }
        }
    }
}