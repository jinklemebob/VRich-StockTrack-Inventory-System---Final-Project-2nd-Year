namespace FinalProject2ndYear
{
	partial class editCustomerForm
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
            this.CustomerNameTextBox = new System.Windows.Forms.TextBox();
            this.ContactPersonTextBox = new System.Windows.Forms.TextBox();
            this.ContactNoTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.SupplierNameLabel = new System.Windows.Forms.Label();
            this.ContactPersonLabel = new System.Windows.Forms.Label();
            this.ContactNoLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.StatusBox = new System.Windows.Forms.ComboBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomerNameTextBox
            // 
            this.CustomerNameTextBox.Location = new System.Drawing.Point(29, 44);
            this.CustomerNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CustomerNameTextBox.Name = "CustomerNameTextBox";
            this.CustomerNameTextBox.Size = new System.Drawing.Size(192, 22);
            this.CustomerNameTextBox.TabIndex = 1;
            // 
            // ContactPersonTextBox
            // 
            this.ContactPersonTextBox.Location = new System.Drawing.Point(229, 44);
            this.ContactPersonTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ContactPersonTextBox.Name = "ContactPersonTextBox";
            this.ContactPersonTextBox.Size = new System.Drawing.Size(192, 22);
            this.ContactPersonTextBox.TabIndex = 2;
            // 
            // ContactNoTextBox
            // 
            this.ContactNoTextBox.Location = new System.Drawing.Point(29, 110);
            this.ContactNoTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ContactNoTextBox.Name = "ContactNoTextBox";
            this.ContactNoTextBox.Size = new System.Drawing.Size(192, 22);
            this.ContactNoTextBox.TabIndex = 3;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(229, 110);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(192, 22);
            this.EmailTextBox.TabIndex = 4;
            // 
            // SupplierNameLabel
            // 
            this.SupplierNameLabel.AutoSize = true;
            this.SupplierNameLabel.Location = new System.Drawing.Point(26, 24);
            this.SupplierNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SupplierNameLabel.Name = "SupplierNameLabel";
            this.SupplierNameLabel.Size = new System.Drawing.Size(104, 16);
            this.SupplierNameLabel.TabIndex = 7;
            this.SupplierNameLabel.Text = "Customer Name";
            // 
            // ContactPersonLabel
            // 
            this.ContactPersonLabel.AutoSize = true;
            this.ContactPersonLabel.Location = new System.Drawing.Point(225, 24);
            this.ContactPersonLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ContactPersonLabel.Name = "ContactPersonLabel";
            this.ContactPersonLabel.Size = new System.Drawing.Size(98, 16);
            this.ContactPersonLabel.TabIndex = 10;
            this.ContactPersonLabel.Text = "Contact Person";
            // 
            // ContactNoLabel
            // 
            this.ContactNoLabel.AutoSize = true;
            this.ContactNoLabel.Location = new System.Drawing.Point(26, 90);
            this.ContactNoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ContactNoLabel.Name = "ContactNoLabel";
            this.ContactNoLabel.Size = new System.Drawing.Size(76, 16);
            this.ContactNoLabel.TabIndex = 11;
            this.ContactNoLabel.Text = "Contact No.";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(225, 90);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(41, 16);
            this.EmailLabel.TabIndex = 12;
            this.EmailLabel.Text = "Email";
            // 
            // StatusBox
            // 
            this.StatusBox.FormattingEnabled = true;
            this.StatusBox.Location = new System.Drawing.Point(144, 170);
            this.StatusBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(160, 24);
            this.StatusBox.TabIndex = 14;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(141, 150);
            this.StatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(44, 16);
            this.StatusLabel.TabIndex = 15;
            this.StatusLabel.Text = "Status";
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.SubmitButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Location = new System.Drawing.Point(369, 255);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(100, 32);
            this.SubmitButton.TabIndex = 16;
            this.SubmitButton.Text = "Done";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Location = new System.Drawing.Point(261, 255);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 32);
            this.CancelButton.TabIndex = 17;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.EmailTextBox);
            this.panel1.Controls.Add(this.CustomerNameTextBox);
            this.panel1.Controls.Add(this.ContactPersonTextBox);
            this.panel1.Controls.Add(this.StatusLabel);
            this.panel1.Controls.Add(this.ContactNoTextBox);
            this.panel1.Controls.Add(this.StatusBox);
            this.panel1.Controls.Add(this.SupplierNameLabel);
            this.panel1.Controls.Add(this.EmailLabel);
            this.panel1.Controls.Add(this.ContactPersonLabel);
            this.panel1.Controls.Add(this.ContactNoLabel);
            this.panel1.Location = new System.Drawing.Point(22, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 225);
            this.panel1.TabIndex = 18;
            // 
            // editCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(495, 297);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SubmitButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "editCustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Customer";
            this.Load += new System.EventHandler(this.editCustomerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox CustomerNameTextBox;
		private System.Windows.Forms.TextBox ContactPersonTextBox;
		private System.Windows.Forms.TextBox ContactNoTextBox;
		private System.Windows.Forms.TextBox EmailTextBox;
		private System.Windows.Forms.Label SupplierNameLabel;
		private System.Windows.Forms.Label ContactPersonLabel;
		private System.Windows.Forms.Label ContactNoLabel;
		private System.Windows.Forms.Label EmailLabel;
		private System.Windows.Forms.ComboBox StatusBox;
		private System.Windows.Forms.Label StatusLabel;
		private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Panel panel1;
    }
}