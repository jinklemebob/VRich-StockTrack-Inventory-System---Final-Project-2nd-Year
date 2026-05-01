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
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.TransactionHsButton = new System.Windows.Forms.Button();
            this.GoodsReceiptButton = new System.Windows.Forms.Button();
            this.GoodsIssueButton = new System.Windows.Forms.Button();
            this.TransactionsButton = new System.Windows.Forms.Button();
            this.InventoryButton = new System.Windows.Forms.Button();
            this.MasterDataSubmenu = new System.Windows.Forms.Panel();
            this.SuppliersButton = new System.Windows.Forms.Button();
            this.CustomersButton = new System.Windows.Forms.Button();
            this.ProductsButton = new System.Windows.Forms.Button();
            this.MasterDataButton = new System.Windows.Forms.Button();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.SystemLogo = new System.Windows.Forms.PictureBox();
            this.MainControlPanel.SuspendLayout();
            this.LogoutSpacer.SuspendLayout();
            this.AdministratorSubmenu.SuspendLayout();
            this.TransactionsSubmenu.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.MainControlPanel.Controls.Add(this.InventoryButton);
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
            this.LogoutSpacer.Size = new System.Drawing.Size(213, 44);
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
            this.LogoutButton.Location = new System.Drawing.Point(0, -4);
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
            this.AdministratorSubmenu.Location = new System.Drawing.Point(0, 637);
            this.AdministratorSubmenu.Name = "AdministratorSubmenu";
            this.AdministratorSubmenu.Size = new System.Drawing.Size(213, 96);
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
            this.AdminButton.Location = new System.Drawing.Point(0, 589);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.AdminButton.Size = new System.Drawing.Size(213, 48);
            this.AdminButton.TabIndex = 9;
            this.AdminButton.Text = "Administrator";
            this.AdminButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdminButton.UseVisualStyleBackColor = false;
            this.AdminButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // TransactionsSubmenu
            // 
            this.TransactionsSubmenu.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TransactionsSubmenu.Controls.Add(this.panel1);
            this.TransactionsSubmenu.Controls.Add(this.TransactionHsButton);
            this.TransactionsSubmenu.Controls.Add(this.GoodsReceiptButton);
            this.TransactionsSubmenu.Controls.Add(this.GoodsIssueButton);
            this.TransactionsSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.TransactionsSubmenu.Location = new System.Drawing.Point(0, 446);
            this.TransactionsSubmenu.Name = "TransactionsSubmenu";
            this.TransactionsSubmenu.Size = new System.Drawing.Size(213, 143);
            this.TransactionsSubmenu.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 143);
            this.panel1.TabIndex = 9;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.RoyalBlue;
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.GhostWhite;
            this.button5.Location = new System.Drawing.Point(0, 96);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(213, 48);
            this.button5.TabIndex = 6;
            this.button5.Text = "Transaction History";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.RoyalBlue;
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.GhostWhite;
            this.button6.Location = new System.Drawing.Point(0, 48);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(213, 48);
            this.button6.TabIndex = 5;
            this.button6.Text = "Goods Receipt";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.RoyalBlue;
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.GhostWhite;
            this.button7.Location = new System.Drawing.Point(0, 0);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button7.Size = new System.Drawing.Size(213, 48);
            this.button7.TabIndex = 4;
            this.button7.Text = "Goods Issue";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // TransactionHsButton
            // 
            this.TransactionHsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.TransactionHsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.TransactionHsButton.FlatAppearance.BorderSize = 0;
            this.TransactionHsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(115)))));
            this.TransactionHsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransactionHsButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionHsButton.ForeColor = System.Drawing.Color.GhostWhite;
            this.TransactionHsButton.Location = new System.Drawing.Point(0, 96);
            this.TransactionHsButton.Name = "TransactionHsButton";
            this.TransactionHsButton.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.TransactionHsButton.Size = new System.Drawing.Size(213, 48);
            this.TransactionHsButton.TabIndex = 6;
            this.TransactionHsButton.Text = "Transaction History";
            this.TransactionHsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TransactionHsButton.UseVisualStyleBackColor = false;
            // 
            // GoodsReceiptButton
            // 
            this.GoodsReceiptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.GoodsReceiptButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.GoodsReceiptButton.FlatAppearance.BorderSize = 0;
            this.GoodsReceiptButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(115)))));
            this.GoodsReceiptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoodsReceiptButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoodsReceiptButton.ForeColor = System.Drawing.Color.GhostWhite;
            this.GoodsReceiptButton.Location = new System.Drawing.Point(0, 48);
            this.GoodsReceiptButton.Name = "GoodsReceiptButton";
            this.GoodsReceiptButton.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.GoodsReceiptButton.Size = new System.Drawing.Size(213, 48);
            this.GoodsReceiptButton.TabIndex = 5;
            this.GoodsReceiptButton.Text = "Goods Receipt";
            this.GoodsReceiptButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GoodsReceiptButton.UseVisualStyleBackColor = false;
            // 
            // GoodsIssueButton
            // 
            this.GoodsIssueButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.GoodsIssueButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.GoodsIssueButton.FlatAppearance.BorderSize = 0;
            this.GoodsIssueButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(115)))));
            this.GoodsIssueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoodsIssueButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoodsIssueButton.ForeColor = System.Drawing.Color.GhostWhite;
            this.GoodsIssueButton.Location = new System.Drawing.Point(0, 0);
            this.GoodsIssueButton.Name = "GoodsIssueButton";
            this.GoodsIssueButton.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.GoodsIssueButton.Size = new System.Drawing.Size(213, 48);
            this.GoodsIssueButton.TabIndex = 4;
            this.GoodsIssueButton.Text = "Goods Issue";
            this.GoodsIssueButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GoodsIssueButton.UseVisualStyleBackColor = false;
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
            this.TransactionsButton.Location = new System.Drawing.Point(0, 398);
            this.TransactionsButton.Name = "TransactionsButton";
            this.TransactionsButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.TransactionsButton.Size = new System.Drawing.Size(213, 48);
            this.TransactionsButton.TabIndex = 7;
            this.TransactionsButton.Text = "Transactions";
            this.TransactionsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TransactionsButton.UseVisualStyleBackColor = false;
            this.TransactionsButton.Click += new System.EventHandler(this.TransactionsButton_Click);
            // 
            // InventoryButton
            // 
            this.InventoryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.InventoryButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.InventoryButton.FlatAppearance.BorderSize = 0;
            this.InventoryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(90)))));
            this.InventoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InventoryButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryButton.ForeColor = System.Drawing.Color.GhostWhite;
            this.InventoryButton.Location = new System.Drawing.Point(0, 350);
            this.InventoryButton.Name = "InventoryButton";
            this.InventoryButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.InventoryButton.Size = new System.Drawing.Size(213, 48);
            this.InventoryButton.TabIndex = 5;
            this.InventoryButton.Text = "Inventory";
            this.InventoryButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InventoryButton.UseVisualStyleBackColor = false;
            // 
            // MasterDataSubmenu
            // 
            this.MasterDataSubmenu.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.MasterDataSubmenu.Controls.Add(this.SuppliersButton);
            this.MasterDataSubmenu.Controls.Add(this.CustomersButton);
            this.MasterDataSubmenu.Controls.Add(this.ProductsButton);
            this.MasterDataSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.MasterDataSubmenu.Location = new System.Drawing.Point(0, 207);
            this.MasterDataSubmenu.Name = "MasterDataSubmenu";
            this.MasterDataSubmenu.Size = new System.Drawing.Size(213, 143);
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
            this.SuppliersButton.Location = new System.Drawing.Point(0, 96);
            this.SuppliersButton.Name = "SuppliersButton";
            this.SuppliersButton.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.SuppliersButton.Size = new System.Drawing.Size(213, 48);
            this.SuppliersButton.TabIndex = 6;
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
            this.CustomersButton.Location = new System.Drawing.Point(0, 48);
            this.CustomersButton.Name = "CustomersButton";
            this.CustomersButton.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.CustomersButton.Size = new System.Drawing.Size(213, 48);
            this.CustomersButton.TabIndex = 5;
            this.CustomersButton.Text = "Customers";
            this.CustomersButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CustomersButton.UseVisualStyleBackColor = false;
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
            this.ClientSize = new System.Drawing.Size(1112, 561);
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
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Button SuppliersButton;
        private System.Windows.Forms.Button CustomersButton;
        private System.Windows.Forms.Button ProductsButton;
        private System.Windows.Forms.Button MasterDataButton;
        private System.Windows.Forms.Button InventoryButton;
        private System.Windows.Forms.Button TransactionsButton;
        private System.Windows.Forms.Button AdminButton;
        private System.Windows.Forms.Panel AdministratorSubmenu;
        private System.Windows.Forms.Button UsersButton;
        private System.Windows.Forms.Button ActivityButton;
        private System.Windows.Forms.Panel TransactionsSubmenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button TransactionHsButton;
        private System.Windows.Forms.Button GoodsReceiptButton;
        private System.Windows.Forms.Button GoodsIssueButton;
        private System.Windows.Forms.PictureBox SystemLogo;
        private System.Windows.Forms.Panel LogoutSpacer;
        private System.Windows.Forms.Button LogoutButton;
    }
}