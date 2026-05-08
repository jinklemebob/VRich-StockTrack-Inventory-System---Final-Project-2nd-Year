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
            WelcomeLabel.Text = "Welcome, " + Username + "!";
            UserAuthentication();
            hideSubmenu();
        }
      
        private void UserAuthentication()
        {
            string connStr = ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
   

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

                if (RoleID == 2)
                {
                AdminButton.Visible = false;
                }
            }

        private void hideSubmenu()
        { 
            MasterDataSubmenu.Visible = false;
            TransactionsSubmenu.Visible = false;
            AdministratorSubmenu.Visible = false;
        }
       private void autoHideSubmenu()
        {
            if(MasterDataSubmenu.Visible == true)
            {
                MasterDataSubmenu.Visible = false;
            }
            if (TransactionsSubmenu.Visible == true)
            {
                TransactionsSubmenu.Visible = false;
            }
            if (AdministratorSubmenu.Visible == true)
            {
                AdministratorSubmenu.Visible = false;
            }
        }
        private void showSubmenus(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                autoHideSubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        private void MainDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MasterDataButton_Click(object sender, EventArgs e)
        {
            showSubmenus(MasterDataSubmenu);
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            showSubmenus(AdministratorSubmenu);
        }

        private void TransactionsButton_Click(object sender, EventArgs e)
        {
            showSubmenus(TransactionsSubmenu);
        }
        private void AdminButton_Click_1(object sender, EventArgs e)
        {
            showSubmenus(AdministratorSubmenu);
        }
        private void LogoutButton_Click(object sender, EventArgs e)
        {

            LoginPage logout = new LoginPage();
            logout.Show();
            this.Hide();

        }

       
    }
}
