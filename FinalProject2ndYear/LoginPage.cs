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
using LoginFunction;

namespace FinalProject2ndYear
{
    public partial class LoginPage : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
         (
             int nLeftRect,    
             int nTopRect,     
             int nRightRect,   
             int nBottomRect,   
             int nWidthEllipse, 
             int nHeightEllipse 
            );
        public LoginPage()
        {
            InitializeComponent();
    
            LoginButton.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, LoginButton.Width, LoginButton.Height, 15, 15));
            UsernamePanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, UsernamePanel.Width, UsernamePanel.Height, 15, 15));
            PasswordPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, PasswordPanel.Width, PasswordPanel.Height, 15, 15));
        }
       
        private void LoginButton_Click(object sender, EventArgs e)
        {
            UserAuthentication user = new UserAuthentication(UsernameTextBox.Text, PasswordTextBox.Text);
            user.LoginMethod();

            if (user.isAuth == true)
            {
                this.Hide();
            }

        }

        private void LoginPanel_Paint(object sender, PaintEventArgs e)
        {
            LoginPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, LoginPanel.Width, LoginPanel.Height, 20, 20));
        }

        private void UsernameTextBox_Click(object sender, EventArgs e)
        {
            UsernameTextBox.SelectAll();
          
        }

        private void PasswordTextBox_Click(object sender, EventArgs e)
        {
            PasswordTextBox.SelectAll();
        }

        private void UsernameTextBox_TextChanged_1(object sender, EventArgs e)
        {
            
            if (String.IsNullOrWhiteSpace(UsernameTextBox.Text))
            {
                UsernameTextBox.Text = "Username...";
            }
        }

        private void PasswordTextBox_TextChanged_1(object sender, EventArgs e)
        {
            PasswordTextBox.UseSystemPasswordChar = true;
            if (String.IsNullOrWhiteSpace(PasswordTextBox.Text))
            {
                PasswordTextBox.Text = "Password...";
                PasswordTextBox.UseSystemPasswordChar = false; 
            }
        }

        private void LoginPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
    }

