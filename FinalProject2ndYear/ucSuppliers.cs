using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Diagnostics.Eventing.Reader;

namespace FinalProject2ndYear
{
    public partial class ucSuppliers : UserControl
    {
        bool isEditing = false;
        bool isDeleting = false;
        String connectionString = @"Server=(localdb)\MSSQLLocalDB;Initial Catalog=StockTrackDB;Integrated Security=True";
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
           
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                String query = "SELECT 'SP-' + CAST(SupplierID AS VARCHAR) SupplierID,SupplierName,ContactPerson,ContactNo ,Email, " +
                    "CASE WHEN Status = 1 THEN 'Active' ELSE 'Inactive' END AS Status FROM Suppliers";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);

                DataTable dt = new DataTable();

                da.Fill(dt);

                SupplierDataGrid.DataSource = dt;
           
                this.Dock = DockStyle.Fill;

                BeginInvoke(new Action(() => {
                    SupplierDataGrid.CurrentCell = null;
                    SupplierDataGrid.ClearSelection();
                }));

            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            addSupplierForm aForm = new addSupplierForm();

            if(aForm.ShowDialog() == DialogResult.OK)
            {
                LoadSuppliers();
            }
            SupplierDataGrid.Enabled = false;
            BeginInvoke(new Action(() =>
            {
                SupplierDataGrid.CurrentCell = null;
                SupplierDataGrid.ClearSelection();
            }));

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (!isEditing)
            {
                isEditing = true;
                EditButton.Text = "Cancel";
                SupplierDataGrid.Enabled = true;
                OperationLabel.Text = "Select a Supplier to Edit*";
                OperationLabel.Visible = true;
            }
            else
            {
                isEditing = false;
                EditButton.Text = "Edit";
                SupplierDataGrid.Enabled = false;
                OperationLabel.Visible = false;
            }
            

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isEditing == true)
            {
                String rawID = SupplierDataGrid.SelectedRows[0].Cells[0].Value.ToString();
                int SupplierID = Convert.ToInt32(rawID.Replace("SP-", ""));
                editSupplierForm eForm = new editSupplierForm(SupplierID);

                if (eForm.ShowDialog() == DialogResult.OK)
                {
                    LoadSuppliers();
                }

                SupplierDataGrid.Enabled = false;
                OperationLabel.Visible = false;
                isEditing = false;
                EditButton.Text = "Edit";
                BeginInvoke(new Action(() =>
                {
                    SupplierDataGrid.CurrentCell = null;
                    SupplierDataGrid.ClearSelection();
                }));
            }
            if (isDeleting == true)
            {
                String rawID = SupplierDataGrid.SelectedRows[0].Cells[0].Value.ToString();
                int SupplierID = Convert.ToInt32(rawID.Replace("SP-", ""));

                DialogResult confirm = MessageBox.Show("Are you sure you want to delete " + rawID + "?",
                                                       "Delete Supplier",
                                                       MessageBoxButtons.YesNo);

                if (confirm == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        string query = "DELETE FROM Suppliers WHERE SupplierID = @ID";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@ID", SupplierID);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Supplier deleted!");

                            LoadSuppliers(); 
                        }
                        
                    }
                }
                isDeleting = false;
                DeleteButton.Text = "Delete";
                OperationLabel.Visible = false;
                BeginInvoke(new Action(() => {
                    SupplierDataGrid.CurrentCell = null;
                    SupplierDataGrid.ClearSelection();
                }));

            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        { 
            if (!isDeleting)
            {
                isDeleting = true;
                DeleteButton.Text = "Cancel";
                OperationLabel.Visible = true;
                OperationLabel.Text = "Select a Supplier to Delete*";
                SupplierDataGrid.Enabled = true;
            }
            else
            {
                isDeleting = false;
                DeleteButton.Text = "Delete";
                OperationLabel.Visible = false;
                SupplierDataGrid.Enabled = true;
            }
            
        }
        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                String query = @"SELECT 'SP-' + CAST(SupplierID AS VARCHAR(10)) AS SupplierID,
                         SupplierName, ContactPerson, ContactNo, Email,
                         CASE WHEN Status = 1 THEN 'Active' ELSE 'Inactive' END AS Status 
                         FROM Suppliers
                         WHERE SupplierID LIKE @Search
                         OR SupplierName LIKE @Search
                         OR ContactPerson LIKE @Search
                         OR ContactNo LIKE @Search
                         OR Email LIKE @Search";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@Search", "%" + SearchBox.Text + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                SupplierDataGrid.DataSource = dt;

                BeginInvoke(new Action(() => {
                    SupplierDataGrid.CurrentCell = null;
                    SupplierDataGrid.ClearSelection();
                }));
            }
        }
    }
    }
