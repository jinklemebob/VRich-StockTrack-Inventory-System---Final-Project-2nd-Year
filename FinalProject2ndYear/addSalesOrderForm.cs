using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FinalProject2ndYear
{
    public partial class addSalesOrderForm : Form
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StockTrackDB;Integrated Security=True";

        public addSalesOrderForm()
        {
            InitializeComponent();
        }

        private void addSalesOrderForm_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            InitializeItemsGrid();
        }

        private void LoadCustomers()
        {
            string query = "SELECT CustomerID, CustomerName FROM Customers WHERE Status = 1";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                CustomerComboBox.DisplayMember = "CustomerName";
                CustomerComboBox.ValueMember = "CustomerID";
                CustomerComboBox.DataSource = dt;
                CustomerComboBox.SelectedIndex = -1;
            }
        }

        private void InitializeItemsGrid()
        {
            ItemsDataGrid.Columns.Clear();

            DataGridViewComboBoxColumn productCol = new DataGridViewComboBoxColumn();
            productCol.Name = "ProductID";
            productCol.HeaderText = "Product";
            productCol.Width = 200;

            string query = "SELECT ProductID, Description FROM Products WHERE Status = 1";
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

            ItemsDataGrid.Columns.Add(productCol);
            ItemsDataGrid.Columns.Add(qtyCol);
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
            // 1. Validate header
            if (string.IsNullOrWhiteSpace(ReferenceNoTextBox.Text))
            {
                MessageBox.Show("Please enter a Reference No.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (CustomerComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Customer.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ItemsDataGrid.Rows.Count == 0)
            {
                MessageBox.Show("Please add at least one product.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (OrderDatePicker.Value.Date > DateTime.Today)
            {
                MessageBox.Show("Order Date cannot be a future date.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Build TVP
            DataTable items = new DataTable();
            items.Columns.Add("ProductID", typeof(int));
            items.Columns.Add("Qty", typeof(int));

            foreach (DataGridViewRow row in ItemsDataGrid.Rows)
            {
                if (row.IsNewRow) continue;

                if (row.Cells["ProductID"].Value == null ||
                    row.Cells["Qty"].Value == null)
                {
                    MessageBox.Show("Please fill in all product fields.", "Validation Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int qty;
                if (!int.TryParse(row.Cells["Qty"].Value.ToString(), out qty) || qty <= 0)
                {
                    MessageBox.Show("Qty must be a valid number greater than 0.", "Validation Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (ReferenceNoTextBox.Text.Trim().Length < 3)
                {
                    MessageBox.Show("Reference No. must be at least 3 characters.", "Validation Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                items.Rows.Add(
                    Convert.ToInt32(row.Cells["ProductID"].Value),
                    qty
                );
            }

            // 3. Check stock availability
            foreach (DataGridViewRow row in ItemsDataGrid.Rows)
            {
                if (row.IsNewRow) continue;

                int productID = Convert.ToInt32(row.Cells["ProductID"].Value);
                int qty = Convert.ToInt32(row.Cells["Qty"].Value);

                string stockQuery = @"
                    SELECT ISNULL(SUM(sb.QtyRemaining), 0)
                    FROM StockBatches sb
                    JOIN GoodsReceiptItems gri ON sb.ReceiptItemsID = gri.ReceiptItemsID
                    WHERE gri.ProductID = @ProductID
                    AND sb.QtyRemaining > 0";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(stockQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProductID", productID);
                        int availableStock = (int)cmd.ExecuteScalar();

                        if (qty > availableStock)
                        {
                            string productName = row.Cells["ProductID"].FormattedValue.ToString();
                            MessageBox.Show($"Insufficient stock for {productName}. Available: {availableStock}",
                                            "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
            }

            // 4. Call SP
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_CreateSalesOrder", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CustomerID", CustomerComboBox.SelectedValue);
                    cmd.Parameters.AddWithValue("@ReferenceNo", ReferenceNoTextBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@OrderDate", OrderDatePicker.Value.Date);

                    SqlParameter tvp = cmd.Parameters.AddWithValue("@Items", items);
                    tvp.SqlDbType = SqlDbType.Structured;
                    tvp.TypeName = "SalesOrderItemsType";

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Sales Order created!", "Successful",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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

        private void ReferenceNoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != (char)Keys.Back)
                e.Handled = true;

            if (ReferenceNoTextBox.Text.Length >= 20 && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }
    }
}