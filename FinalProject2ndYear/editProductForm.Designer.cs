namespace FinalProject2ndYear
{
    partial class editProductForm
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
            this.StatusBox = new System.Windows.Forms.ComboBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProductDescBox
            // 
            this.ProductDescBox.Location = new System.Drawing.Point(55, 53);
            this.ProductDescBox.Name = "ProductDescBox";
            this.ProductDescBox.Size = new System.Drawing.Size(145, 20);
            this.ProductDescBox.TabIndex = 0;
            // 
            // ReorderLvlBox
            // 
            this.ReorderLvlBox.Location = new System.Drawing.Point(55, 102);
            this.ReorderLvlBox.Name = "ReorderLvlBox";
            this.ReorderLvlBox.Size = new System.Drawing.Size(145, 20);
            this.ReorderLvlBox.TabIndex = 4;
            // 
            // DescLabel
            // 
            this.DescLabel.AutoSize = true;
            this.DescLabel.Location = new System.Drawing.Point(52, 37);
            this.DescLabel.Name = "DescLabel";
            this.DescLabel.Size = new System.Drawing.Size(60, 13);
            this.DescLabel.TabIndex = 5;
            this.DescLabel.Text = "Description";
            // 
            // ReorderLvlLabel
            // 
            this.ReorderLvlLabel.AutoSize = true;
            this.ReorderLvlLabel.Location = new System.Drawing.Point(52, 86);
            this.ReorderLvlLabel.Name = "ReorderLvlLabel";
            this.ReorderLvlLabel.Size = new System.Drawing.Size(74, 13);
            this.ReorderLvlLabel.TabIndex = 6;
            this.ReorderLvlLabel.Text = "Reorder Level";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(280, 37);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(49, 13);
            this.CategoryLabel.TabIndex = 8;
            this.CategoryLabel.Text = "Category";
            // 
            // UOMLabel
            // 
            this.UOMLabel.AutoSize = true;
            this.UOMLabel.Location = new System.Drawing.Point(280, 86);
            this.UOMLabel.Name = "UOMLabel";
            this.UOMLabel.Size = new System.Drawing.Size(105, 13);
            this.UOMLabel.TabIndex = 9;
            this.UOMLabel.Text = "Unit of Measurement";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(167, 187);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 10;
            this.SubmitButton.Text = "Done";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // CategoryBox
            // 
            this.CategoryBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryBox.FormattingEnabled = true;
            this.CategoryBox.Location = new System.Drawing.Point(283, 53);
            this.CategoryBox.Name = "CategoryBox";
            this.CategoryBox.Size = new System.Drawing.Size(145, 21);
            this.CategoryBox.TabIndex = 11;
            // 
            // UOMBox
            // 
            this.UOMBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UOMBox.FormattingEnabled = true;
            this.UOMBox.Location = new System.Drawing.Point(283, 102);
            this.UOMBox.Name = "UOMBox";
            this.UOMBox.Size = new System.Drawing.Size(145, 21);
            this.UOMBox.TabIndex = 12;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(246, 187);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 13;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // StatusBox
            // 
            this.StatusBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusBox.FormattingEnabled = true;
            this.StatusBox.Location = new System.Drawing.Point(171, 154);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(145, 21);
            this.StatusBox.TabIndex = 15;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(168, 138);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(37, 13);
            this.StatusLabel.TabIndex = 14;
            this.StatusLabel.Text = "Status";
            // 
            // editProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 225);
            this.Controls.Add(this.StatusBox);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.UOMBox);
            this.Controls.Add(this.CategoryBox);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.UOMLabel);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.ReorderLvlLabel);
            this.Controls.Add(this.DescLabel);
            this.Controls.Add(this.ReorderLvlBox);
            this.Controls.Add(this.ProductDescBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "editProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Product";
            this.Load += new System.EventHandler(this.editProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.ComboBox StatusBox;
        private System.Windows.Forms.Label StatusLabel;
    }
}