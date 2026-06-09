using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FinalProject2ndYear
{
    public partial class editSalesOrderForm : Form
    {
        string connectionString = @"Data Source=DESKTOP-K0HOPRM;Initial Catalog=StockTrackDB;Integrated Security=True;TrustServerCertificate=True";
        private int salesOrderID;

        public editSalesOrderForm(int salesOrderID)
        {
            InitializeComponent();
            this.salesOrderID = salesOrderID;
        }

        private void editSalesOrderForm_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            InitializeItemsGrid();
            LoadOrderDetails();
            LoadOrderItems();
        }

        private void LoadCustomers()
        {
            string query = "SELECT CustomerID, CustomerName FROM Customers WHERE Status = 1";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                SupplierComboBox.DisplayMember = "CustomerName";
                SupplierComboBox.ValueMember = "CustomerID";
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

        private void LoadOrderDetails()
        {
            string query = @"
                SELECT so.CustomerID, so.ReferenceNo, so.OrderDate
                FROM SalesOrders so
                WHERE so.SalesOrderID = @SalesOrderID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SalesOrderID", salesOrderID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            SupplierComboBox.SelectedValue = Convert.ToInt32(reader["CustomerID"]);
                            ReferenceNoTextBox.Text = reader["ReferenceNo"].ToString();
                            ReceiptDatePicker.Value = Convert.ToDateTime(reader["OrderDate"]);
                        }
                    }
                }
            }
        }

        private void LoadOrderItems()
        {
            string query = @"
                SELECT soi.ProductID, soi.Qty
                FROM SalesOrderItems soi
                WHERE soi.SalesOrderID = @SalesOrderID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SalesOrderID", salesOrderID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int rowIndex = ItemsDataGrid.Rows.Add();
                            ItemsDataGrid.Rows[rowIndex].Cells["ProductID"].Value = Convert.ToInt32(reader["ProductID"]);
                            ItemsDataGrid.Rows[rowIndex].Cells["Qty"].Value = reader["Qty"].ToString();
                        }
                    }
                }
            }
        }

        private void AddRowButton_Click(object sender, EventArgs e)
        {
            ItemsDataGrid.Rows.Add();
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

            if (SupplierComboBox.SelectedIndex == -1)
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

                items.Rows.Add(
                    Convert.ToInt32(row.Cells["ProductID"].Value),
                    qty
                );
            }

            // 3. Check stock availability
            // For edit, we need to account for the current order's stock being restored
            foreach (DataGridViewRow row in ItemsDataGrid.Rows)
            {
                if (row.IsNewRow) continue;

                int productID = Convert.ToInt32(row.Cells["ProductID"].Value);
                int qty = Convert.ToInt32(row.Cells["Qty"].Value);

                string stockQuery = @"
                    SELECT ISNULL(SUM(sb.QtyRemaining), 0) +
                           ISNULL((
                               SELECT SUM(so.QtyUsed)
                               FROM StockOuts so
                               JOIN SalesOrderItems soi ON so.SOrderItemsID = soi.SOrderItemsID
                               JOIN StockBatches sb2 ON so.BatchID = sb2.BatchID
                               JOIN GoodsReceiptItems gri2 ON sb2.ReceiptItemsID = gri2.ReceiptItemsID
                               WHERE soi.SalesOrderID = @SalesOrderID
                               AND gri2.ProductID = @ProductID
                           ), 0)
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
                        cmd.Parameters.AddWithValue("@SalesOrderID", salesOrderID);
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
            // 4. Call SP
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_EditSalesOrder", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SalesOrderID", salesOrderID);
                    cmd.Parameters.AddWithValue("@CustomerID", SupplierComboBox.SelectedValue);
                    cmd.Parameters.AddWithValue("@ReferenceNo", ReferenceNoTextBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@OrderDate", ReceiptDatePicker.Value.Date);

                    SqlParameter tvp = cmd.Parameters.AddWithValue("@Items", items);
                    tvp.SqlDbType = SqlDbType.Structured;
                    tvp.TypeName = "SalesOrderItemsType";

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Sales Order updated!", "Successful",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("SQL Error: " + ex.Message + "\nNumber: " + ex.Number, "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("General Error: " + ex.Message, "Error",
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
    }
}