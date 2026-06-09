namespace FinalProject2ndYear
{
    partial class addProductForm
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
            this.ProductDescBox = new System.Windows.Forms.TextBox();
            this.ReorderLvlBox = new System.Windows.Forms.TextBox();
            this.DescLabel = new System.Windows.Forms.Label();
            this.ReorderLvlLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.UOMLabel = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.CategoryBox = new System.Windows.Forms.ComboBox();
            this.UOMBox = new System.Windows.Forms.ComboBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SupplierBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductDescBox
            // 
            this.ProductDescBox.Location = new System.Drawing.Point(22, 35);
            this.ProductDescBox.Name = "ProductDescBox";
            this.ProductDescBox.Size = new System.Drawing.Size(145, 20);
            this.ProductDescBox.TabIndex = 0;
            this.ProductDescBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProductDescBox_KeyPress);
            // 
            // ReorderLvlBox
            // 
            this.ReorderLvlBox.Location = new System.Drawing.Point(22, 76);
            this.ReorderLvlBox.Name = "ReorderLvlBox";
            this.ReorderLvlBox.Size = new System.Drawing.Size(145, 20);
            this.ReorderLvlBox.TabIndex = 4;
            // 
            // DescLabel
            // 
            this.DescLabel.AutoSize = true;
            this.DescLabel.Location = new System.Drawing.Point(19, 20);
            this.DescLabel.Name = "DescLabel";
            this.DescLabel.Size = new System.Drawing.Size(60, 13);
            this.DescLabel.TabIndex = 5;
            this.DescLabel.Text = "Description";
            // 
            // ReorderLvlLabel
            // 
            this.ReorderLvlLabel.AutoSize = true;
            this.ReorderLvlLabel.Location = new System.Drawing.Point(19, 59);
            this.ReorderLvlLabel.Name = "ReorderLvlLabel";
            this.ReorderLvlLabel.Size = new System.Drawing.Size(74, 13);
            this.ReorderLvlLabel.TabIndex = 6;
            this.ReorderLvlLabel.Text = "Reorder Level";
            this.ReorderLvlLabel.Click += new System.EventHandler(this.ReorderLvlLabel_Click);
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(19, 181);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(49, 13);
            this.CategoryLabel.TabIndex = 8;
            this.CategoryLabel.Text = "Category";
            // 
            // UOMLabel
            // 
            this.UOMLabel.AutoSize = true;
            this.UOMLabel.Location = new System.Drawing.Point(19, 141);
            this.UOMLabel.Name = "UOMLabel";
            this.UOMLabel.Size = new System.Drawing.Size(105, 13);
            this.UOMLabel.TabIndex = 9;
            this.UOMLabel.Text = "Unit of Measurement";
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.SubmitButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Location = new System.Drawing.Point(114, 282);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(95, 28);
            this.SubmitButton.TabIndex = 10;
            this.SubmitButton.Text = "Done";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // CategoryBox
            // 
            this.CategoryBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryBox.FormattingEnabled = true;
            this.CategoryBox.Location = new System.Drawing.Point(22, 196);
            this.CategoryBox.Name = "CategoryBox";
            this.CategoryBox.Size = new System.Drawing.Size(145, 21);
            this.CategoryBox.TabIndex = 11;
            // 
            // UOMBox
            // 
            this.UOMBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UOMBox.FormattingEnabled = true;
            this.UOMBox.Location = new System.Drawing.Point(22, 157);
            this.UOMBox.Name = "UOMBox";
            this.UOMBox.Size = new System.Drawing.Size(145, 21);
            this.UOMBox.TabIndex = 12;
            this.UOMBox.SelectedIndexChanged += new System.EventHandler(this.UOMBox_SelectedIndexChanged);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Location = new System.Drawing.Point(21, 282);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(88, 28);
            this.CancelButton.TabIndex = 13;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.SupplierBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CategoryBox);
            this.panel1.Controls.Add(this.ProductDescBox);
            this.panel1.Controls.Add(this.UOMBox);
            this.panel1.Controls.Add(this.ReorderLvlBox);
            this.panel1.Controls.Add(this.DescLabel);
            this.panel1.Controls.Add(this.ReorderLvlLabel);
            this.panel1.Controls.Add(this.UOMLabel);
            this.panel1.Controls.Add(this.CategoryLabel);
            this.panel1.Location = new System.Drawing.Point(20, 23);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 245);
            this.panel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Supplier";
            // 
            // SupplierBox
            // 
            this.SupplierBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SupplierBox.FormattingEnabled = true;
            this.SupplierBox.Location = new System.Drawing.Point(22, 115);
            this.SupplierBox.Name = "SupplierBox";
            this.SupplierBox.Size = new System.Drawing.Size(145, 21);
            this.SupplierBox.TabIndex = 14;
            // 
            // addProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(231, 328);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SubmitButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Product";
            this.Load += new System.EventHandler(this.addProductForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox ProductDescBox;
        private System.Windows.Forms.TextBox ReorderLvlBox;
        private System.Windows.Forms.Label DescLabel;
        private System.Windows.Forms.Label ReorderLvlLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label UOMLabel;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.ComboBox CategoryBox;
        private System.Windows.Forms.ComboBox UOMBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox SupplierBox;
        private System.Windows.Forms.Label label1;
    }
}