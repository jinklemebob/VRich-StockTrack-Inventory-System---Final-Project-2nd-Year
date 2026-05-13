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
using UserRoleValidation;
using SubmenuVisibility;

namespace FinalProject2ndYear
{
    public partial class MainDashboard : Form
    {
        public String Username;
        public String Password;
        Submenus sb;

        public MainDashboard()
        {
            InitializeComponent();
            sb = new Submenus(MasterDataSubmenu, TransactionsSubmenu, AdministratorSubmenu);
        }
        public MainDashboard(String Username, String Password)
        {
            this.Username = Username;
            this.Password = Password;
            InitializeComponent();
            sb = new Submenus(MasterDataSubmenu, TransactionsSubmenu, AdministratorSubmenu);

            

        }
        private void MainDashboard_Load(object sender, EventArgs e)
        {
            
            ValidateUserRole vu = new ValidateUserRole(Username,Password);
            vu.getUserRole();

            if (vu.RoleID == 1)
            {
                AdminButton.Visible = true;
            }
            else if (vu.RoleID == 2)
            {
                AdminButton.Visible = false;
            }
            
            sb.hideSubmenus();
            ucDashboard ud = new ucDashboard(Username);

            MainScreenPanel.Controls.Clear();

            MainScreenPanel.Controls.Add(ud);

        }
        private void MasterDataButton_Click(object sender, EventArgs e)
        {
            sb.showSubmenus(MasterDataSubmenu);
        }

        private void TransactionsButton_Click(object sender, EventArgs e)
        {
            sb.showSubmenus(TransactionsSubmenu);
        }
        private void AdminButton_Click_1(object sender, EventArgs e)
        {
            sb.showSubmenus(AdministratorSubmenu);
        }
        private void LogoutButton_Click(object sender, EventArgs e)
        { 
            LoginPage logout = new LoginPage();
            logout.Show();
            this.Hide();
        }
        private void MainDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            ucDashboard ud = new ucDashboard(Username);

            MainScreenPanel.Controls.Clear();

            MainScreenPanel.Controls.Add(ud);
        }

        private void ProductsButton_Click(object sender, EventArgs e)
        {
            ucProducts up = new ucProducts();
            MainScreenPanel.Controls.Clear();

            MainScreenPanel.Controls.Add(up);
        }

        private void MainScreenPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SuppliersButton_Click(object sender, EventArgs e)
        {
            ucSuppliers us = new ucSuppliers();

            MainScreenPanel.Controls.Clear();
            MainScreenPanel.Controls.Add(us);
        }
    }
}
