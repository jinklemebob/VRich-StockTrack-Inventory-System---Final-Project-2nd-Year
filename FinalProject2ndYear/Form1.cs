using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject2ndYear
{
    public partial class Form1 : Form
    {
       
    public Form1()
        {
          
            InitializeComponent();
        }

    private void UserLogin()
        {
            string connStr = ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                String queryLogin = "SELECT COUNT(*) FROM Admin_Accounts WHERE username = @username AND password = @password";
                SqlCommand cmd = new SqlCommand(queryLogin, conn);

                cmd.Parameters.AddWithValue("@username", UsernameTextBox.Text);
                cmd.Parameters.AddWithValue("@password", PasswordTextBox.Text);

                int result = (int)cmd.ExecuteScalar();

                if (result == 0)
                {
                    MessageBox.Show("Incorrect Login");

                }
                else if (result >= 1)
                {
                    MessageBox.Show("Login Successful!");
                    LoginPanel.Visible = false;
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
         UserLogin();

        }
    }
}
