using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject2ndYear
{
	public partial class editCustomerForm : Form
	{
		int CustomerID;
		int Status;
		String connectionString = @"Server=(localdb)\MSSQLLocalDB;Initial Catalog=StockTrackDatabase;Integrated Security=True";

		public editCustomerForm(int CustomerID)
		{
			InitializeComponent();
			this.CustomerID = CustomerID;
		}

		private void editCustomerForm_Load(object sender, EventArgs e)
		{
			StatusBox.Items.Add("Active");
			StatusBox.Items.Add("Inactive");

			string query = "SELECT * FROM Customers WHERE CustomerID = @ID";

			using (SqlConnection conn = new SqlConnection(connectionString))
			using (SqlCommand cmd = new SqlCommand(query, conn))
			{
				cmd.Parameters.AddWithValue("@ID", CustomerID);
				conn.Open();

				SqlDataReader reader = cmd.ExecuteReader();
				if (reader.Read())
				{
					CustomerNameTextBox.Text = reader["CustomerName"].ToString();
					ContactPersonTextBox.Text = reader["ContactPerson"].ToString();
					ContactNoTextBox.Text = reader["ContactNo"].ToString();
					EmailTextBox.Text = reader["Email"].ToString();

					if (reader["Status"].ToString() == "True")
					{
						StatusBox.Text = "Active";
					}
					else if (reader["Status"].ToString() == "False")
					{
						StatusBox.Text = "Inactive";
					}
				}
			}
		}

		private void SubmitButton_Click(object sender, EventArgs e)
		{
			this.Status = StatusBox.SelectedItem.ToString() == "Active" ? 1 : 0;

			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				String Query = @"UPDATE Customers SET CustomerName = @CustomerName,ContactPerson = @ContactPerson,ContactNo = @ContactNo,Email = @Email,Status = @Status 
                                WHERE CustomerID = @ID";

				using (SqlCommand cmd = new SqlCommand(Query, conn))
				{
					cmd.Parameters.AddWithValue("@ID", CustomerID);
					cmd.Parameters.AddWithValue("@CustomerName", CustomerNameTextBox.Text);
					cmd.Parameters.AddWithValue("@ContactPerson", ContactPersonTextBox.Text);
					cmd.Parameters.AddWithValue("@ContactNo", ContactNoTextBox.Text);
					cmd.Parameters.AddWithValue("@Email", EmailTextBox.Text);
					cmd.Parameters.AddWithValue("@Status", Status);

					conn.Open();
					cmd.ExecuteNonQuery();

					MessageBox.Show("Customer Updated!");
					this.DialogResult = DialogResult.OK;
					this.Close();
				}
			}
		}
	}
}