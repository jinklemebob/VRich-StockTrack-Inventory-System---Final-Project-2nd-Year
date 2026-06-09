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
            this.OrderDateLabel = new System.Windows.Forms.Label();
            this.SupplierLabel = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.OrderDatePicker = new System.Windows.Forms.DateTimePicker();
            this.SupplierComboBox = new System.Windows.Forms.ComboBox();
            this.ItemsDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.DeleteProductButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReferenceNoTextBox
            // 
            this.ReferenceNoTextBox.Location = new System.Drawing.Point(14, 28);
            this.ReferenceNoTextBox.Name = "ReferenceNoTextBox";
            this.ReferenceNoTextBox.Size = new System.Drawing.Size(145, 20);
            this.ReferenceNoTextBox.TabIndex = 0;
            this.ReferenceNoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ReferenceNoTextBox_KeyPress);
            // 
            // ReferenceNoLabel
            // 
            this.ReferenceNoLabel.AutoSize = true;
            this.ReferenceNoLabel.Location = new System.Drawing.Point(11, 13);
            this.ReferenceNoLabel.Name = "ReferenceNoLabel";
            this.ReferenceNoLabel.Size = new System.Drawing.Size(97, 13);
            this.ReferenceNoLabel.TabIndex = 5;
            this.ReferenceNoLabel.Text = "Reference Number";
            // 
            // OrderDateLabel
            // 
            this.OrderDateLabel.AutoSize = true;
            this.OrderDateLabel.Location = new System.Drawing.Point(11, 62);
            this.OrderDateLabel.Name = "OrderDateLabel";
            this.OrderDateLabel.Size = new System.Drawing.Size(59, 13);
            this.OrderDateLabel.TabIndex = 6;
            this.OrderDateLabel.Text = "Order Date";
            // 
            // SupplierLabel
            // 
            this.SupplierLabel.AutoSize = true;
            this.SupplierLabel.Location = new System.Drawing.Point(239, 13);
            this.SupplierLabel.Name = "SupplierLabel";
            this.SupplierLabel.Size = new System.Drawing.Size(45, 13);
            this.SupplierLabel.TabIndex = 8;
            this.SupplierLabel.Text = "Supplier";
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.SubmitButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Location = new System.Drawing.Point(346, 356);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(64, 29);
            this.SubmitButton.TabIndex = 10;
            this.SubmitButton.Text = "Done";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // OrderDatePicker
            // 
            this.OrderDatePicker.Location = new System.Drawing.Point(14, 79);
            this.OrderDatePicker.Name = "OrderDatePicker";
            this.OrderDatePicker.Size = new System.Drawing.Size(200, 20);
            this.OrderDatePicker.TabIndex = 11;
            // 
            // SupplierComboBox
            // 
            this.SupplierComboBox.FormattingEnabled = true;
            this.SupplierComboBox.Location = new System.Drawing.Point(242, 28);
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
            this.ItemsDataGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.ItemsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsDataGrid.Location = new System.Drawing.Point(18, 172);
            this.ItemsDataGrid.MultiSelect = false;
            this.ItemsDataGrid.Name = "ItemsDataGrid";
            this.ItemsDataGrid.RowHeadersVisible = false;
            this.ItemsDataGrid.RowHeadersWidth = 51;
            this.ItemsDataGrid.Size = new System.Drawing.Size(392, 177);
            this.ItemsDataGrid.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(15, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Products:";
            // 
            // AddProductButton
            // 
            this.AddProductButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.AddProductButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.AddProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddProductButton.Location = new System.Drawing.Point(346, 136);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(64, 28);
            this.AddProductButton.TabIndex = 15;
            this.AddProductButton.Text = "Add";
            this.AddProductButton.UseVisualStyleBackColor = false;
            this.AddProductButton.Click += new System.EventHandler(this.AddRowButton_Click);
            // 
            // DeleteProductButton
            // 
            this.DeleteProductButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DeleteProductButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.DeleteProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteProductButton.Location = new System.Drawing.Point(282, 136);
            this.DeleteProductButton.Name = "DeleteProductButton";
            this.DeleteProductButton.Size = new System.Drawing.Size(58, 28);
            this.DeleteProductButton.TabIndex = 16;
            this.DeleteProductButton.Text = "Delete";
            this.DeleteProductButton.UseVisualStyleBackColor = false;
            this.DeleteProductButton.Click += new System.EventHandler(this.RemoveRowButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Location = new System.Drawing.Point(282, 356);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(58, 29);
            this.CancelButton.TabIndex = 17;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.panel1.Controls.Add(this.OrderDatePicker);
            this.panel1.Controls.Add(this.ReferenceNoTextBox);
            this.panel1.Controls.Add(this.ReferenceNoLabel);
            this.panel1.Controls.Add(this.OrderDateLabel);
            this.panel1.Controls.Add(this.SupplierLabel);
            this.panel1.Controls.Add(this.SupplierComboBox);
            this.panel1.Location = new System.Drawing.Point(18, 17);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 111);
            this.panel1.TabIndex = 18;
            // 
            // editSalesOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(430, 395);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.DeleteProductButton);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ItemsDataGrid);
            this.Controls.Add(this.SubmitButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "editSalesOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Sales Order";
            this.Load += new System.EventHandler(this.editSalesOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ReferenceNoTextBox;
        private System.Windows.Forms.Label ReferenceNoLabel;
        private System.Windows.Forms.Label OrderDateLabel;
        private System.Windows.Forms.Label SupplierLabel;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.DateTimePicker OrderDatePicker;
        private System.Windows.Forms.ComboBox SupplierComboBox;
        private System.Windows.Forms.DataGridView ItemsDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.Button DeleteProductButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Panel panel1;
    }
}