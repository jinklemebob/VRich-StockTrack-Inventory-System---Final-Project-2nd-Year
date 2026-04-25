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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }
 
        private void UserLogin()
        {
            string connStr = ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
              
                String queryLogin = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password";
                SqlCommand cmd = new SqlCommand(queryLogin, conn);

                
         
                cmd.Parameters.AddWithValue("@Username", UsernameTextBox.Text);
                cmd.Parameters.AddWithValue("@Password", PasswordTextBox.Text);

                int result = (int)cmd.ExecuteScalar();

                if (result == 0)
                {
                    MessageBox.Show("Incorrect login.");

                }
                else if (result >= 1)
                {
                    String Username = UsernameTextBox.Text;
                    String Password = PasswordTextBox.Text;
                    MessageBox.Show("Login Successful");
                    MainDashboard main = new MainDashboard(Username,Password);
                    this.Hide();
                    main.Show();
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
         UserLogin();

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }
    }
}
