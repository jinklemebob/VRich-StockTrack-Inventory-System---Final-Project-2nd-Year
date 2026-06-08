namespace FinalProject2ndYear
{
    partial class ucSalesOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSalesOrders));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ucLabel = new System.Windows.Forms.Label();
            this.MenuBar = new System.Windows.Forms.Panel();
            this.SearchIcon = new System.Windows.Forms.PictureBox();
            this.EditIcon = new System.Windows.Forms.PictureBox();
            this.AddIcon = new System.Windows.Forms.PictureBox();
            this.LinkLabel = new System.Windows.Forms.Label();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.BasePanel1 = new System.Windows.Forms.Panel();
            this.TotalRCount = new System.Windows.Forms.Label();
            this.TotalReceiptsLabel = new System.Windows.Forms.Label();
            this.BorderPanel1 = new System.Windows.Forms.Panel();
            this.BorderPanel2 = new System.Windows.Forms.Panel();
            this.BasePanel2 = new System.Windows.Forms.Panel();
            this.TodayValue = new System.Windows.Forms.Label();
            this.TotalReceiptsToday = new System.Windows.Forms.Label();
            this.BorderPanel3 = new System.Windows.Forms.Panel();
            this.BasePanel3 = new System.Windows.Forms.Panel();
            this.MonthCount = new System.Windows.Forms.Label();
            this.MonthReceiptsLabel = new System.Windows.Forms.Label();
            this.StatChart = new System.Windows.Forms.Panel();
            this.ReceiptsDataGrid = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.ReceiptsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ucLabel
            // 
            this.ucLabel.AutoSize = true;
            this.ucLabel.BackColor = System.Drawing.Color.Transparent;
            this.ucLabel.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucLabel.ForeColor = System.Drawing.Color.GhostWhite;
            this.ucLabel.Location = new System.Drawing.Point(3, 25);
            this.ucLabel.Name = "ucLabel";
            this.ucLabel.Size = new System.Drawing.Size(203, 40);
            this.ucLabel.TabIndex = 7;
            this.ucLabel.Text = "Sales Orders";
            // 
            // MenuBar
            // 
            this.MenuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.MenuBar.Controls.Add(this.SearchIcon);
            this.MenuBar.Controls.Add(this.EditIcon);
            this.MenuBar.Controls.Add(this.AddIcon);
            this.MenuBar.Controls.Add(this.LinkLabel);
            this.MenuBar.Controls.Add(this.SearchLabel);
            this.MenuBar.Controls.Add(this.SearchBox);
            this.MenuBar.Controls.Add(this.EditButton);
            this.MenuBar.Controls.Add(this.AddButton);
            this.MenuBar.Controls.Add(this.ucLabel);
            this.MenuBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(1034, 117);
            this.MenuBar.TabIndex = 8;
            // 
            // SearchIcon
            // 
            this.SearchIcon.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SearchIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchIcon.BackgroundImage")));
            this.SearchIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchIcon.Location = new System.Drawing.Point(549, 58);
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
            this.EditIcon.Location = new System.Drawing.Point(888, 64);
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
            this.AddIcon.Location = new System.Drawing.Point(799, 65);
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
            this.LinkLabel.Size = new System.Drawing.Size(216, 22);
            this.LinkLabel.TabIndex = 14;
            this.LinkLabel.Text = "Transactions > Sales Orders";
            // 
            // SearchLabel
            // 
            this.SearchLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.BackColor = System.Drawing.SystemColors.Window;
            this.SearchLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLabel.ForeColor = System.Drawing.Color.SlateGray;
            this.SearchLabel.Location = new System.Drawing.Point(588, 64);
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
            this.SearchBox.Location = new System.Drawing.Point(581, 54);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(198, 35);
            this.SearchBox.TabIndex = 12;
            this.SearchBox.Click += new System.EventHandler(this.SearchBox_Click);
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            this.SearchBox.MouseLeave += new System.EventHandler(this.SearchBox_MouseLeave);
            // 
            // EditButton
            // 
            this.EditButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(115)))));
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.ForeColor = System.Drawing.Color.GhostWhite;
            this.EditButton.Location = new System.Drawing.Point(873, 55);
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
            this.AddButton.Location = new System.Drawing.Point(782, 55);
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
            this.BasePanel1.Controls.Add(this.TotalRCount);
            this.BasePanel1.Controls.Add(this.TotalReceiptsLabel);
            this.BasePanel1.Location = new System.Drawing.Point(3, 3);
            this.BasePanel1.Name = "BasePanel1";
            this.BasePanel1.Size = new System.Drawing.Size(309, 58);
            this.BasePanel1.TabIndex = 12;
            // 
            // TotalRCount
            // 
            this.TotalRCount.AutoSize = true;
            this.TotalRCount.BackColor = System.Drawing.Color.Transparent;
            this.TotalRCount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalRCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.TotalRCount.Location = new System.Drawing.Point(2, 19);
            this.TotalRCount.Name = "TotalRCount";
            this.TotalRCount.Size = new System.Drawing.Size(30, 32);
            this.TotalRCount.TabIndex = 16;
            this.TotalRCount.Text = "3";
            // 
            // TotalReceiptsLabel
            // 
            this.TotalReceiptsLabel.AutoSize = true;
            this.TotalReceiptsLabel.BackColor = System.Drawing.Color.Transparent;
            this.TotalReceiptsLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalReceiptsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.TotalReceiptsLabel.Location = new System.Drawing.Point(7, 5);
            this.TotalReceiptsLabel.Name = "TotalReceiptsLabel";
            this.TotalReceiptsLabel.Size = new System.Drawing.Size(109, 15);
            this.TotalReceiptsLabel.TabIndex = 15;
            this.TotalReceiptsLabel.Text = "TOTAL ORDERS";
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
            this.BasePanel2.Controls.Add(this.TodayValue);
            this.BasePanel2.Controls.Add(this.TotalReceiptsToday);
            this.BasePanel2.Location = new System.Drawing.Point(3, 3);
            this.BasePanel2.Name = "BasePanel2";
            this.BasePanel2.Size = new System.Drawing.Size(309, 58);
            this.BasePanel2.TabIndex = 12;
            // 
            // TodayValue
            // 
            this.TodayValue.AutoSize = true;
            this.TodayValue.BackColor = System.Drawing.Color.Transparent;
            this.TodayValue.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TodayValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.TodayValue.Location = new System.Drawing.Point(2, 19);
            this.TodayValue.Name = "TodayValue";
            this.TodayValue.Size = new System.Drawing.Size(30, 32);
            this.TodayValue.TabIndex = 16;
            this.TodayValue.Text = "3";
            // 
            // TotalReceiptsToday
            // 
            this.TotalReceiptsToday.AutoSize = true;
            this.TotalReceiptsToday.BackColor = System.Drawing.Color.Transparent;
            this.TotalReceiptsToday.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalReceiptsToday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.TotalReceiptsToday.Location = new System.Drawing.Point(7, 5);
            this.TotalReceiptsToday.Name = "TotalReceiptsToday";
            this.TotalReceiptsToday.Size = new System.Drawing.Size(123, 15);
            this.TotalReceiptsToday.TabIndex = 15;
            this.TotalReceiptsToday.Text = "TODAY\'S ORDERS";
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
            this.BasePanel3.Controls.Add(this.MonthCount);
            this.BasePanel3.Controls.Add(this.MonthReceiptsLabel);
            this.BasePanel3.Location = new System.Drawing.Point(3, 3);
            this.BasePanel3.Name = "BasePanel3";
            this.BasePanel3.Size = new System.Drawing.Size(309, 58);
            this.BasePanel3.TabIndex = 12;
            // 
            // MonthCount
            // 
            this.MonthCount.AutoSize = true;
            this.MonthCount.BackColor = System.Drawing.Color.Transparent;
            this.MonthCount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.MonthCount.Location = new System.Drawing.Point(2, 19);
            this.MonthCount.Name = "MonthCount";
            this.MonthCount.Size = new System.Drawing.Size(30, 32);
            this.MonthCount.TabIndex = 16;
            this.MonthCount.Text = "3";
            // 
            // MonthReceiptsLabel
            // 
            this.MonthReceiptsLabel.AutoSize = true;
            this.MonthReceiptsLabel.BackColor = System.Drawing.Color.Transparent;
            this.MonthReceiptsLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthReceiptsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.MonthReceiptsLabel.Location = new System.Drawing.Point(7, 5);
            this.MonthReceiptsLabel.Name = "MonthReceiptsLabel";
            this.MonthReceiptsLabel.Size = new System.Drawing.Size(161, 15);
            this.MonthReceiptsLabel.TabIndex = 15;
            this.MonthReceiptsLabel.Text = "THIS MONTH\'S ORDERS";
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
            // ReceiptsDataGrid
            // 
            this.ReceiptsDataGrid.AllowUserToAddRows = false;
            this.ReceiptsDataGrid.AllowUserToDeleteRows = false;
            this.ReceiptsDataGrid.AllowUserToResizeColumns = false;
            this.ReceiptsDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceiptsDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ReceiptsDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReceiptsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ReceiptsDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(228)))), ((int)(((byte)(243)))));
            this.ReceiptsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReceiptsDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ReceiptsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ReceiptsDataGrid.ColumnHeadersHeight = 35;
            this.ReceiptsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ReceiptsDataGrid.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ReceiptsDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.ReceiptsDataGrid.EnableHeadersVisualStyles = false;
            this.ReceiptsDataGrid.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ReceiptsDataGrid.Location = new System.Drawing.Point(32, 195);
            this.ReceiptsDataGrid.Margin = new System.Windows.Forms.Padding(0);
            this.ReceiptsDataGrid.MultiSelect = false;
            this.ReceiptsDataGrid.Name = "ReceiptsDataGrid";
            this.ReceiptsDataGrid.ReadOnly = true;
            this.ReceiptsDataGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ReceiptsDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ReceiptsDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ReceiptsDataGrid.RowHeadersVisible = false;
            this.ReceiptsDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.ReceiptsDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.ReceiptsDataGrid.RowTemplate.Height = 40;
            this.ReceiptsDataGrid.RowTemplate.ReadOnly = true;
            this.ReceiptsDataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ReceiptsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ReceiptsDataGrid.Size = new System.Drawing.Size(960, 486);
            this.ReceiptsDataGrid.StandardTab = true;
            this.ReceiptsDataGrid.TabIndex = 16;
            this.ReceiptsDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReceiptsDataGrid_CellClick);
            // 
            // ucSalesOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(228)))), ((int)(((byte)(243)))));
            this.Controls.Add(this.ReceiptsDataGrid);
            this.Controls.Add(this.StatChart);
            this.Controls.Add(this.MenuBar);
            this.Name = "ucSalesOrders";
            this.Size = new System.Drawing.Size(1034, 681);
            this.Load += new System.EventHandler(this.ucSalesOrders_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.ReceiptsDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label ucLabel;
        private System.Windows.Forms.Panel MenuBar;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.Label LinkLabel;
        private System.Windows.Forms.Panel BasePanel1;
        private System.Windows.Forms.Panel BorderPanel1;
        private System.Windows.Forms.Label TotalReceiptsLabel;
        private System.Windows.Forms.Label TotalRCount;
        private System.Windows.Forms.Panel BorderPanel2;
        private System.Windows.Forms.Panel BasePanel2;
        private System.Windows.Forms.Label TodayValue;
        private System.Windows.Forms.Label TotalReceiptsToday;
        private System.Windows.Forms.Panel BorderPanel3;
        private System.Windows.Forms.Panel BasePanel3;
        private System.Windows.Forms.Label MonthCount;
        private System.Windows.Forms.Label MonthReceiptsLabel;
        private System.Windows.Forms.Panel StatChart;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.PictureBox AddIcon;
        private System.Windows.Forms.PictureBox EditIcon;
        private System.Windows.Forms.DataGridView ReceiptsDataGrid;
        private System.Windows.Forms.PictureBox SearchIcon;
    }
}
