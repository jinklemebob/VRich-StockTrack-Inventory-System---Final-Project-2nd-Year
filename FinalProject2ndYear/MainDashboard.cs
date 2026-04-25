using System;
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
    public partial class MainDashboard : Form
    {
        public String Username;
        public String Password;

        public MainDashboard(String Username, String Password)
        {
           
            this.Username = Username;
            this.Password = Password;
            InitializeComponent();
        }

       
        private void MainDashboard_Load(object sender, EventArgs e)
        {
            label1.Text = "Welcome, " + Username + "!";
            UserAuthentication();
        }
        private void UserAuthentication()
        {
            LoginPage lg = new LoginPage();
            string connStr = ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {

                conn.Open();
                string userQuery = "SELECT UserID FROM Users WHERE Username = @Username AND Password = @Password";
                SqlCommand cmd = new SqlCommand(userQuery, conn);

                cmd.Parameters.AddWithValue("@Username",Username);
                cmd.Parameters.AddWithValue("@Password",Password);

                object result = cmd.ExecuteScalar();
                int UserID = Convert.ToInt32(result);

                string authQuery = "SELECT RoleID FROM Users WHERE UserID = @UserID";
                SqlCommand cmd2 = new SqlCommand(authQuery, conn);

                cmd2.Parameters.AddWithValue("@UserID",UserID);

                object result2 = cmd2.ExecuteScalar();
                int RoleID = Convert.ToInt32(result2);

                if (RoleID == 1)
                {
                    
                }
            }
          
        }

        private void MainDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

     
    }
}
