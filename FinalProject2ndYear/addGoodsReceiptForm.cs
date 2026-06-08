using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FinalProject2ndYear
{
    public partial class addGoodsReceiptForm : Form
    {
        string connectionString = @"Server=(localdb)\MSSQLLocalDB;Initial Catalog=StockTrackDB;Integrated Security=True";

        public addGoodsReceiptForm()
        {
            InitializeComponent();
        }

        private void addGoodsReceiptForm_Load(object sender, EventArgs e)
        {
            LoadSuppliers();
            InitializeItemsGrid();
        }

        private void LoadSuppliers()
        {
            string query = "SELECT SupplierID, SupplierName FROM Suppliers WHERE Status = 1";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                SupplierComboBox.DisplayMember = "SupplierName";
                SupplierComboBox.ValueMember = "SupplierID";
                SupplierComboBox.DataSource = dt;
                SupplierComboBox.SelectedIndex = -1;
            }
        }

        private void InitializeItemsGrid()
        {
            ItemsDataGrid.Columns.Clear();

            DataGridViewComboBoxColumn productCol = new DataGridViewComboBoxColumn();
            productCol.Name = "ProductID";
            productCol.HeaderText = "Product";
            productCol.Width = 200;

            string query = "SELECT ProductID, Description FROM Products";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                productCol.DataSource = dt;
                productCol.DisplayMember = "Description";
                productCol.ValueMember = "ProductID";
            }

 
            DataGridViewTextBoxColumn qtyCol = new DataGridViewTextBoxColumn();
            qtyCol.Name = "Qty";
            qtyCol.HeaderText = "Qty";
            qtyCol.Width = 80;


            DataGridViewTextBoxColumn expiryCol = new DataGridViewTextBoxColumn();
            expiryCol.Name = "ExpiryDate";
            expiryCol.HeaderText = "Expiry Date (M/D/Y)";
            expiryCol.Width = 120;

            ItemsDataGrid.Columns.Add(productCol);
            ItemsDataGrid.Columns.Add(qtyCol);
            ItemsDataGrid.Columns.Add(expiryCol);
        }

        private void AddRowButton_Click(object sender, EventArgs e)
        {
            ItemsDataGrid.Rows.Add();
            ClearGridSelection();
        }

        private void RemoveRowButton_Click(object sender, EventArgs e)
        {
            if (ItemsDataGrid.CurrentRow != null && !ItemsDataGrid.CurrentRow.IsNewRow)
            {
                ItemsDataGrid.Rows.Remove(ItemsDataGrid.CurrentRow);
            }
            else
            {
                MessageBox.Show("Please select a row to remove.", "No Row Selected",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
  
            if (string.IsNullOrWhiteSpace(ReferenceNoTextBox.Text))
            {
                MessageBox.Show("Please enter a Reference No.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (SupplierComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Supplier.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ItemsDataGrid.Rows.Count == 0)
            {
                MessageBox.Show("Please add at least one product.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            DataTable items = new DataTable();
            items.Columns.Add("ProductID", typeof(int));
            items.Columns.Add("Qty", typeof(int));
            items.Columns.Add("ExpiryDate", typeof(DateTime));

            foreach (DataGridViewRow row in ItemsDataGrid.Rows)
            {
                if (row.IsNewRow) continue;

                if (row.Cells["ProductID"].Value == null ||
                    row.Cells["Qty"].Value == null ||
                    row.Cells["ExpiryDate"].Value == null)
                {
                    MessageBox.Show("Please fill in all product fields.", "Validation Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int qty;
                DateTime expiry;

                if (!int.TryParse(row.Cells["Qty"].Value.ToString(), out qty) || qty <= 0)
                {
                    MessageBox.Show("Qty must be a valid number greater than 0.", "Validation Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!DateTime.TryParseExact(row.Cells["ExpiryDate"].Value.ToString(), "MM/dd/yyyy",
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None, out expiry) || expiry.Date < DateTime.Today)
                {
                    MessageBox.Show("Expiry Date must be a valid future date (MM/DD/YYYY).", "Validation Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                items.Rows.Add(
                    Convert.ToInt32(row.Cells["ProductID"].Value),
                    qty,
                    expiry
                );
            }

     
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_CreateGoodsReceipt", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SupplierID", SupplierComboBox.SelectedValue);
                    cmd.Parameters.AddWithValue("@ReferenceNo", ReferenceNoTextBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@ReceiptDate", ReceiptDatePicker.Value.Date);

                    SqlParameter tvp = cmd.Parameters.AddWithValue("@Items", items);
                    tvp.SqlDbType = SqlDbType.Structured;
                    tvp.TypeName = "GoodsReceiptItemsType";

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Goods Receipt created!", "Successful",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
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
        private void ClearGridSelection()
        {
            BeginInvoke(new Action(() =>
            {
                ItemsDataGrid.CurrentCell = null;
                ItemsDataGrid.ClearSelection();
            }));
        }

    }
}