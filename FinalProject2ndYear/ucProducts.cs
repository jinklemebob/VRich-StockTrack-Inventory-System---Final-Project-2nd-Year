using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using Tulpep.NotificationWindow;

namespace FinalProject2ndYear
{
    public partial class ucProducts : UserControl
    {
        private bool isEditing = false;
        PopupNotifier popup = new PopupNotifier();

        private const string ConnectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StockTrackDB;Integrated Security=True";

        public ucProducts()
        {
            InitializeComponent();
        }

        private void ucSuppliers_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        // ✅ MAIN LOAD (FILTERED BY CHECKBOX)
        public void LoadProducts()
        {
            string query = @"
SELECT 'PD-' + CAST(p.ProductID AS VARCHAR) AS 'ID',
       p.Description,
       c.CategoryName AS 'Category',
       s.SupplierName + CASE WHEN s.Status = 0 THEN ' (Inactive)' ELSE '' END AS 'Supplier',
       p.ReorderLvl AS 'Reorder Lvl',
       u.UOMName AS 'UoM',
       CASE
           WHEN p.Status = 1 THEN 'Active'
           ELSE 'Inactive'
       END AS 'Status'
FROM Products p
JOIN UOMs u ON p.UOMID = u.UOMID
JOIN Categories c ON p.CategoryID = c.CategoryID
LEFT JOIN Suppliers s ON p.SupplierID = s.SupplierID
WHERE (@ShowInactive = 1 OR p.Status = 1)";
        
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);

                da.SelectCommand.Parameters.AddWithValue(
                    "@ShowInactive",
                    chkShowInactive.Checked ? 1 : 0
                );

                DataTable dt = new DataTable();
                da.Fill(dt);
                ProductDataGrid.DataSource = dt;
            }

            RefreshCounts();
            ClearGridSelection();
        }

        // ---------------- COUNTS ----------------
        private void RefreshCounts()
        {
            TotalSuppliersCount.Text = GetCount("SELECT COUNT(*) FROM Products").ToString();

            AddedTodayText.Text = GetCount(@"
                SELECT COUNT(*) 
                FROM Products 
                WHERE CAST(CreatedAt AS DATE) = CAST(GETDATE() AS DATE)").ToString();

            RecentAddText.Text = GetDesc(@"
                SELECT TOP 1 Description 
                FROM Products 
                ORDER BY CreatedAt DESC, ProductID DESC");
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

        private string GetDesc(string query)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    var result = cmd.ExecuteScalar();
                    return result != null ? result.ToString() : "None";
                }
            }
        }

        // ---------------- NOTIF ----------------
       

        // ---------------- ADD ----------------
        private void AddButton_Click(object sender, EventArgs e)
        {
            ResetState();

            addProductForm aForm = new addProductForm();
            if (aForm.ShowDialog() == DialogResult.OK)
            {
                LoadProducts();
            }
        }

        // ---------------- EDIT MODE ----------------
        private void EditButton_Click(object sender, EventArgs e)
        {
            if (!isEditing)
            {
                if (ProductDataGrid.RowCount == 0)
                {
                    popup.TitleText = "Products";
                    popup.ContentText = "There are no products available to edit.";
                    popup.TitleFont = new Font("Segoe UI", 11, FontStyle.Bold);
                    popup.ContentFont = new Font("Segoe UI", 12, FontStyle.Regular);
                    popup.Size = new Size(300, 100);
                    popup.TitleColor = Color.White;
                    popup.ContentColor = Color.White;
                    popup.BodyColor = Color.FromArgb(13, 34, 68);
                    popup.BorderColor = Color.FromArgb(91, 155, 213);
                    popup.Delay = 2500;
                    popup.Popup();
                    return; // stop here, don't enter edit mode
                }

                // rows exist — enter edit mode
                isEditing = true;
                ShowNotif(); // shows "Select a product to edit."

                EditButton.Text = "Cancel";
                ProductDataGrid.Enabled = true;
                EditIcon.Visible = false;
            }
            else
            {
                ResetState(); // cancel edit mode
            }
        }

        // ---------------- GRID CLICK ----------------
        private void ProductDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string rawID = ProductDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            int productID = Convert.ToInt32(rawID.Replace("PD-", ""));

            if (isEditing)
            {
                editProductForm eForm = new editProductForm(productID);

                if (eForm.ShowDialog() == DialogResult.OK)
                    LoadProducts();

                ResetState();
            }
        }

        // ---------------- SEARCH ----------------
        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            SearchLabel.Visible = string.IsNullOrWhiteSpace(SearchBox.Text);

            string query = @"
SELECT 'PD-' + CAST(p.ProductID AS VARCHAR) AS 'ID',
       p.Description, 
       c.CategoryName AS 'Category', 
       s.SupplierName + CASE WHEN s.Status = 0 THEN ' (Inactive)' ELSE '' END AS 'Supplier',
       p.ReorderLvl AS 'Reorder Lvl', 
       u.UOMName AS 'UoM',
       CASE WHEN p.Status = 1 THEN 'Active' ELSE 'Inactive' END AS 'Status'
FROM Products p
JOIN UOMs u ON p.UOMID = u.UOMID
JOIN Categories c ON p.CategoryID = c.CategoryID
LEFT JOIN Suppliers s ON p.SupplierID = s.SupplierID
WHERE (CAST(p.ProductID AS VARCHAR) LIKE @Search
   OR p.Description LIKE @Search
   OR c.CategoryName LIKE @Search
   OR s.SupplierName LIKE @Search
   OR p.ReorderLvl LIKE @Search
   OR u.UOMName LIKE @Search
   OR CASE WHEN p.Status = 1 THEN 'Active' ELSE 'Inactive' END LIKE @Search)
AND (@ShowInactive = 1 OR p.Status = 1)";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@Search", "%" + SearchBox.Text + "%");
                da.SelectCommand.Parameters.AddWithValue("@ShowInactive", chkShowInactive.Checked ? 1 : 0);

                DataTable dt = new DataTable();
                da.Fill(dt);
                ProductDataGrid.DataSource = dt;
            }

            ClearGridSelection();
        }
        public void ShowNotif()
        {
            popup.TitleText = "Products";
            popup.ContentText = isEditing ? "Select a product to edit." : "";
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
        private void chkShowInactive_CheckedChanged(object sender, EventArgs e)
        {
            LoadProducts();
        }

        // ---------------- RESET ----------------
        private void ResetState()
        {
            isEditing = false;

            EditButton.Text = "Edit";
            EditIcon.Visible = true;

            ProductDataGrid.Enabled = true;

            ClearGridSelection();
        }

        private void ClearGridSelection()
        {
            BeginInvoke(new Action(() =>
            {
                ProductDataGrid.CurrentCell = null;
                ProductDataGrid.ClearSelection();
            }));
        }

        // ---------------- UI CLEANUP ----------------
        private void ProductDataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string status = ProductDataGrid.Rows[e.RowIndex].Cells["Status"].Value?.ToString();
            if (status == null) return;

            if (status == "Active")
            {
                ProductDataGrid.Rows[e.RowIndex].Cells["Status"].Style.BackColor = Color.LightGreen;
                ProductDataGrid.Rows[e.RowIndex].Cells["Status"].Style.ForeColor = Color.Black;
            }
            else
            {
                ProductDataGrid.Rows[e.RowIndex].Cells["Status"].Style.BackColor = Color.IndianRed;
                ProductDataGrid.Rows[e.RowIndex].Cells["Status"].Style.ForeColor = Color.White;
            }
        }
    }
}