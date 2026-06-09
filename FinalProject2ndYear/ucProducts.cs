using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using Tulpep.NotificationWindow;

namespace FinalProject2ndYear
{
    public partial class ucProducts: UserControl
    {
        private bool isEditing = false;
        private bool isDeleting = false;
        PopupNotifier popup = new PopupNotifier();
        private const string ConnectionString = @"Data Source=DESKTOP-K0HOPRM;Initial Catalog=StockTrackDB;Integrated Security=True;TrustServerCertificate=True";

        public ucProducts()
        {
            InitializeComponent();
        }

        private void ucSuppliers_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        public void LoadProducts()
        {
            string query = @"
                 SELECT 'PD-' + CAST(p.ProductID AS VARCHAR) AS 'ID',
                 p.Description, c.CategoryName AS 'Category', 
                 p.ReorderLvl AS 'Reorder Lvl', UPPER(u.UOMName) AS 'UoM',
                 CASE WHEN p.Status = 1 THEN 'Active' ELSE 'Inactive' END AS 'Status',
                 p.CreatedAt AS 'Created At'
                 FROM Products AS p 
                 JOIN UOMs AS u ON p.UOMID = u.UOMID
                 JOIN Categories AS c ON p.CategoryID = c.CategoryID";


            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ProductDataGrid.DataSource = dt;
            }

            RefreshCounts();
            ClearGridSelection();
        }

        private void RefreshCounts()
        {
            TotalSuppliersCount.Text = GetCount("SELECT COUNT(*) FROM Products").ToString();
            AddedTodayText.Text = GetCount("SELECT COUNT(*) FROM Products WHERE CreatedAt = GETDATE()").ToString();
            RecentAddText.Text = GetDesc("SELECT TOP 1 Description FROM Products ORDER BY CreatedAt DESC, ProductID DESC").ToString();
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

        public void ShowNotif()
        {
            if (isEditing == true)
            {
                popup.TitleText = "Products";
                popup.ContentText = "Select a product to edit.";
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
                popup.TitleText = "Products";
                popup.ContentText = "Select a product to delete.";
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

            addProductForm aForm = new addProductForm();
            if (aForm.ShowDialog() == DialogResult.OK)
            {
                LoadProducts();
            }
               
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (ProductDataGrid.RowCount == 0)
            {
                popup.TitleText = "Products";
                popup.ContentText = "There are no products available to edit.";
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
            else if (!isEditing && ProductDataGrid.RowCount >= 1)
            {
                isEditing = true;
                isDeleting = false;
                ShowNotif();
                EditButton.Text = "Cancel";
                EditButton.Padding = new Padding(0, 0, 0, 0);
                DeleteButton.Text = "Delete";
                DeleteButton.Padding = new Padding(15, 0, 0, 0);
                ProductDataGrid.Enabled = true;
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
            if (ProductDataGrid.RowCount == 0)
            {
                popup.TitleText = "Products";
                popup.ContentText = "There are no products available to delete.";
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
            else if (!isDeleting && ProductDataGrid.RowCount >= 1)
            {
                isDeleting = true;
                isEditing = false;
                ShowNotif();
                DeleteButton.Text = "Cancel";
                DeleteButton.Padding = new Padding(0, 0, 0, 0);
                EditButton.Text = "Edit";
                EditButton.Padding = new Padding(10, 0, 0, 0);
                ProductDataGrid.Enabled = true;
                DeleteIcon.Visible = false;
                EditIcon.Visible = true;
            }
            else
            {
                ResetState();
             
                
            }
        }

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
            else if (isDeleting)
            {
                DialogResult confirm = MessageBox.Show(
                    $"Are you sure you want to delete {rawID}?",
                    "Delete Product",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(ConnectionString))
                    {
                        conn.Open();

                        using (SqlCommand check = new SqlCommand(
                            @"SELECT COUNT(*) FROM GoodsReceiptItems WHERE ProductID = @ID", conn))
                        {
                            check.Parameters.AddWithValue("@ID", productID);
                            int count = (int)check.ExecuteScalar();

                            if (count > 0)
                            {
                                using (SqlCommand cmd = new SqlCommand(
                                    "UPDATE Products SET Status = 0 WHERE ProductID = @ID", conn))
                                {
                                    cmd.Parameters.AddWithValue("@ID", productID);
                                    cmd.ExecuteNonQuery();
                                }
                                MessageBox.Show("Product is used in existing transactions and has been marked as inactive instead.",
                                                "Product Deactivated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                using (SqlCommand cmd = new SqlCommand(
                                    "DELETE FROM Products WHERE ProductID = @ID", conn))
                                {
                                    cmd.Parameters.AddWithValue("@ID", productID);
                                    cmd.ExecuteNonQuery();
                                }
                                MessageBox.Show("Product deleted.", "Deletion Successful",
                                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }

                    LoadProducts();
                }

                ResetState();
            }

        }


        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            SearchLabel.Visible = string.IsNullOrWhiteSpace(SearchBox.Text);

            string query = @"
        SELECT 'PD-' + CAST(p.ProductID AS VARCHAR) AS 'ID',
               p.Description, c.CategoryName AS 'Category', 
               p.ReorderLvl AS 'Reorder Lvl', UPPER(u.UOMName) AS 'UoM',
               CASE WHEN p.Status = 1 THEN 'Active' ELSE 'Inactive' END AS 'Status',
               p.CreatedAt AS 'Created At'
        FROM Products AS p 
        JOIN UOMs AS u ON p.UOMID = u.UOMID
        JOIN Categories AS c ON p.CategoryID = c.CategoryID
        WHERE CAST(p.ProductID AS VARCHAR) LIKE @Search
           OR p.Description               LIKE @Search
           OR c.CategoryName              LIKE @Search
           OR UPPER(u.UOMName)            LIKE @Search
           OR CASE WHEN p.Status = 1 THEN 'Active' ELSE 'Inactive' END LIKE @Search";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@Search", "%" + SearchBox.Text + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                ProductDataGrid.DataSource = dt;
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
            ProductDataGrid.Enabled = false;
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
                ProductDataGrid.CurrentCell = null;
                ProductDataGrid.ClearSelection();
            }));
        }

        private void ProductDataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string status = ProductDataGrid.Rows[e.RowIndex].Cells["Status"].Value?.ToString();

            if (status == null) return;

            switch (status)
            {
                case "Active":
                    ProductDataGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                    ProductDataGrid.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                    break;
                case "Inactive":
                    ProductDataGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.IndianRed;
                    ProductDataGrid.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                    break;
            }
        }
    }
}