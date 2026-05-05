namespace FinalProject2ndYear
{
    partial class MainDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDashboard));
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.MainControlPanel = new System.Windows.Forms.Panel();
            this.LogoutSpacer = new System.Windows.Forms.Panel();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.AdministratorSubmenu = new System.Windows.Forms.Panel();
            this.UsersButton = new System.Windows.Forms.Button();
            this.ActivityButton = new System.Windows.Forms.Button();
            this.AdminButton = new System.Windows.Forms.Button();
            this.TransactionsSubmenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GoodsReceiptsButton = new System.Windows.Forms.Button();
            this.SalesOrdersButton = new System.Windows.Forms.Button();
            this.TransactionsButton = new System.Windows.Forms.Button();
            this.StocksButton = new System.Windows.Forms.Button();
            this.MasterDataSubmenu = new System.Windows.Forms.Panel();
            this.SuppliersButton = new System.Windows.Forms.Button();
            this.CustomersButton = new System.Windows.Forms.Button();
            this.CategoriesButton = new System.Windows.Forms.Button();
            this.ProductsButton = new System.Windows.Forms.Button();
            this.MasterDataButton = new System.Windows.Forms.Button();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.SystemLogo = new System.Windows.Forms.PictureBox();
            this.MainControlPanel.SuspendLayout();
            this.LogoutSpacer.SuspendLayout();
            this.AdministratorSubmenu.SuspendLayout();
            this.TransactionsSubmenu.SuspendLayout();
            this.MasterDataSubmenu.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SystemLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.WelcomeLabel.Location = new System.Drawing.Point(279, 100);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(108, 40);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "label1";
            // 
            // MainControlPanel
            // 
            this.MainControlPanel.AutoScroll = true;
            this.MainControlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.MainControlPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MainControlPanel.Controls.Add(this.LogoutSpacer);
            this.MainControlPanel.Controls.Add(this.AdministratorSubmenu);
            this.MainControlPanel.Controls.Add(this.AdminButton);
            this.MainControlPanel.Controls.Add(this.TransactionsSubmenu);
            this.MainControlPanel.Controls.Add(this.TransactionsButton);
            this.MainControlPanel.Controls.Add(this.StocksButton);
            this.MainControlPanel.Controls.Add(this.MasterDataSubmenu);
            this.MainControlPanel.Controls.Add(this.MasterDataButton);
            this.MainControlPanel.Controls.Add(this.LogoPanel);
            this.MainControlPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MainControlPanel.ForeColor = System.Drawing.Color.DarkBlue;
            this.MainControlPanel.Location = new System.Drawing.Point(0, 0);
            this.MainControlPanel.Name = "MainControlPanel";
            this.MainControlPanel.Size = new System.Drawing.Size(230, 561);
            this.MainControlPanel.TabIndex = 3;
            // 
            // LogoutSpacer
            // 
            this.LogoutSpacer.Controls.Add(this.LogoutButton);
            this.LogoutSpacer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LogoutSpacer.Location = new System.Drawing.Point(0, 733);
            this.LogoutSpacer.Name = "LogoutSpacer";
            this.LogoutSpacer.Size = new System.Drawing.Size(213, 143);
            this.LogoutSpacer.TabIndex = 11;
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.LogoutButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LogoutButton.FlatAppearance.BorderSize = 0;
            this.LogoutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(90)))));
            this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButton.ForeColor = System.Drawing.Color.GhostWhite;
            this.LogoutButton.Location = new System.Drawing.Point(0, 95);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.LogoutButton.Size = new System.Drawing.Size(213, 48);
            this.LogoutButton.TabIndex = 10;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogoutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // AdministratorSubmenu
            // 
            this.AdministratorSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.AdministratorSubmenu.Controls.Add(this.UsersButton);
            this.AdministratorSubmenu.Controls.Add(this.ActivityButton);
            this.AdministratorSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.AdministratorSubmenu.ForeColor = System.Drawing.Color.Transparent;
            this.AdministratorSubmenu.Location = new System.Drawing.Point(0, 638);
            this.AdministratorSubmenu.Name = "AdministratorSubmenu";
            this.AdministratorSubmenu.Size = new System.Drawing.Size(213, 95);
            this.AdministratorSubmenu.TabIndex = 10;
            // 
            // UsersButton
            // 
            this.UsersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.UsersButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.UsersButton.FlatAppearance.BorderSize = 0;
            this.UsersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(115)))));
            this.UsersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UsersButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersButton.ForeColor = System.Drawing.Color.GhostWhite;
            this.UsersButton.Location = new System.Drawing.Point(0, 48);
            this.UsersButton.Name = "UsersButton";
            this.UsersButton.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.UsersButton.Size = new System.Drawing.Size(213, 48);
            this.UsersButton.TabIndex = 5;
            this.UsersButton.Text = "Users";
            this.UsersButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UsersButton.UseVisualStyleBackColor = false;
            // 
            // ActivityButton
            // 
            this.ActivityButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.ActivityButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ActivityButton.FlatAppearance.BorderSize = 0;
            this.ActivityButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(115)))));
            this.ActivityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ActivityButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivityButton.ForeColor = System.Drawing.Color.GhostWhite;
            this.ActivityButton.Location = new System.Drawing.Point(0, 0);
            this.ActivityButton.Name = "ActivityButton";
            this.ActivityButton.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.ActivityButton.Size = new System.Drawing.Size(213, 48);
            this.ActivityButton.TabIndex = 4;
            this.ActivityButton.Text = "Activity Logs";
            this.ActivityButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ActivityButton.UseVisualStyleBackColor = false;
            // 
            // AdminButton
            // 
            this.AdminButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.AdminButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AdminButton.FlatAppearance.BorderSize = 0;
            this.AdminButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(90)))));
            this.AdminButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminButton.ForeColor = System.Drawing.Color.GhostWhite;
            this.AdminButton.Location = new System.Drawing.Point(0, 590);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.AdminButton.Size = new System.Drawing.Size(213, 48);
            this.AdminButton.TabIndex = 9;
            this.AdminButton.Text = "Administrator";
            this.AdminButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdminButton.UseVisualStyleBackColor = false;
            this.AdminButton.Click += new System.EventHandler(this.AdminButton_Click);
            // 
            // TransactionsSubmenu
            // 
            this.TransactionsSubmenu.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TransactionsSubmenu.Controls.Add(this.panel1);
            this.TransactionsSubmenu.Controls.Add(this.GoodsReceiptsButton);
            this.TransactionsSubmenu.Controls.Add(this.SalesOrdersButton);
            this.TransactionsSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.TransactionsSubmenu.Location = new System.Drawing.Point(0, 494);
            this.TransactionsSubmenu.Name = "TransactionsSubmenu";
            this.TransactionsSubmenu.Size = new System.Drawing.Size(213, 96);
            this.TransactionsSubmenu.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 143);
            this.panel1.TabIndex = 9;
            // 
            // GoodsReceiptsButton
            // 
            this.GoodsReceiptsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.GoodsReceiptsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.GoodsReceiptsButton.FlatAppearance.BorderSize = 0;
            this.GoodsReceiptsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(115)))));
            this.GoodsReceiptsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoodsReceiptsButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoodsReceiptsButton.ForeColor = System.Drawing.Color.GhostWhite;
            this.GoodsReceiptsButton.Location = new System.Drawing.Point(0, 48);
            this.GoodsReceiptsButton.Name = "GoodsReceiptsButton";
            this.GoodsReceiptsButton.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.GoodsReceiptsButton.Size = new System.Drawing.Size(213, 48);
            this.GoodsReceiptsButton.TabIndex = 5;
            this.GoodsReceiptsButton.Text = "Goods Receipts";
            this.GoodsReceiptsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GoodsReceiptsButton.UseVisualStyleBackColor = false;
            // 
            // SalesOrdersButton
            // 
            this.SalesOrdersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.SalesOrdersButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SalesOrdersButton.FlatAppearance.BorderSize = 0;
            this.SalesOrdersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(115)))));
            this.SalesOrdersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalesOrdersButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesOrdersButton.ForeColor = System.Drawing.Color.GhostWhite;
            this.SalesOrdersButton.Location = new System.Drawing.Point(0, 0);
            this.SalesOrdersButton.Name = "SalesOrdersButton";
            this.SalesOrdersButton.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.SalesOrdersButton.Size = new System.Drawing.Size(213, 48);
            this.SalesOrdersButton.TabIndex = 4;
            this.SalesOrdersButton.Text = "Sales Orders";
            this.SalesOrdersButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SalesOrdersButton.UseVisualStyleBackColor = false;
            // 
            // TransactionsButton
            // 
            this.TransactionsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.TransactionsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.TransactionsButton.FlatAppearance.BorderSize = 0;
            this.TransactionsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(90)))));
            this.TransactionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransactionsButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionsButton.ForeColor = System.Drawing.Color.GhostWhite;
            this.TransactionsButton.Location = new System.Drawing.Point(0, 446);
            this.TransactionsButton.Name = "TransactionsButton";
            this.TransactionsButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.TransactionsButton.Size = new System.Drawing.Size(213, 48);
            this.TransactionsButton.TabIndex = 7;
            this.TransactionsButton.Text = "Transactions";
            this.TransactionsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TransactionsButton.UseVisualStyleBackColor = false;
            this.TransactionsButton.Click += new System.EventHandler(this.TransactionsButton_Click);
            // 
            // StocksButton
            // 
            this.StocksButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.StocksButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.StocksButton.FlatAppearance.BorderSize = 0;
            this.StocksButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(90)))));
            this.StocksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StocksButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StocksButton.ForeColor = System.Drawing.Color.GhostWhite;
            this.StocksButton.Location = new System.Drawing.Point(0, 398);
            this.StocksButton.Name = "StocksButton";
            this.StocksButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.StocksButton.Size = new System.Drawing.Size(213, 48);
            this.StocksButton.TabIndex = 5;
            this.StocksButton.Text = "Stocks";
            this.StocksButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StocksButton.UseVisualStyleBackColor = false;
            // 
            // MasterDataSubmenu
            // 
            this.MasterDataSubmenu.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.MasterDataSubmenu.Controls.Add(this.SuppliersButton);
            this.MasterDataSubmenu.Controls.Add(this.CustomersButton);
            this.MasterDataSubmenu.Controls.Add(this.CategoriesButton);
            this.MasterDataSubmenu.Controls.Add(this.ProductsButton);
            this.MasterDataSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.MasterDataSubmenu.Location = new System.Drawing.Point(0, 207);
            this.MasterDataSubmenu.Name = "MasterDataSubmenu";
            this.MasterDataSubmenu.Size = new System.Drawing.Size(213, 191);
            this.MasterDataSubmenu.TabIndex = 4;
            // 
            // SuppliersButton
            // 
            this.SuppliersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.SuppliersButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SuppliersButton.FlatAppearance.BorderSize = 0;
            this.SuppliersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(115)))));
            this.SuppliersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SuppliersButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuppliersButton.ForeColor = System.Drawing.Color.GhostWhite;
            this.SuppliersButton.Location = new System.Drawing.Point(0, 144);
            this.SuppliersButton.Name = "SuppliersButton";
            this.SuppliersButton.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.SuppliersButton.Size = new System.Drawing.Size(213, 48);
            this.SuppliersButton.TabIndex = 7;
            this.SuppliersButton.Text = "Suppliers";
            this.SuppliersButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SuppliersButton.UseVisualStyleBackColor = false;
            // 
            // CustomersButton
            // 
            this.CustomersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.CustomersButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CustomersButton.FlatAppearance.BorderSize = 0;
            this.CustomersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(115)))));
            this.CustomersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomersButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomersButton.ForeColor = System.Drawing.Color.GhostWhite;
            this.CustomersButton.Location = new System.Drawing.Point(0, 96);
            this.CustomersButton.Name = "CustomersButton";
            this.CustomersButton.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.CustomersButton.Size = new System.Drawing.Size(213, 48);
            this.CustomersButton.TabIndex = 6;
            this.CustomersButton.Text = "Customers";
            this.CustomersButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CustomersButton.UseVisualStyleBackColor = false;
            // 
            // CategoriesButton
            // 
            this.CategoriesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.CategoriesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CategoriesButton.FlatAppearance.BorderSize = 0;
            this.CategoriesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(115)))));
            this.CategoriesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CategoriesButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoriesButton.ForeColor = System.Drawing.Color.GhostWhite;
            this.CategoriesButton.Location = new System.Drawing.Point(0, 48);
            this.CategoriesButton.Name = "CategoriesButton";
            this.CategoriesButton.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.CategoriesButton.Size = new System.Drawing.Size(213, 48);
            this.CategoriesButton.TabIndex = 5;
            this.CategoriesButton.Text = "Categories";
            this.CategoriesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CategoriesButton.UseVisualStyleBackColor = false;
            // 
            // ProductsButton
            // 
            this.ProductsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.ProductsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProductsButton.FlatAppearance.BorderSize = 0;
            this.ProductsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(115)))));
            this.ProductsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductsButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsButton.ForeColor = System.Drawing.Color.GhostWhite;
            this.ProductsButton.Location = new System.Drawing.Point(0, 0);
            this.ProductsButton.Name = "ProductsButton";
            this.ProductsButton.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.ProductsButton.Size = new System.Drawing.Size(213, 48);
            this.ProductsButton.TabIndex = 4;
            this.ProductsButton.Text = "Products";
            this.ProductsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProductsButton.UseVisualStyleBackColor = false;
            // 
            // MasterDataButton
            // 
            this.MasterDataButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.MasterDataButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.MasterDataButton.FlatAppearance.BorderSize = 0;
            this.MasterDataButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(90)))));
            this.MasterDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MasterDataButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MasterDataButton.ForeColor = System.Drawing.Color.GhostWhite;
            this.MasterDataButton.Location = new System.Drawing.Point(0, 159);
            this.MasterDataButton.Name = "MasterDataButton";
            this.MasterDataButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.MasterDataButton.Size = new System.Drawing.Size(213, 48);
            this.MasterDataButton.TabIndex = 4;
            this.MasterDataButton.Text = "Master Data";
            this.MasterDataButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MasterDataButton.UseVisualStyleBackColor = false;
            this.MasterDataButton.Click += new System.EventHandler(this.MasterDataButton_Click);
            // 
            // LogoPanel
            // 
            this.LogoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.LogoPanel.Controls.Add(this.SystemLogo);
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(213, 159);
            this.LogoPanel.TabIndex = 4;
            // 
            // SystemLogo
            // 
            this.SystemLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SystemLogo.Image = ((System.Drawing.Image)(resources.GetObject("SystemLogo.Image")));
            this.SystemLogo.Location = new System.Drawing.Point(-40, -4);
            this.SystemLogo.Name = "SystemLogo";
            this.SystemLogo.Size = new System.Drawing.Size(301, 178);
            this.SystemLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SystemLogo.TabIndex = 4;
            this.SystemLogo.TabStop = false;
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1028, 561);
            this.Controls.Add(this.MainControlPanel);
            this.Controls.Add(this.WelcomeLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VRich StockTrack";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainDashboard_FormClosing);
            this.Load += new System.EventHandler(this.MainDashboard_Load);
            this.MainControlPanel.ResumeLayout(false);
            this.LogoutSpacer.ResumeLayout(false);
            this.AdministratorSubmenu.ResumeLayout(false);
            this.TransactionsSubmenu.ResumeLayout(false);
            this.MasterDataSubmenu.ResumeLayout(false);
            this.LogoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SystemLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Panel MainControlPanel;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.Panel MasterDataSubmenu;
        private System.Windows.Forms.Button CustomersButton;
        private System.Windows.Forms.Button CategoriesButton;
        private System.Windows.Forms.Button ProductsButton;
        private System.Windows.Forms.Button MasterDataButton;
        private System.Windows.Forms.Button StocksButton;
        private System.Windows.Forms.Button TransactionsButton;
        private System.Windows.Forms.Button AdminButton;
        private System.Windows.Forms.Panel AdministratorSubmenu;
        private System.Windows.Forms.Button UsersButton;
        private System.Windows.Forms.Button ActivityButton;
        private System.Windows.Forms.Panel TransactionsSubmenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button GoodsReceiptsButton;
        private System.Windows.Forms.Button SalesOrdersButton;
        private System.Windows.Forms.PictureBox SystemLogo;
        private System.Windows.Forms.Panel LogoutSpacer;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button SuppliersButton;
    }
}