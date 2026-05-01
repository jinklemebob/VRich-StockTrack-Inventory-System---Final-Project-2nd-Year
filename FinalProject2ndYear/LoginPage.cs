using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalProject2ndYear
{
    public partial class LoginPage : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
         (
             int nLeftRect,     // x-coordinate of upper-left corner
             int nTopRect,      // y-coordinate of upper-left corner
             int nRightRect,    // x-coordinate of lower-right corner
             int nBottomRect,   // y-coordinate of lower-right corner
             int nWidthEllipse, // width of ellipse
             int nHeightEllipse // height of ellipse{Dll
            );
        public LoginPage()
        {
            InitializeComponent();
            //Round Corners for Login Page
            LoginButton.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, LoginButton.Width, LoginButton.Height, 15, 15));
            UsernamePanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, UsernamePanel.Width, UsernamePanel.Height, 15, 15));
            PasswordPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, PasswordPanel.Width, PasswordPanel.Height, 15, 15));
        }
 
        private void UserLogin()
        {
            string connStr = ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            
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


        

        private void button2_Click(object sender, EventArgs e)
        {
            
            UserLogin();

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void LoginLabel_Click(object sender, EventArgs e)
        {

        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UsernameLbl_Click(object sender, EventArgs e)
        {

        }

        private void PasswordLbl_Click(object sender, EventArgs e)
        {

        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginPanel_Paint(object sender, PaintEventArgs e)
        {
            LoginPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, LoginPanel.Width, LoginPanel.Height, 20, 20));
        }
    }
}
