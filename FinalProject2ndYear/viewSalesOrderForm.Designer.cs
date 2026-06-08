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
            this.ReferenceNoLabel.Location = new System.Drawing.Point(307, 41);
            this.ReferenceNoLabel.Name = "ReferenceNoLabel";
            this.ReferenceNoLabel.Size = new System.Drawing.Size(97, 13);
            this.ReferenceNoLabel.TabIndex = 5;
            this.ReferenceNoLabel.Text = "Reference Number";
            // 
            // ReceiptDateLabel
            // 
            this.ReceiptDateLabel.AutoSize = true;
            this.ReceiptDateLabel.Location = new System.Drawing.Point(307, 92);
            this.ReceiptDateLabel.Name = "ReceiptDateLabel";
            this.ReceiptDateLabel.Size = new System.Drawing.Size(70, 13);
            this.ReceiptDateLabel.TabIndex = 6;
            this.ReceiptDateLabel.Text = "Receipt Date";
            // 
            // SupplierLabel
            // 
            this.SupplierLabel.AutoSize = true;
            this.SupplierLabel.Location = new System.Drawing.Point(64, 92);
            this.SupplierLabel.Name = "SupplierLabel";
            this.SupplierLabel.Size = new System.Drawing.Size(45, 13);
            this.SupplierLabel.TabIndex = 8;
            this.SupplierLabel.Text = "Supplier";
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(216, 364);
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
            this.ItemsDataGrid.Location = new System.Drawing.Point(62, 163);
            this.ItemsDataGrid.MultiSelect = false;
            this.ItemsDataGrid.Name = "ItemsDataGrid";
            this.ItemsDataGrid.ReadOnly = true;
            this.ItemsDataGrid.RowHeadersVisible = false;
            this.ItemsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItemsDataGrid.Size = new System.Drawing.Size(392, 177);
            this.ItemsDataGrid.TabIndex = 13;
            // 
            // ProductsLabel
            // 
            this.ProductsLabel.AutoSize = true;
            this.ProductsLabel.Location = new System.Drawing.Point(65, 147);
            this.ProductsLabel.Name = "ProductsLabel";
            this.ProductsLabel.Size = new System.Drawing.Size(52, 13);
            this.ProductsLabel.TabIndex = 14;
            this.ProductsLabel.Text = "Products:";
            // 
            // ReceiptIDLabel
            // 
            this.ReceiptIDLabel.AutoSize = true;
            this.ReceiptIDLabel.Location = new System.Drawing.Point(64, 41);
            this.ReceiptIDLabel.Name = "ReceiptIDLabel";
            this.ReceiptIDLabel.Size = new System.Drawing.Size(58, 13);
            this.ReceiptIDLabel.TabIndex = 18;
            this.ReceiptIDLabel.Text = "Receipt ID";
            // 
            // ReceiptID
            // 
            this.ReceiptID.AutoSize = true;
            this.ReceiptID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceiptID.Location = new System.Drawing.Point(64, 54);
            this.ReceiptID.Name = "ReceiptID";
            this.ReceiptID.Size = new System.Drawing.Size(116, 16);
            this.ReceiptID.TabIndex = 19;
            this.ReceiptID.Text = "ReceiptIDValue";
            // 
            // ReferenceNo
            // 
            this.ReferenceNo.AutoSize = true;
            this.ReferenceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReferenceNo.Location = new System.Drawing.Point(307, 54);
            this.ReferenceNo.Name = "ReferenceNo";
            this.ReferenceNo.Size = new System.Drawing.Size(139, 16);
            this.ReferenceNo.TabIndex = 20;
            this.ReferenceNo.Text = "ReferenceNoValue";
            // 
            // Supplier
            // 
            this.Supplier.AutoSize = true;
            this.Supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supplier.Location = new System.Drawing.Point(64, 105);
            this.Supplier.Name = "Supplier";
            this.Supplier.Size = new System.Drawing.Size(105, 16);
            this.Supplier.TabIndex = 21;
            this.Supplier.Text = "SupplierValue";
            // 
            // ReceiptDate
            // 
            this.ReceiptDate.AutoSize = true;
            this.ReceiptDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceiptDate.Location = new System.Drawing.Point(307, 105);
            this.ReceiptDate.Name = "ReceiptDate";
            this.ReceiptDate.Size = new System.Drawing.Size(134, 16);
            this.ReceiptDate.TabIndex = 22;
            this.ReceiptDate.Text = "ReceiptDateValue";
            // 
            // viewSalesOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 419);
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