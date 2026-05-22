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
	public partial class addCustomerForm : Form
	{
		String connectionString = @"Server=(localdb)\MSSQLLocalDB;Initial Catalog=StockTrackDatabase;Integrated Security=True";

		public addCustomerForm()
		{
			InitializeComponent();
		}

		private void SubmitButton_Click(object sender, EventArgs e)
		{
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				String Query = @"INSERT INTO Customers(CustomerName, ContactPerson, ContactNo, Email, Status) 
                                VALUES 
                                (@CustomerName, @ContactPerson, @ContactNo, @Email, @Status)";

				using (SqlCommand cmd = new SqlCommand(Query, conn))
				{
					cmd.Parameters.AddWithValue("@CustomerName", CustomerNameTextBox.Text);
					cmd.Parameters.AddWithValue("@ContactPerson", ContactPersonTextBox.Text);
					cmd.Parameters.AddWithValue("@ContactNo", ContactNoTextBox.Text);
					cmd.Parameters.AddWithValue("@Email", EmailTextBox.Text);
					cmd.Parameters.AddWithValue("@Status", 1);

					conn.Open();
					cmd.ExecuteNonQuery();

					MessageBox.Show("Customer Created!");
					this.DialogResult = DialogResult.OK;
					this.Close();
				}
			}
		}
	}
}