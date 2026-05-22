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
			this.SuspendLayout();
			// 
			// CustomerNameTextBox
			// 
			this.CustomerNameTextBox.Location = new System.Drawing.Point(87, 105);
			this.CustomerNameTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.CustomerNameTextBox.Name = "CustomerNameTextBox";
			this.CustomerNameTextBox.Size = new System.Drawing.Size(192, 22);
			this.CustomerNameTextBox.TabIndex = 1;
			// 
			// ContactPersonTextBox
			// 
			this.ContactPersonTextBox.Location = new System.Drawing.Point(401, 105);
			this.ContactPersonTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.ContactPersonTextBox.Name = "ContactPersonTextBox";
			this.ContactPersonTextBox.Size = new System.Drawing.Size(192, 22);
			this.ContactPersonTextBox.TabIndex = 2;
			// 
			// ContactNoTextBox
			// 
			this.ContactNoTextBox.Location = new System.Drawing.Point(87, 182);
			this.ContactNoTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.ContactNoTextBox.Name = "ContactNoTextBox";
			this.ContactNoTextBox.Size = new System.Drawing.Size(192, 22);
			this.ContactNoTextBox.TabIndex = 3;
			// 
			// EmailTextBox
			// 
			this.EmailTextBox.Location = new System.Drawing.Point(401, 182);
			this.EmailTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.EmailTextBox.Name = "EmailTextBox";
			this.EmailTextBox.Size = new System.Drawing.Size(192, 22);
			this.EmailTextBox.TabIndex = 4;
			// 
			// SupplierNameLabel
			// 
			this.SupplierNameLabel.AutoSize = true;
			this.SupplierNameLabel.Location = new System.Drawing.Point(84, 85);
			this.SupplierNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.SupplierNameLabel.Name = "SupplierNameLabel";
			this.SupplierNameLabel.Size = new System.Drawing.Size(104, 16);
			this.SupplierNameLabel.TabIndex = 7;
			this.SupplierNameLabel.Text = "Customer Name";
			// 
			// ContactPersonLabel
			// 
			this.ContactPersonLabel.AutoSize = true;
			this.ContactPersonLabel.Location = new System.Drawing.Point(398, 85);
			this.ContactPersonLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.ContactPersonLabel.Name = "ContactPersonLabel";
			this.ContactPersonLabel.Size = new System.Drawing.Size(98, 16);
			this.ContactPersonLabel.TabIndex = 10;
			this.ContactPersonLabel.Text = "Contact Person";
			// 
			// ContactNoLabel
			// 
			this.ContactNoLabel.AutoSize = true;
			this.ContactNoLabel.Location = new System.Drawing.Point(84, 162);
			this.ContactNoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.ContactNoLabel.Name = "ContactNoLabel";
			this.ContactNoLabel.Size = new System.Drawing.Size(76, 16);
			this.ContactNoLabel.TabIndex = 11;
			this.ContactNoLabel.Text = "Contact No.";
			// 
			// EmailLabel
			// 
			this.EmailLabel.AutoSize = true;
			this.EmailLabel.Location = new System.Drawing.Point(398, 162);
			this.EmailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.EmailLabel.Name = "EmailLabel";
			this.EmailLabel.Size = new System.Drawing.Size(41, 16);
			this.EmailLabel.TabIndex = 12;
			this.EmailLabel.Text = "Email";
			// 
			// StatusBox
			// 
			this.StatusBox.FormattingEnabled = true;
			this.StatusBox.Location = new System.Drawing.Point(264, 248);
			this.StatusBox.Margin = new System.Windows.Forms.Padding(4);
			this.StatusBox.Name = "StatusBox";
			this.StatusBox.Size = new System.Drawing.Size(160, 24);
			this.StatusBox.TabIndex = 14;
			// 
			// StatusLabel
			// 
			this.StatusLabel.AutoSize = true;
			this.StatusLabel.Location = new System.Drawing.Point(261, 228);
			this.StatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.StatusLabel.Name = "StatusLabel";
			this.StatusLabel.Size = new System.Drawing.Size(44, 16);
			this.StatusLabel.TabIndex = 15;
			this.StatusLabel.Text = "Status";
			// 
			// SubmitButton
			// 
			this.SubmitButton.Location = new System.Drawing.Point(296, 289);
			this.SubmitButton.Margin = new System.Windows.Forms.Padding(4);
			this.SubmitButton.Name = "SubmitButton";
			this.SubmitButton.Size = new System.Drawing.Size(100, 38);
			this.SubmitButton.TabIndex = 16;
			this.SubmitButton.Text = "Done";
			this.SubmitButton.UseVisualStyleBackColor = true;
			// 
			// editCustomer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(694, 352);
			this.Controls.Add(this.SubmitButton);
			this.Controls.Add(this.StatusLabel);
			this.Controls.Add(this.StatusBox);
			this.Controls.Add(this.EmailLabel);
			this.Controls.Add(this.ContactNoLabel);
			this.Controls.Add(this.ContactPersonLabel);
			this.Controls.Add(this.SupplierNameLabel);
			this.Controls.Add(this.EmailTextBox);
			this.Controls.Add(this.ContactNoTextBox);
			this.Controls.Add(this.ContactPersonTextBox);
			this.Controls.Add(this.CustomerNameTextBox);
			this.Name = "editCustomer";
			this.Text = "editCustomer";
			this.ResumeLayout(false);
			this.PerformLayout();

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
	}
}