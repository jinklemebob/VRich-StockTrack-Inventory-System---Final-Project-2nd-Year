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

        public String Username = "admin";
        public String Password = "123";
        Submenus sb;
        private Color menuColor = Color.FromArgb(0, 30, 70);
        private Color submenuColor = Color.FromArgb(0, 50, 100);
        private bool masterDataExpanded = false;
        private bool transactionsExpanded = false;
        private Button currentButton = null;
        private Image originalMasterArrow;
        private Image originalTransactionsArrow;
        private Color defaultButtonColor;

        public MainDashboard()
        {
            InitializeComponent();
            sb = new Submenus(MasterDataSubmenu, TransactionsSubmenu);
        }
        public MainDashboard(String Username, String Password)
        {
            this.Username = Username;
            this.Password = Password;
            InitializeComponent();
            sb = new Submenus(MasterDataSubmenu, TransactionsSubmenu);
        }
        private void MainDashboard_Load(object sender, EventArgs e)
        {

            originalMasterArrow = (Image)ArrowIndicM.Image.Clone();
            originalTransactionsArrow = (Image)ArrowIndicT.Image.Clone();
            defaultButtonColor = DashboardButton.BackColor;

            ValidateUserRole vu = new ValidateUserRole(Username, Password);
            vu.getUserRole();

            if (vu.RoleID == 1)
                UsersButton.Visible = true;
            else
                UsersButton.Visible = false;

            sb.hideSubmenus();

            ucDashboard ud = new ucDashboard(Username);
            MainScreenPanel.Controls.Clear();
            MainScreenPanel.Controls.Add(ud);
            ActivateButton(DashboardButton);
        }
        private void ActivateButton(Button clickedButton)
        {
            if (currentButton != null)
            {
                // Submenu buttons
                if (currentButton == ProductsButton ||
                    currentButton == SuppliersButton ||
                    currentButton == CustomersButton ||
                    currentButton == GoodsReceiptsButton ||
                    currentButton == SalesOrdersButton)
                {
                    currentButton.BackColor = submenuColor;
                }
                else
                {
                    // Main menu buttons
                    currentButton.BackColor = menuColor;
                }

                currentButton.ForeColor = Color.White;
            }

            currentButton = clickedButton;

            // Active color
            currentButton.BackColor = Color.FromArgb(0, 70, 140);
            currentButton.ForeColor = Color.White;
        }

        private void MasterDataButton_Click(object sender, EventArgs e)
        {
            if (!masterDataExpanded)
            {
                // Close Transactions
                TransactionsSubmenu.Visible = false;
                ArrowIndicT.Image = (Image)originalTransactionsArrow.Clone();
                transactionsExpanded = false;

                // Open Master Data
                MasterDataSubmenu.Visible = true;
                ArrowIndicM.Image = (Image)originalMasterArrow.Clone();
                ArrowIndicM.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);

                masterDataExpanded = true;
            }
            else
            {
                MasterDataSubmenu.Visible = false;
                ArrowIndicM.Image = (Image)originalMasterArrow.Clone();

                masterDataExpanded = false;
            }

            ArrowIndicM.Refresh();
            ArrowIndicT.Refresh();
        }

        private void TransactionsButton_Click(object sender, EventArgs e)
        {
            if (!transactionsExpanded)
            {
                // Close Master Data
                MasterDataSubmenu.Visible = false;
                ArrowIndicM.Image = (Image)originalMasterArrow.Clone();
                masterDataExpanded = false;

                // Open Transactions
                TransactionsSubmenu.Visible = true;
                ArrowIndicT.Image = (Image)originalTransactionsArrow.Clone();
                ArrowIndicT.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);

                transactionsExpanded = true;
            }
            else
            {
                TransactionsSubmenu.Visible = false;
                ArrowIndicT.Image = (Image)originalTransactionsArrow.Clone();

                transactionsExpanded = false;
            }

            ArrowIndicM.Refresh();
            ArrowIndicT.Refresh();
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
            ActivateButton(DashboardButton);
        }

        private void ProductsButton_Click(object sender, EventArgs e)
        {
            
            ucProducts up = new ucProducts();
            up.Dock = DockStyle.Fill;
            MainScreenPanel.Controls.Clear();
            MainScreenPanel.Controls.Add(up);
            ActivateButton(ProductsButton);
        }

        private void SuppliersButton_Click(object sender, EventArgs e)
        {
            ucSuppliers us = new ucSuppliers();
            us.Dock = DockStyle.Fill;
            MainScreenPanel.Controls.Clear();
            MainScreenPanel.Controls.Add(us);
            ActivateButton(SuppliersButton);
        }

        private void CustomersButton_Click(object sender, EventArgs e)
        {
            ucCustomers uc = new ucCustomers();
            uc.Dock = DockStyle.Fill;
            MainScreenPanel.Controls.Clear();
            MainScreenPanel.Controls.Add(uc);
            ActivateButton(CustomersButton);
        }

        private void GoodsReceiptsButton_Click(object sender, EventArgs e)
        {
            ucGoodsReceipts ug = new ucGoodsReceipts();
            ug.Dock = DockStyle.Fill;
            MainScreenPanel.Controls.Clear();
            MainScreenPanel.Controls.Add(ug);
            ActivateButton(GoodsReceiptsButton);

        }

        private void SalesOrdersButton_Click(object sender, EventArgs e)
        {
            ucSalesOrders us = new ucSalesOrders();
            us.Dock = DockStyle.Fill;
            MainScreenPanel.Controls.Clear();
            MainScreenPanel.Controls.Add(us);
            ActivateButton(SalesOrdersButton);
        }

        private void InventoryButton_Click(object sender, EventArgs e)
        {
            ucInventory ui = new ucInventory();
            ui.Dock = DockStyle.Fill;
            MainScreenPanel.Controls.Clear();
            MainScreenPanel.Controls.Add(ui);
            ActivateButton(InventoryButton);
        }

        private void UsersButton_Click(object sender, EventArgs e)
        {
            ucUsers ur = new ucUsers();
            ur.Dock = DockStyle.Fill;
            MainScreenPanel.Controls.Clear();
            MainScreenPanel.Controls.Add(ur);
            ActivateButton(UsersButton);
        }

        private void MainScreenPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
