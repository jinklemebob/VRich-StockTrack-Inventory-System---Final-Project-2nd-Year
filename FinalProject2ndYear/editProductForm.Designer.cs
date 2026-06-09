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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductDescBox
            // 
            this.ProductDescBox.Location = new System.Drawing.Point(20, 35);
            this.ProductDescBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProductDescBox.Name = "ProductDescBox";
            this.ProductDescBox.Size = new System.Drawing.Size(192, 22);
            this.ProductDescBox.TabIndex = 0;
            // 
            // ReorderLvlBox
            // 
            this.ReorderLvlBox.Location = new System.Drawing.Point(20, 96);
            this.ReorderLvlBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReorderLvlBox.Name = "ReorderLvlBox";
            this.ReorderLvlBox.Size = new System.Drawing.Size(192, 22);
            this.ReorderLvlBox.TabIndex = 4;
            // 
            // DescLabel
            // 
            this.DescLabel.AutoSize = true;
            this.DescLabel.Location = new System.Drawing.Point(16, 16);
            this.DescLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DescLabel.Name = "DescLabel";
            this.DescLabel.Size = new System.Drawing.Size(75, 16);
            this.DescLabel.TabIndex = 5;
            this.DescLabel.Text = "Description";
            // 
            // ReorderLvlLabel
            // 
            this.ReorderLvlLabel.AutoSize = true;
            this.ReorderLvlLabel.Location = new System.Drawing.Point(16, 76);
            this.ReorderLvlLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ReorderLvlLabel.Name = "ReorderLvlLabel";
            this.ReorderLvlLabel.Size = new System.Drawing.Size(93, 16);
            this.ReorderLvlLabel.TabIndex = 6;
            this.ReorderLvlLabel.Text = "Reorder Level";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(216, 16);
            this.CategoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(62, 16);
            this.CategoryLabel.TabIndex = 8;
            this.CategoryLabel.Text = "Category";
            // 
            // UOMLabel
            // 
            this.UOMLabel.AutoSize = true;
            this.UOMLabel.Location = new System.Drawing.Point(216, 76);
            this.UOMLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UOMLabel.Name = "UOMLabel";
            this.UOMLabel.Size = new System.Drawing.Size(129, 16);
            this.UOMLabel.TabIndex = 9;
            this.UOMLabel.Text = "Unit of Measurement";
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.SubmitButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Location = new System.Drawing.Point(361, 230);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(89, 33);
            this.SubmitButton.TabIndex = 10;
            this.SubmitButton.Text = "Done";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // CategoryBox
            // 
            this.CategoryBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryBox.FormattingEnabled = true;
            this.CategoryBox.Location = new System.Drawing.Point(220, 35);
            this.CategoryBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CategoryBox.Name = "CategoryBox";
            this.CategoryBox.Size = new System.Drawing.Size(192, 24);
            this.CategoryBox.TabIndex = 11;
            // 
            // UOMBox
            // 
            this.UOMBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UOMBox.FormattingEnabled = true;
            this.UOMBox.Location = new System.Drawing.Point(220, 96);
            this.UOMBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UOMBox.Name = "UOMBox";
            this.UOMBox.Size = new System.Drawing.Size(192, 24);
            this.UOMBox.TabIndex = 12;
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Location = new System.Drawing.Point(264, 230);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(89, 34);
            this.CancelButton.TabIndex = 13;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // StatusBox
            // 
            this.StatusBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusBox.FormattingEnabled = true;
            this.StatusBox.Location = new System.Drawing.Point(119, 155);
            this.StatusBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(192, 24);
            this.StatusBox.TabIndex = 15;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(115, 135);
            this.StatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(44, 16);
            this.StatusLabel.TabIndex = 14;
            this.StatusLabel.Text = "Status";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.panel1.Controls.Add(this.UOMBox);
            this.panel1.Controls.Add(this.StatusBox);
            this.panel1.Controls.Add(this.ProductDescBox);
            this.panel1.Controls.Add(this.StatusLabel);
            this.panel1.Controls.Add(this.ReorderLvlBox);
            this.panel1.Controls.Add(this.DescLabel);
            this.panel1.Controls.Add(this.ReorderLvlLabel);
            this.panel1.Controls.Add(this.CategoryBox);
            this.panel1.Controls.Add(this.CategoryLabel);
            this.panel1.Controls.Add(this.UOMLabel);
            this.panel1.Location = new System.Drawing.Point(22, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 202);
            this.panel1.TabIndex = 16;
            // 
            // editProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(473, 276);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SubmitButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "editProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Product";
            this.Load += new System.EventHandler(this.editProductForm_Load);
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
        private System.Windows.Forms.ComboBox StatusBox;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Panel panel1;
    }
}