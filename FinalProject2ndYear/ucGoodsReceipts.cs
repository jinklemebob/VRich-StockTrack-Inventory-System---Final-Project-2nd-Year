using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using Tulpep.NotificationWindow;

namespace FinalProject2ndYear
{
    public partial class ucGoodsReceipts : UserControl
    {
        private bool isEditing = false;
        PopupNotifier popup = new PopupNotifier();
        private const string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StockTrackDB;Integrated Security=True";

        public ucGoodsReceipts()
        {
            InitializeComponent();
        }

        private void ucSuppliers_Load(object sender, EventArgs e)
        {
            LoadGoodsReceipts();
            LoadChartValues();
        }
        public void LoadChartValues()
        {
            TotalRCount.Text = GetChartValues(@"SELECT COUNT(*) FROM GoodsReceipts;");
            TodayValue.Text = GetChartValues(@"SELECT COUNT(*) FROM GoodsReceipts WHERE CAST(CreatedAt AS DATE) = CAST(GETDATE() AS DATE);");
            MonthCount.Text = GetChartValues(@"SELECT COUNT(*) FROM GoodsReceipts WHERE MONTH(CreatedAt) = MONTH(GETDATE()) AND YEAR(CreatedAt) = YEAR(GETDATE());");
        }
        public String GetChartValues(String Query)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(Query, conn))
                {
                    conn.Open();
                    int value = (int)cmd.ExecuteScalar();
                    conn.Close();
                    return value.ToString();
                }
            }
            
        }
        public void LoadGoodsReceipts()
        {
            string query = @"
                SELECT 'GR-' + CAST(gr.ReceiptID AS VARCHAR) AS 'Receipt ID',
                       gr.ReferenceNo AS 'Reference No',
                       s.SupplierName AS 'Supplier',
                       gr.ReceiptDate AS 'Receipt Date',
                       gr.CreatedAt AS 'Created At'
                FROM GoodsReceipts AS gr
                JOIN Suppliers AS s ON gr.SupplierID = s.SupplierID";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ReceiptsDataGrid.DataSource = dt;
            }

            ClearGridSelection();
        }

        public void ShowNotif()
        {
            popup.TitleText = "Goods Receipts";
            popup.ContentText = isEditing ? "Select a receipt to edit." : "";
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

        private void AddButton_Click(object sender, EventArgs e)
        {
            ResetState();
            addGoodsReceiptForm aForm = new addGoodsReceiptForm();
            if (aForm.ShowDialog() == DialogResult.OK)
            {
                LoadGoodsReceipts();
                LoadChartValues();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (ReceiptsDataGrid.RowCount == 0)
            {
                popup.TitleText = "Goods Receipts";
                popup.ContentText = "There are no receipts available to edit.";
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
            else if (!isEditing)
            {
                isEditing = true;
                ShowNotif();
                EditButton.Text = "Cancel";
                EditButton.Padding = new Padding(0, 0, 0, 0);
                ReceiptsDataGrid.Enabled = true;
                EditIcon.Visible = false;
            }
            else
            {
                ResetState();
            }
        }

        private void ReceiptsDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string rawID = ReceiptsDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            int receiptID = Convert.ToInt32(rawID.Replace("GR-", ""));

            if (isEditing)
            {
                editGoodsReceiptForm eForm = new editGoodsReceiptForm(receiptID);
                if (eForm.ShowDialog() == DialogResult.OK)
                    LoadGoodsReceipts();
                ResetState();
            }
            else
            {
                viewGoodsReceiptForm vForm = new viewGoodsReceiptForm(receiptID);
                vForm.ShowDialog();
            }

            ClearGridSelection();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            SearchLabel.Visible = string.IsNullOrWhiteSpace(SearchBox.Text);

            string query = @"
                SELECT 'GR-' + CAST(gr.ReceiptID AS VARCHAR) AS 'Receipt ID',
                       gr.ReferenceNo AS 'Reference No',
                       s.SupplierName AS 'Supplier',
                       gr.ReceiptDate AS 'Receipt Date',
                       gr.CreatedAt AS 'Created At'
                FROM GoodsReceipts gr
                JOIN Suppliers s ON gr.SupplierID = s.SupplierID
                WHERE gr.ReferenceNo LIKE @Search
                   OR s.SupplierName LIKE @Search
                   OR CAST(gr.ReceiptDate AS VARCHAR) LIKE @Search
                   OR ReceiptID LIKE @Search ";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@Search", "%" + SearchBox.Text + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                ReceiptsDataGrid.DataSource = dt;
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
            EditButton.Text = "Edit";
            EditButton.Padding = new Padding(10, 0, 0, 0);
            EditIcon.Visible = true;
            ClearGridSelection();
        }

        private void ClearGridSelection()
        {
            BeginInvoke(new Action(() =>
            {
                ReceiptsDataGrid.CurrentCell = null;
                ReceiptsDataGrid.ClearSelection();
            }));
        }

        private void ReceiptsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EditIcon_Click(object sender, EventArgs e)
        {

        }
    }
}