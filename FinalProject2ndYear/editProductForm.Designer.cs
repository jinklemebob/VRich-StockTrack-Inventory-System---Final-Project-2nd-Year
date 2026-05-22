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
            this.SupplierNameTxtBox = new System.Windows.Forms.TextBox();
            this.ContactPersonTxtBox = new System.Windows.Forms.TextBox();
            this.EmailTxtBox = new System.Windows.Forms.TextBox();
            this.ContactNoTxtBox = new System.Windows.Forms.TextBox();
            this.SupplierNameLabel = new System.Windows.Forms.Label();
            this.ContactNoLabel = new System.Windows.Forms.Label();
            this.ContactPersonLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.StatusBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // SupplierNameTxtBox
            // 
            this.SupplierNameTxtBox.Location = new System.Drawing.Point(55, 62);
            this.SupplierNameTxtBox.Name = "SupplierNameTxtBox";
            this.SupplierNameTxtBox.Size = new System.Drawing.Size(145, 20);
            this.SupplierNameTxtBox.TabIndex = 0;
            // 
            // ContactPersonTxtBox
            // 
            this.ContactPersonTxtBox.Location = new System.Drawing.Point(283, 62);
            this.ContactPersonTxtBox.Name = "ContactPersonTxtBox";
            this.ContactPersonTxtBox.Size = new System.Drawing.Size(145, 20);
            this.ContactPersonTxtBox.TabIndex = 1;
            // 
            // EmailTxtBox
            // 
            this.EmailTxtBox.Location = new System.Drawing.Point(283, 111);
            this.EmailTxtBox.Name = "EmailTxtBox";
            this.EmailTxtBox.Size = new System.Drawing.Size(145, 20);
            this.EmailTxtBox.TabIndex = 2;
            // 
            // ContactNoTxtBox
            // 
            this.ContactNoTxtBox.Location = new System.Drawing.Point(55, 111);
            this.ContactNoTxtBox.Name = "ContactNoTxtBox";
            this.ContactNoTxtBox.Size = new System.Drawing.Size(145, 20);
            this.ContactNoTxtBox.TabIndex = 4;
            // 
            // SupplierNameLabel
            // 
            this.SupplierNameLabel.AutoSize = true;
            this.SupplierNameLabel.Location = new System.Drawing.Point(52, 46);
            this.SupplierNameLabel.Name = "SupplierNameLabel";
            this.SupplierNameLabel.Size = new System.Drawing.Size(76, 13);
            this.SupplierNameLabel.TabIndex = 5;
            this.SupplierNameLabel.Text = "Supplier Name";
            // 
            // ContactNoLabel
            // 
            this.ContactNoLabel.AutoSize = true;
            this.ContactNoLabel.Location = new System.Drawing.Point(52, 95);
            this.ContactNoLabel.Name = "ContactNoLabel";
            this.ContactNoLabel.Size = new System.Drawing.Size(64, 13);
            this.ContactNoLabel.TabIndex = 6;
            this.ContactNoLabel.Text = "Contact No.";
            // 
            // ContactPersonLabel
            // 
            this.ContactPersonLabel.AutoSize = true;
            this.ContactPersonLabel.Location = new System.Drawing.Point(280, 46);
            this.ContactPersonLabel.Name = "ContactPersonLabel";
            this.ContactPersonLabel.Size = new System.Drawing.Size(80, 13);
            this.ContactPersonLabel.TabIndex = 8;
            this.ContactPersonLabel.Text = "Contact Person";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(280, 95);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(32, 13);
            this.EmailLabel.TabIndex = 9;
            this.EmailLabel.Text = "Email";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(203, 212);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 31);
            this.SubmitButton.TabIndex = 10;
            this.SubmitButton.Text = "Done";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(175, 151);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(37, 13);
            this.StatusLabel.TabIndex = 12;
            this.StatusLabel.Text = "Status";
            // 
            // StatusBox
            // 
            this.StatusBox.FormattingEnabled = true;
            this.StatusBox.Location = new System.Drawing.Point(178, 167);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(121, 21);
            this.StatusBox.TabIndex = 13;
            // 
            // editSupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 255);
            this.Controls.Add(this.StatusBox);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.ContactPersonLabel);
            this.Controls.Add(this.ContactNoLabel);
            this.Controls.Add(this.SupplierNameLabel);
            this.Controls.Add(this.ContactNoTxtBox);
            this.Controls.Add(this.EmailTxtBox);
            this.Controls.Add(this.ContactPersonTxtBox);
            this.Controls.Add(this.SupplierNameTxtBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "editSupplierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Supplier";
            this.Load += new System.EventHandler(this.editSupplierForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SupplierNameTxtBox;
        private System.Windows.Forms.TextBox ContactPersonTxtBox;
        private System.Windows.Forms.TextBox EmailTxtBox;
        private System.Windows.Forms.TextBox ContactNoTxtBox;
        private System.Windows.Forms.Label SupplierNameLabel;
        private System.Windows.Forms.Label ContactNoLabel;
        private System.Windows.Forms.Label ContactPersonLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.ComboBox StatusBox;
    }
}