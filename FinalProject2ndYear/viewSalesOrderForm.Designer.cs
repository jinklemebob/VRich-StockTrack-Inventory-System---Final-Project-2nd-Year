namespace FinalProject2ndYear
{
    partial class viewSalesOrderForm
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
            this.ReferenceNoLabel = new System.Windows.Forms.Label();
            this.ReceiptDateLabel = new System.Windows.Forms.Label();
            this.SupplierLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ItemsDataGrid = new System.Windows.Forms.DataGridView();
            this.ProductsLabel = new System.Windows.Forms.Label();
            this.ReceiptIDLabel = new System.Windows.Forms.Label();
            this.ReceiptID = new System.Windows.Forms.Label();
            this.ReferenceNo = new System.Windows.Forms.Label();
            this.Supplier = new System.Windows.Forms.Label();
            this.ReceiptDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ReferenceNoLabel
            // 
            this.ReferenceNoLabel.AutoSize = true;
            this.ReferenceNoLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReferenceNoLabel.ForeColor = System.Drawing.Color.GhostWhite;
            this.ReferenceNoLabel.Location = new System.Drawing.Point(358, 38);
            this.ReferenceNoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ReferenceNoLabel.Name = "ReferenceNoLabel";
            this.ReferenceNoLabel.Size = new System.Drawing.Size(111, 12);
            this.ReferenceNoLabel.TabIndex = 5;
            this.ReferenceNoLabel.Text = "Reference Number";
            // 
            // ReceiptDateLabel
            // 
            this.ReceiptDateLabel.AutoSize = true;
            this.ReceiptDateLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceiptDateLabel.ForeColor = System.Drawing.Color.GhostWhite;
            this.ReceiptDateLabel.Location = new System.Drawing.Point(358, 85);
            this.ReceiptDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ReceiptDateLabel.Name = "ReceiptDateLabel";
            this.ReceiptDateLabel.Size = new System.Drawing.Size(77, 12);
            this.ReceiptDateLabel.TabIndex = 6;
            this.ReceiptDateLabel.Text = "Receipt Date";
            // 
            // SupplierLabel
            // 
            this.SupplierLabel.AutoSize = true;
            this.SupplierLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierLabel.ForeColor = System.Drawing.Color.GhostWhite;
            this.SupplierLabel.Location = new System.Drawing.Point(75, 85);
            this.SupplierLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SupplierLabel.Name = "SupplierLabel";
            this.SupplierLabel.Size = new System.Drawing.Size(51, 12);
            this.SupplierLabel.TabIndex = 8;
            this.SupplierLabel.Text = "Supplier";
            // 
            // CloseButton
            // 
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CloseButton.Location = new System.Drawing.Point(252, 336);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 10;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ItemsDataGrid
            // 
            this.ItemsDataGrid.AllowUserToAddRows = false;
            this.ItemsDataGrid.AllowUserToDeleteRows = false;
            this.ItemsDataGrid.AllowUserToResizeColumns = false;
            this.ItemsDataGrid.AllowUserToResizeRows = false;
            this.ItemsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ItemsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsDataGrid.Enabled = false;
            this.ItemsDataGrid.Location = new System.Drawing.Point(72, 150);
            this.ItemsDataGrid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ItemsDataGrid.MultiSelect = false;
            this.ItemsDataGrid.Name = "ItemsDataGrid";
            this.ItemsDataGrid.ReadOnly = true;
            this.ItemsDataGrid.RowHeadersVisible = false;
            this.ItemsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItemsDataGrid.Size = new System.Drawing.Size(457, 163);
            this.ItemsDataGrid.TabIndex = 13;
            // 
            // ProductsLabel
            // 
            this.ProductsLabel.AutoSize = true;
            this.ProductsLabel.ForeColor = System.Drawing.Color.GhostWhite;
            this.ProductsLabel.Location = new System.Drawing.Point(76, 136);
            this.ProductsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProductsLabel.Name = "ProductsLabel";
            this.ProductsLabel.Size = new System.Drawing.Size(58, 12);
            this.ProductsLabel.TabIndex = 14;
            this.ProductsLabel.Text = "Products:";
            // 
            // ReceiptIDLabel
            // 
            this.ReceiptIDLabel.AutoSize = true;
            this.ReceiptIDLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceiptIDLabel.ForeColor = System.Drawing.Color.GhostWhite;
            this.ReceiptIDLabel.Location = new System.Drawing.Point(75, 38);
            this.ReceiptIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ReceiptIDLabel.Name = "ReceiptIDLabel";
            this.ReceiptIDLabel.Size = new System.Drawing.Size(62, 12);
            this.ReceiptIDLabel.TabIndex = 18;
            this.ReceiptIDLabel.Text = "Receipt ID";
            // 
            // ReceiptID
            // 
            this.ReceiptID.AutoSize = true;
            this.ReceiptID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceiptID.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.ReceiptID.Location = new System.Drawing.Point(75, 50);
            this.ReceiptID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ReceiptID.Name = "ReceiptID";
            this.ReceiptID.Size = new System.Drawing.Size(108, 15);
            this.ReceiptID.TabIndex = 19;
            this.ReceiptID.Text = "ReceiptIDValue";
            // 
            // ReferenceNo
            // 
            this.ReferenceNo.AutoSize = true;
            this.ReferenceNo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReferenceNo.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.ReferenceNo.Location = new System.Drawing.Point(358, 50);
            this.ReferenceNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ReferenceNo.Name = "ReferenceNo";
            this.ReferenceNo.Size = new System.Drawing.Size(129, 15);
            this.ReferenceNo.TabIndex = 20;
            this.ReferenceNo.Text = "ReferenceNoValue";
            // 
            // Supplier
            // 
            this.Supplier.AutoSize = true;
            this.Supplier.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supplier.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Supplier.Location = new System.Drawing.Point(75, 97);
            this.Supplier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Supplier.Name = "Supplier";
            this.Supplier.Size = new System.Drawing.Size(99, 15);
            this.Supplier.TabIndex = 21;
            this.Supplier.Text = "SupplierValue";
            // 
            // ReceiptDate
            // 
            this.ReceiptDate.AutoSize = true;
            this.ReceiptDate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceiptDate.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.ReceiptDate.Location = new System.Drawing.Point(358, 97);
            this.ReceiptDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ReceiptDate.Name = "ReceiptDate";
            this.ReceiptDate.Size = new System.Drawing.Size(125, 15);
            this.ReceiptDate.TabIndex = 22;
            this.ReceiptDate.Text = "ReceiptDateValue";
            // 
            // viewSalesOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(592, 387);
            this.Controls.Add(this.ReceiptDate);
            this.Controls.Add(this.Supplier);
            this.Controls.Add(this.ReferenceNo);
            this.Controls.Add(this.ReceiptID);
            this.Controls.Add(this.ReceiptIDLabel);
            this.Controls.Add(this.ProductsLabel);
            this.Controls.Add(this.ItemsDataGrid);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SupplierLabel);
            this.Controls.Add(this.ReceiptDateLabel);
            this.Controls.Add(this.ReferenceNoLabel);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "viewSalesOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Sales Order";
            this.Load += new System.EventHandler(this.viewSalesOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ReferenceNoLabel;
        private System.Windows.Forms.Label ReceiptDateLabel;
        private System.Windows.Forms.Label SupplierLabel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.DataGridView ItemsDataGrid;
        private System.Windows.Forms.Label ProductsLabel;
        private System.Windows.Forms.Label ReceiptIDLabel;
        private System.Windows.Forms.Label ReceiptID;
        private System.Windows.Forms.Label ReferenceNo;
        private System.Windows.Forms.Label Supplier;
        private System.Windows.Forms.Label ReceiptDate;
    }
}