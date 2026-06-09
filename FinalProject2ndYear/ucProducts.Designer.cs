namespace FinalProject2ndYear
{
    partial class ucProducts
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucProducts));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ProductLabel = new System.Windows.Forms.Label();
            this.MenuBar = new System.Windows.Forms.Panel();
            this.chkShowInactive = new System.Windows.Forms.CheckBox();
            this.SearchIcon = new System.Windows.Forms.PictureBox();
            this.EditIcon = new System.Windows.Forms.PictureBox();
            this.AddIcon = new System.Windows.Forms.PictureBox();
            this.LinkLabel = new System.Windows.Forms.Label();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.BasePanel1 = new System.Windows.Forms.Panel();
            this.TotalSuppliersCount = new System.Windows.Forms.Label();
            this.TotalSuppliersLabel = new System.Windows.Forms.Label();
            this.BorderPanel1 = new System.Windows.Forms.Panel();
            this.BorderPanel2 = new System.Windows.Forms.Panel();
            this.BasePanel2 = new System.Windows.Forms.Panel();
            this.AddedTodayText = new System.Windows.Forms.Label();
            this.ActiveLabel = new System.Windows.Forms.Label();
            this.BorderPanel3 = new System.Windows.Forms.Panel();
            this.BasePanel3 = new System.Windows.Forms.Panel();
            this.RecentAddText = new System.Windows.Forms.Label();
            this.InactiveLabel = new System.Windows.Forms.Label();
            this.StatChart = new System.Windows.Forms.Panel();
            this.ProductDataGrid = new System.Windows.Forms.DataGridView();
            this.MenuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddIcon)).BeginInit();
            this.BasePanel1.SuspendLayout();
            this.BorderPanel1.SuspendLayout();
            this.BorderPanel2.SuspendLayout();
            this.BasePanel2.SuspendLayout();
            this.BorderPanel3.SuspendLayout();
            this.BasePanel3.SuspendLayout();
            this.StatChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductLabel
            // 
            this.ProductLabel.AutoSize = true;
            this.ProductLabel.BackColor = System.Drawing.Color.Transparent;
            this.ProductLabel.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductLabel.ForeColor = System.Drawing.Color.GhostWhite;
            this.ProductLabel.Location = new System.Drawing.Point(3, 25);
            this.ProductLabel.Name = "ProductLabel";
            this.ProductLabel.Size = new System.Drawing.Size(149, 40);
            this.ProductLabel.TabIndex = 7;
            this.ProductLabel.Text = "Products";
            // 
            // MenuBar
            // 
            this.MenuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.MenuBar.Controls.Add(this.chkShowInactive);
            this.MenuBar.Controls.Add(this.SearchIcon);
            this.MenuBar.Controls.Add(this.EditIcon);
            this.MenuBar.Controls.Add(this.AddIcon);
            this.MenuBar.Controls.Add(this.LinkLabel);
            this.MenuBar.Controls.Add(this.SearchLabel);
            this.MenuBar.Controls.Add(this.SearchBox);
            this.MenuBar.Controls.Add(this.EditButton);
            this.MenuBar.Controls.Add(this.AddButton);
            this.MenuBar.Controls.Add(this.ProductLabel);
            this.MenuBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(1034, 117);
            this.MenuBar.TabIndex = 8;
            // 
            // chkShowInactive
            // 
            this.chkShowInactive.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chkShowInactive.AutoSize = true;
            this.chkShowInactive.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowInactive.ForeColor = System.Drawing.Color.GhostWhite;
            this.chkShowInactive.Location = new System.Drawing.Point(879, 59);
            this.chkShowInactive.Name = "chkShowInactive";
            this.chkShowInactive.Size = new System.Drawing.Size(119, 24);
            this.chkShowInactive.TabIndex = 19;
            this.chkShowInactive.Text = "Show Inactive";
            this.chkShowInactive.UseVisualStyleBackColor = true;
            this.chkShowInactive.CheckedChanged += new System.EventHandler(this.chkShowInactive_CheckedChanged);
            // 
            // SearchIcon
            // 
            this.SearchIcon.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SearchIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchIcon.BackgroundImage")));
            this.SearchIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchIcon.Location = new System.Drawing.Point(463, 58);
            this.SearchIcon.Name = "SearchIcon";
            this.SearchIcon.Size = new System.Drawing.Size(24, 24);
            this.SearchIcon.TabIndex = 18;
            this.SearchIcon.TabStop = false;
            // 
            // EditIcon
            // 
            this.EditIcon.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.EditIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditIcon.BackgroundImage")));
            this.EditIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditIcon.Enabled = false;
            this.EditIcon.Location = new System.Drawing.Point(792, 64);
            this.EditIcon.Name = "EditIcon";
            this.EditIcon.Size = new System.Drawing.Size(16, 15);
            this.EditIcon.TabIndex = 16;
            this.EditIcon.TabStop = false;
            // 
            // AddIcon
            // 
            this.AddIcon.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AddIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddIcon.BackgroundImage")));
            this.AddIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddIcon.Enabled = false;
            this.AddIcon.Location = new System.Drawing.Point(712, 65);
            this.AddIcon.Name = "AddIcon";
            this.AddIcon.Size = new System.Drawing.Size(14, 12);
            this.AddIcon.TabIndex = 15;
            this.AddIcon.TabStop = false;
            // 
            // LinkLabel
            // 
            this.LinkLabel.AutoSize = true;
            this.LinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.LinkLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabel.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.LinkLabel.Location = new System.Drawing.Point(6, 64);
            this.LinkLabel.Name = "LinkLabel";
            this.LinkLabel.Size = new System.Drawing.Size(184, 22);
            this.LinkLabel.TabIndex = 14;
            this.LinkLabel.Text = "Master Data > Products";
            // 
            // SearchLabel
            // 
            this.SearchLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.BackColor = System.Drawing.SystemColors.Window;
            this.SearchLabel.Enabled = false;
            this.SearchLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLabel.ForeColor = System.Drawing.Color.SlateGray;
            this.SearchLabel.Location = new System.Drawing.Point(502, 64);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(50, 13);
            this.SearchLabel.TabIndex = 13;
            this.SearchLabel.Text = "Search...";
            // 
            // SearchBox
            // 
            this.SearchBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SearchBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.SearchBox.Location = new System.Drawing.Point(495, 54);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(198, 35);
            this.SearchBox.TabIndex = 12;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // EditButton
            // 
            this.EditButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(115)))));
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.ForeColor = System.Drawing.Color.GhostWhite;
            this.EditButton.Location = new System.Drawing.Point(777, 55);
            this.EditButton.Name = "EditButton";
            this.EditButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.EditButton.Size = new System.Drawing.Size(85, 30);
            this.EditButton.TabIndex = 9;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(115)))));
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.GhostWhite;
            this.AddButton.Location = new System.Drawing.Point(695, 55);
            this.AddButton.Name = "AddButton";
            this.AddButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.AddButton.Size = new System.Drawing.Size(85, 30);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // BasePanel1
            // 
            this.BasePanel1.BackColor = System.Drawing.Color.GhostWhite;
            this.BasePanel1.Controls.Add(this.TotalSuppliersCount);
            this.BasePanel1.Controls.Add(this.TotalSuppliersLabel);
            this.BasePanel1.Location = new System.Drawing.Point(3, 3);
            this.BasePanel1.Name = "BasePanel1";
            this.BasePanel1.Size = new System.Drawing.Size(309, 58);
            this.BasePanel1.TabIndex = 12;
            // 
            // TotalSuppliersCount
            // 
            this.TotalSuppliersCount.AutoSize = true;
            this.TotalSuppliersCount.BackColor = System.Drawing.Color.Transparent;
            this.TotalSuppliersCount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalSuppliersCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.TotalSuppliersCount.Location = new System.Drawing.Point(2, 19);
            this.TotalSuppliersCount.Name = "TotalSuppliersCount";
            this.TotalSuppliersCount.Size = new System.Drawing.Size(30, 32);
            this.TotalSuppliersCount.TabIndex = 16;
            this.TotalSuppliersCount.Text = "3";
            // 
            // TotalSuppliersLabel
            // 
            this.TotalSuppliersLabel.AutoSize = true;
            this.TotalSuppliersLabel.BackColor = System.Drawing.Color.Transparent;
            this.TotalSuppliersLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalSuppliersLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.TotalSuppliersLabel.Location = new System.Drawing.Point(7, 5);
            this.TotalSuppliersLabel.Name = "TotalSuppliersLabel";
            this.TotalSuppliersLabel.Size = new System.Drawing.Size(128, 15);
            this.TotalSuppliersLabel.TabIndex = 15;
            this.TotalSuppliersLabel.Text = "TOTAL PRODUCTS";
            // 
            // BorderPanel1
            // 
            this.BorderPanel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BorderPanel1.Controls.Add(this.BasePanel1);
            this.BorderPanel1.Location = new System.Drawing.Point(32, 7);
            this.BorderPanel1.Name = "BorderPanel1";
            this.BorderPanel1.Size = new System.Drawing.Size(316, 64);
            this.BorderPanel1.TabIndex = 13;
            // 
            // BorderPanel2
            // 
            this.BorderPanel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BorderPanel2.Controls.Add(this.BasePanel2);
            this.BorderPanel2.Location = new System.Drawing.Point(354, 7);
            this.BorderPanel2.Name = "BorderPanel2";
            this.BorderPanel2.Size = new System.Drawing.Size(316, 64);
            this.BorderPanel2.TabIndex = 14;
            // 
            // BasePanel2
            // 
            this.BasePanel2.BackColor = System.Drawing.Color.GhostWhite;
            this.BasePanel2.Controls.Add(this.AddedTodayText);
            this.BasePanel2.Controls.Add(this.ActiveLabel);
            this.BasePanel2.Location = new System.Drawing.Point(3, 3);
            this.BasePanel2.Name = "BasePanel2";
            this.BasePanel2.Size = new System.Drawing.Size(309, 58);
            this.BasePanel2.TabIndex = 12;
            // 
            // AddedTodayText
            // 
            this.AddedTodayText.AutoSize = true;
            this.AddedTodayText.BackColor = System.Drawing.Color.Transparent;
            this.AddedTodayText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddedTodayText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.AddedTodayText.Location = new System.Drawing.Point(2, 19);
            this.AddedTodayText.Name = "AddedTodayText";
            this.AddedTodayText.Size = new System.Drawing.Size(30, 32);
            this.AddedTodayText.TabIndex = 16;
            this.AddedTodayText.Text = "3";
            // 
            // ActiveLabel
            // 
            this.ActiveLabel.AutoSize = true;
            this.ActiveLabel.BackColor = System.Drawing.Color.Transparent;
            this.ActiveLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActiveLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.ActiveLabel.Location = new System.Drawing.Point(7, 5);
            this.ActiveLabel.Name = "ActiveLabel";
            this.ActiveLabel.Size = new System.Drawing.Size(103, 15);
            this.ActiveLabel.TabIndex = 15;
            this.ActiveLabel.Text = "ADDED TODAY";
            // 
            // BorderPanel3
            // 
            this.BorderPanel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BorderPanel3.Controls.Add(this.BasePanel3);
            this.BorderPanel3.Location = new System.Drawing.Point(676, 7);
            this.BorderPanel3.Name = "BorderPanel3";
            this.BorderPanel3.Size = new System.Drawing.Size(316, 64);
            this.BorderPanel3.TabIndex = 14;
            // 
            // BasePanel3
            // 
            this.BasePanel3.BackColor = System.Drawing.Color.GhostWhite;
            this.BasePanel3.Controls.Add(this.RecentAddText);
            this.BasePanel3.Controls.Add(this.InactiveLabel);
            this.BasePanel3.Location = new System.Drawing.Point(3, 3);
            this.BasePanel3.Name = "BasePanel3";
            this.BasePanel3.Size = new System.Drawing.Size(309, 58);
            this.BasePanel3.TabIndex = 12;
            // 
            // RecentAddText
            // 
            this.RecentAddText.AutoSize = true;
            this.RecentAddText.BackColor = System.Drawing.Color.Transparent;
            this.RecentAddText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecentAddText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.RecentAddText.Location = new System.Drawing.Point(5, 24);
            this.RecentAddText.Name = "RecentAddText";
            this.RecentAddText.Size = new System.Drawing.Size(22, 24);
            this.RecentAddText.TabIndex = 16;
            this.RecentAddText.Text = "3";
            // 
            // InactiveLabel
            // 
            this.InactiveLabel.AutoSize = true;
            this.InactiveLabel.BackColor = System.Drawing.Color.Transparent;
            this.InactiveLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InactiveLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.InactiveLabel.Location = new System.Drawing.Point(7, 5);
            this.InactiveLabel.Name = "InactiveLabel";
            this.InactiveLabel.Size = new System.Drawing.Size(129, 15);
            this.InactiveLabel.TabIndex = 15;
            this.InactiveLabel.Text = "RECENTLY ADDED";
            // 
            // StatChart
            // 
            this.StatChart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.StatChart.Controls.Add(this.BorderPanel1);
            this.StatChart.Controls.Add(this.BorderPanel3);
            this.StatChart.Controls.Add(this.BorderPanel2);
            this.StatChart.Location = new System.Drawing.Point(0, 117);
            this.StatChart.Name = "StatChart";
            this.StatChart.Size = new System.Drawing.Size(1034, 78);
            this.StatChart.TabIndex = 15;
            // 
            // ProductDataGrid
            // 
            this.ProductDataGrid.AllowUserToAddRows = false;
            this.ProductDataGrid.AllowUserToDeleteRows = false;
            this.ProductDataGrid.AllowUserToResizeColumns = false;
            this.ProductDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ProductDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(228)))), ((int)(((byte)(243)))));
            this.ProductDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ProductDataGrid.ColumnHeadersHeight = 35;
            this.ProductDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ProductDataGrid.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.ProductDataGrid.Enabled = false;
            this.ProductDataGrid.EnableHeadersVisualStyles = false;
            this.ProductDataGrid.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ProductDataGrid.Location = new System.Drawing.Point(32, 195);
            this.ProductDataGrid.Margin = new System.Windows.Forms.Padding(0);
            this.ProductDataGrid.MultiSelect = false;
            this.ProductDataGrid.Name = "ProductDataGrid";
            this.ProductDataGrid.ReadOnly = true;
            this.ProductDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ProductDataGrid.RowHeadersVisible = false;
            this.ProductDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.ProductDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.ProductDataGrid.RowTemplate.Height = 40;
            this.ProductDataGrid.RowTemplate.ReadOnly = true;
            this.ProductDataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductDataGrid.Size = new System.Drawing.Size(960, 486);
            this.ProductDataGrid.StandardTab = true;
            this.ProductDataGrid.TabIndex = 16;
            this.ProductDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductDataGrid_CellClick);
            this.ProductDataGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ProductDataGrid_CellFormatting);
            // 
            // ucProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(228)))), ((int)(((byte)(243)))));
            this.Controls.Add(this.ProductDataGrid);
            this.Controls.Add(this.StatChart);
            this.Controls.Add(this.MenuBar);
            this.Name = "ucProducts";
            this.Size = new System.Drawing.Size(1034, 681);
            this.Load += new System.EventHandler(this.ucSuppliers_Load);
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddIcon)).EndInit();
            this.BasePanel1.ResumeLayout(false);
            this.BasePanel1.PerformLayout();
            this.BorderPanel1.ResumeLayout(false);
            this.BorderPanel2.ResumeLayout(false);
            this.BasePanel2.ResumeLayout(false);
            this.BasePanel2.PerformLayout();
            this.BorderPanel3.ResumeLayout(false);
            this.BasePanel3.ResumeLayout(false);
            this.BasePanel3.PerformLayout();
            this.StatChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label ProductLabel;
        private System.Windows.Forms.Panel MenuBar;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.Label LinkLabel;
        private System.Windows.Forms.Panel BasePanel1;
        private System.Windows.Forms.Panel BorderPanel1;
        private System.Windows.Forms.Label TotalSuppliersLabel;
        private System.Windows.Forms.Label TotalSuppliersCount;
        private System.Windows.Forms.Panel BorderPanel2;
        private System.Windows.Forms.Panel BasePanel2;
        private System.Windows.Forms.Label AddedTodayText;
        private System.Windows.Forms.Label ActiveLabel;
        private System.Windows.Forms.Panel BorderPanel3;
        private System.Windows.Forms.Panel BasePanel3;
        private System.Windows.Forms.Label RecentAddText;
        private System.Windows.Forms.Label InactiveLabel;
        private System.Windows.Forms.Panel StatChart;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.PictureBox AddIcon;
        private System.Windows.Forms.PictureBox EditIcon;
        private System.Windows.Forms.DataGridView ProductDataGrid;
        private System.Windows.Forms.PictureBox SearchIcon;
        private System.Windows.Forms.CheckBox chkShowInactive;
    }
}
