namespace FinalProject2ndYear
{
    partial class editSalesOrderForm
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
            this.ReferenceNoTextBox = new System.Windows.Forms.TextBox();
            this.ReferenceNoLabel = new System.Windows.Forms.Label();
            this.ReceiptDateLabel = new System.Windows.Forms.Label();
            this.SupplierLabel = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.ReceiptDatePicker = new System.Windows.Forms.DateTimePicker();
            this.SupplierComboBox = new System.Windows.Forms.ComboBox();
            this.ItemsDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.DeleteProductButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ReferenceNoTextBox
            // 
            this.ReferenceNoTextBox.Location = new System.Drawing.Point(68, 53);
            this.ReferenceNoTextBox.Name = "ReferenceNoTextBox";
            this.ReferenceNoTextBox.Size = new System.Drawing.Size(145, 20);
            this.ReferenceNoTextBox.TabIndex = 0;
            // 
            // ReferenceNoLabel
            // 
            this.ReferenceNoLabel.AutoSize = true;
            this.ReferenceNoLabel.Location = new System.Drawing.Point(65, 37);
            this.ReferenceNoLabel.Name = "ReferenceNoLabel";
            this.ReferenceNoLabel.Size = new System.Drawing.Size(97, 13);
            this.ReferenceNoLabel.TabIndex = 5;
            this.ReferenceNoLabel.Text = "Reference Number";
            // 
            // ReceiptDateLabel
            // 
            this.ReceiptDateLabel.AutoSize = true;
            this.ReceiptDateLabel.Location = new System.Drawing.Point(65, 86);
            this.ReceiptDateLabel.Name = "ReceiptDateLabel";
            this.ReceiptDateLabel.Size = new System.Drawing.Size(70, 13);
            this.ReceiptDateLabel.TabIndex = 6;
            this.ReceiptDateLabel.Text = "Receipt Date";
            // 
            // SupplierLabel
            // 
            this.SupplierLabel.AutoSize = true;
            this.SupplierLabel.Location = new System.Drawing.Point(293, 37);
            this.SupplierLabel.Name = "SupplierLabel";
            this.SupplierLabel.Size = new System.Drawing.Size(45, 13);
            this.SupplierLabel.TabIndex = 8;
            this.SupplierLabel.Text = "Supplier";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(170, 364);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 10;
            this.SubmitButton.Text = "Done";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // ReceiptDatePicker
            // 
            this.ReceiptDatePicker.Location = new System.Drawing.Point(68, 103);
            this.ReceiptDatePicker.Name = "ReceiptDatePicker";
            this.ReceiptDatePicker.Size = new System.Drawing.Size(200, 20);
            this.ReceiptDatePicker.TabIndex = 11;
            // 
            // SupplierComboBox
            // 
            this.SupplierComboBox.FormattingEnabled = true;
            this.SupplierComboBox.Location = new System.Drawing.Point(296, 53);
            this.SupplierComboBox.Name = "SupplierComboBox";
            this.SupplierComboBox.Size = new System.Drawing.Size(136, 21);
            this.SupplierComboBox.TabIndex = 12;
            // 
            // ItemsDataGrid
            // 
            this.ItemsDataGrid.AllowUserToAddRows = false;
            this.ItemsDataGrid.AllowUserToDeleteRows = false;
            this.ItemsDataGrid.AllowUserToResizeColumns = false;
            this.ItemsDataGrid.AllowUserToResizeRows = false;
            this.ItemsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ItemsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsDataGrid.Location = new System.Drawing.Point(57, 171);
            this.ItemsDataGrid.MultiSelect = false;
            this.ItemsDataGrid.Name = "ItemsDataGrid";
            this.ItemsDataGrid.RowHeadersVisible = false;
            this.ItemsDataGrid.Size = new System.Drawing.Size(392, 177);
            this.ItemsDataGrid.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Products:";
            // 
            // AddProductButton
            // 
            this.AddProductButton.Location = new System.Drawing.Point(278, 142);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(75, 23);
            this.AddProductButton.TabIndex = 15;
            this.AddProductButton.Text = "Add";
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddRowButton_Click);
            // 
            // DeleteProductButton
            // 
            this.DeleteProductButton.Location = new System.Drawing.Point(359, 142);
            this.DeleteProductButton.Name = "DeleteProductButton";
            this.DeleteProductButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteProductButton.TabIndex = 16;
            this.DeleteProductButton.Text = "Delete";
            this.DeleteProductButton.UseVisualStyleBackColor = true;
            this.DeleteProductButton.Click += new System.EventHandler(this.RemoveRowButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(251, 364);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 17;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // editSalesOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 419);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.DeleteProductButton);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ItemsDataGrid);
            this.Controls.Add(this.SupplierComboBox);
            this.Controls.Add(this.ReceiptDatePicker);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.SupplierLabel);
            this.Controls.Add(this.ReceiptDateLabel);
            this.Controls.Add(this.ReferenceNoLabel);
            this.Controls.Add(this.ReferenceNoTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "editSalesOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Sales Order";
            this.Load += new System.EventHandler(this.editSalesOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ReferenceNoTextBox;
        private System.Windows.Forms.Label ReferenceNoLabel;
        private System.Windows.Forms.Label ReceiptDateLabel;
        private System.Windows.Forms.Label SupplierLabel;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.DateTimePicker ReceiptDatePicker;
        private System.Windows.Forms.ComboBox SupplierComboBox;
        private System.Windows.Forms.DataGridView ItemsDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.Button DeleteProductButton;
        private System.Windows.Forms.Button CancelButton;
    }
}