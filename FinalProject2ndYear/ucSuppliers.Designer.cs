namespace FinalProject2ndYear
{
    partial class ucSuppliers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.SupplierMenuBar = new System.Windows.Forms.Panel();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.OperationLabel = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.SupplierDataPanel = new System.Windows.Forms.Panel();
            this.SupplierDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.SupplierMenuBar.SuspendLayout();
            this.SupplierDataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.WelcomeLabel.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.ForeColor = System.Drawing.Color.GhostWhite;
            this.WelcomeLabel.Location = new System.Drawing.Point(3, 63);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(155, 40);
            this.WelcomeLabel.TabIndex = 7;
            this.WelcomeLabel.Text = "Suppliers";
            // 
            // SupplierMenuBar
            // 
            this.SupplierMenuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.SupplierMenuBar.Controls.Add(this.label1);
            this.SupplierMenuBar.Controls.Add(this.SearchBox);
            this.SupplierMenuBar.Controls.Add(this.OperationLabel);
            this.SupplierMenuBar.Controls.Add(this.DeleteButton);
            this.SupplierMenuBar.Controls.Add(this.EditButton);
            this.SupplierMenuBar.Controls.Add(this.AddButton);
            this.SupplierMenuBar.Controls.Add(this.WelcomeLabel);
            this.SupplierMenuBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.SupplierMenuBar.Location = new System.Drawing.Point(0, 0);
            this.SupplierMenuBar.Name = "SupplierMenuBar";
            this.SupplierMenuBar.Size = new System.Drawing.Size(1034, 117);
            this.SupplierMenuBar.TabIndex = 8;
            // 
            // SearchBox
            // 
            this.SearchBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.SearchBox.Location = new System.Drawing.Point(814, 60);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(198, 20);
            this.SearchBox.TabIndex = 12;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // OperationLabel
            // 
            this.OperationLabel.AutoSize = true;
            this.OperationLabel.BackColor = System.Drawing.Color.Transparent;
            this.OperationLabel.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperationLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.OperationLabel.Location = new System.Drawing.Point(317, 69);
            this.OperationLabel.Name = "OperationLabel";
            this.OperationLabel.Size = new System.Drawing.Size(248, 40);
            this.OperationLabel.TabIndex = 11;
            this.OperationLabel.Text = "OperationLabel";
            this.OperationLabel.Visible = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(950, 86);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(62, 23);
            this.DeleteButton.TabIndex = 10;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(882, 86);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(62, 23);
            this.EditButton.TabIndex = 9;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(814, 86);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(62, 23);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SupplierDataPanel
            // 
            this.SupplierDataPanel.Controls.Add(this.SupplierDataGrid);
            this.SupplierDataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SupplierDataPanel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.SupplierDataPanel.Location = new System.Drawing.Point(0, 117);
            this.SupplierDataPanel.Name = "SupplierDataPanel";
            this.SupplierDataPanel.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.SupplierDataPanel.Size = new System.Drawing.Size(1034, 564);
            this.SupplierDataPanel.TabIndex = 9;
            // 
            // SupplierDataGrid
            // 
            this.SupplierDataGrid.AllowUserToAddRows = false;
            this.SupplierDataGrid.AllowUserToDeleteRows = false;
            this.SupplierDataGrid.AllowUserToResizeColumns = false;
            this.SupplierDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.SupplierDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SupplierDataGrid.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.SupplierDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SupplierDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SupplierDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.SupplierDataGrid.ColumnHeadersHeight = 26;
            this.SupplierDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.SupplierDataGrid.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SupplierDataGrid.DefaultCellStyle = dataGridViewCellStyle18;
            this.SupplierDataGrid.Enabled = false;
            this.SupplierDataGrid.EnableHeadersVisualStyles = false;
            this.SupplierDataGrid.GridColor = System.Drawing.Color.GhostWhite;
            this.SupplierDataGrid.Location = new System.Drawing.Point(0, -2);
            this.SupplierDataGrid.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.SupplierDataGrid.MultiSelect = false;
            this.SupplierDataGrid.Name = "SupplierDataGrid";
            this.SupplierDataGrid.ReadOnly = true;
            this.SupplierDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SupplierDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.SupplierDataGrid.RowHeadersVisible = false;
            this.SupplierDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.SupplierDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.SupplierDataGrid.RowTemplate.Height = 35;
            this.SupplierDataGrid.RowTemplate.ReadOnly = true;
            this.SupplierDataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SupplierDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SupplierDataGrid.Size = new System.Drawing.Size(1034, 362);
            this.SupplierDataGrid.StandardTab = true;
            this.SupplierDataGrid.TabIndex = 8;
            this.SupplierDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(814, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Search:";
            // 
            // ucSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.Controls.Add(this.SupplierDataPanel);
            this.Controls.Add(this.SupplierMenuBar);
            this.Name = "ucSuppliers";
            this.Size = new System.Drawing.Size(1034, 681);
            this.Load += new System.EventHandler(this.ucSuppliers_Load);
            this.SupplierMenuBar.ResumeLayout(false);
            this.SupplierMenuBar.PerformLayout();
            this.SupplierDataPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SupplierDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Panel SupplierMenuBar;
        private System.Windows.Forms.Panel SupplierDataPanel;
        private System.Windows.Forms.DataGridView SupplierDataGrid;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label OperationLabel;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label label1;
    }
}
