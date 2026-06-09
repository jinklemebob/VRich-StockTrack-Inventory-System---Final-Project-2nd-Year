namespace FinalProject2ndYear
{
    partial class addSupplierForm
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
            this.CancelButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SupplierNameTxtBox
            // 
            this.SupplierNameTxtBox.Location = new System.Drawing.Point(16, 32);
            this.SupplierNameTxtBox.Name = "SupplierNameTxtBox";
            this.SupplierNameTxtBox.Size = new System.Drawing.Size(145, 20);
            this.SupplierNameTxtBox.TabIndex = 0;
            this.SupplierNameTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SupplierNameBox_KeyPress);
            // 
            // ContactPersonTxtBox
            // 
            this.ContactPersonTxtBox.Location = new System.Drawing.Point(16, 114);
            this.ContactPersonTxtBox.Name = "ContactPersonTxtBox";
            this.ContactPersonTxtBox.Size = new System.Drawing.Size(145, 20);
            this.ContactPersonTxtBox.TabIndex = 1;
            this.ContactPersonTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ContactPersonBox_KeyPress);
            // 
            // EmailTxtBox
            // 
            this.EmailTxtBox.Location = new System.Drawing.Point(16, 155);
            this.EmailTxtBox.Name = "EmailTxtBox";
            this.EmailTxtBox.Size = new System.Drawing.Size(145, 20);
            this.EmailTxtBox.TabIndex = 2;
            // 
            // ContactNoTxtBox
            // 
            this.ContactNoTxtBox.Location = new System.Drawing.Point(16, 73);
            this.ContactNoTxtBox.Name = "ContactNoTxtBox";
            this.ContactNoTxtBox.Size = new System.Drawing.Size(145, 20);
            this.ContactNoTxtBox.TabIndex = 4;
            this.ContactNoTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ContactNoBox_KeyPress);
            // 
            // SupplierNameLabel
            // 
            this.SupplierNameLabel.AutoSize = true;
            this.SupplierNameLabel.Location = new System.Drawing.Point(13, 16);
            this.SupplierNameLabel.Name = "SupplierNameLabel";
            this.SupplierNameLabel.Size = new System.Drawing.Size(76, 13);
            this.SupplierNameLabel.TabIndex = 5;
            this.SupplierNameLabel.Text = "Supplier Name";
            // 
            // ContactNoLabel
            // 
            this.ContactNoLabel.AutoSize = true;
            this.ContactNoLabel.Location = new System.Drawing.Point(13, 57);
            this.ContactNoLabel.Name = "ContactNoLabel";
            this.ContactNoLabel.Size = new System.Drawing.Size(64, 13);
            this.ContactNoLabel.TabIndex = 6;
            this.ContactNoLabel.Text = "Contact No.";
            // 
            // ContactPersonLabel
            // 
            this.ContactPersonLabel.AutoSize = true;
            this.ContactPersonLabel.Location = new System.Drawing.Point(13, 98);
            this.ContactPersonLabel.Name = "ContactPersonLabel";
            this.ContactPersonLabel.Size = new System.Drawing.Size(80, 13);
            this.ContactPersonLabel.TabIndex = 8;
            this.ContactPersonLabel.Text = "Contact Person";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(13, 139);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(32, 13);
            this.EmailLabel.TabIndex = 9;
            this.EmailLabel.Text = "Email";
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.SubmitButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Location = new System.Drawing.Point(109, 232);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(87, 27);
            this.SubmitButton.TabIndex = 10;
            this.SubmitButton.Text = "Done";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Location = new System.Drawing.Point(21, 232);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(86, 27);
            this.CancelButton.TabIndex = 11;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.SupplierNameLabel);
            this.panel1.Controls.Add(this.SupplierNameTxtBox);
            this.panel1.Controls.Add(this.ContactPersonTxtBox);
            this.panel1.Controls.Add(this.EmailLabel);
            this.panel1.Controls.Add(this.EmailTxtBox);
            this.panel1.Controls.Add(this.ContactPersonLabel);
            this.panel1.Controls.Add(this.ContactNoTxtBox);
            this.panel1.Controls.Add(this.ContactNoLabel);
            this.panel1.Location = new System.Drawing.Point(21, 21);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 199);
            this.panel1.TabIndex = 12;
            // 
            // addSupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(220, 270);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SubmitButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addSupplierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Supplier";
            this.Load += new System.EventHandler(this.addSupplierForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Panel panel1;
    }
}