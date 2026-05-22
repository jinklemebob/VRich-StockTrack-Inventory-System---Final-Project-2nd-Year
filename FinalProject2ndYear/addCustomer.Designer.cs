namespace FinalProject2ndYear
{
	partial class addCustomerForm
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
			this.CustomerNameTextBox = new System.Windows.Forms.MaskedTextBox();
			this.ContactPersonTextBox = new System.Windows.Forms.MaskedTextBox();
			this.ContactNoTextBox = new System.Windows.Forms.MaskedTextBox();
			this.EmailTextBox = new System.Windows.Forms.MaskedTextBox();
			this.SupplierNameLabel = new System.Windows.Forms.Label();
			this.ContactPersonLabel = new System.Windows.Forms.Label();
			this.ContactNoLabel = new System.Windows.Forms.Label();
			this.EmailLabel = new System.Windows.Forms.Label();
			this.SubmitButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// CustomerNameTextBox
			// 
			this.CustomerNameTextBox.Location = new System.Drawing.Point(92, 94);
			this.CustomerNameTextBox.Name = "CustomerNameTextBox";
			this.CustomerNameTextBox.Size = new System.Drawing.Size(189, 22);
			this.CustomerNameTextBox.TabIndex = 0;
			// 
			// ContactPersonTextBox
			// 
			this.ContactPersonTextBox.Location = new System.Drawing.Point(356, 94);
			this.ContactPersonTextBox.Name = "ContactPersonTextBox";
			this.ContactPersonTextBox.Size = new System.Drawing.Size(189, 22);
			this.ContactPersonTextBox.TabIndex = 1;
			// 
			// ContactNoTextBox
			// 
			this.ContactNoTextBox.Location = new System.Drawing.Point(92, 182);
			this.ContactNoTextBox.Name = "ContactNoTextBox";
			this.ContactNoTextBox.Size = new System.Drawing.Size(189, 22);
			this.ContactNoTextBox.TabIndex = 2;
			// 
			// EmailTextBox
			// 
			this.EmailTextBox.Location = new System.Drawing.Point(356, 182);
			this.EmailTextBox.Name = "EmailTextBox";
			this.EmailTextBox.Size = new System.Drawing.Size(189, 22);
			this.EmailTextBox.TabIndex = 3;
			// 
			// SupplierNameLabel
			// 
			this.SupplierNameLabel.AutoSize = true;
			this.SupplierNameLabel.Location = new System.Drawing.Point(89, 75);
			this.SupplierNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.SupplierNameLabel.Name = "SupplierNameLabel";
			this.SupplierNameLabel.Size = new System.Drawing.Size(104, 16);
			this.SupplierNameLabel.TabIndex = 6;
			this.SupplierNameLabel.Text = "Customer Name";
			// 
			// ContactPersonLabel
			// 
			this.ContactPersonLabel.AutoSize = true;
			this.ContactPersonLabel.Location = new System.Drawing.Point(353, 75);
			this.ContactPersonLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.ContactPersonLabel.Name = "ContactPersonLabel";
			this.ContactPersonLabel.Size = new System.Drawing.Size(98, 16);
			this.ContactPersonLabel.TabIndex = 9;
			this.ContactPersonLabel.Text = "Contact Person";
			// 
			// ContactNoLabel
			// 
			this.ContactNoLabel.AutoSize = true;
			this.ContactNoLabel.Location = new System.Drawing.Point(89, 163);
			this.ContactNoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.ContactNoLabel.Name = "ContactNoLabel";
			this.ContactNoLabel.Size = new System.Drawing.Size(76, 16);
			this.ContactNoLabel.TabIndex = 10;
			this.ContactNoLabel.Text = "Contact No.";
			// 
			// EmailLabel
			// 
			this.EmailLabel.AutoSize = true;
			this.EmailLabel.Location = new System.Drawing.Point(353, 163);
			this.EmailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.EmailLabel.Name = "EmailLabel";
			this.EmailLabel.Size = new System.Drawing.Size(41, 16);
			this.EmailLabel.TabIndex = 11;
			this.EmailLabel.Text = "Email";
			// 
			// SubmitButton
			// 
			this.SubmitButton.Location = new System.Drawing.Point(261, 239);
			this.SubmitButton.Margin = new System.Windows.Forms.Padding(4);
			this.SubmitButton.Name = "SubmitButton";
			this.SubmitButton.Size = new System.Drawing.Size(100, 28);
			this.SubmitButton.TabIndex = 12;
			this.SubmitButton.Text = "Done";
			this.SubmitButton.UseVisualStyleBackColor = true;
			// 
			// addCustomerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(621, 316);
			this.Controls.Add(this.SubmitButton);
			this.Controls.Add(this.EmailLabel);
			this.Controls.Add(this.ContactNoLabel);
			this.Controls.Add(this.ContactPersonLabel);
			this.Controls.Add(this.SupplierNameLabel);
			this.Controls.Add(this.EmailTextBox);
			this.Controls.Add(this.ContactNoTextBox);
			this.Controls.Add(this.ContactPersonTextBox);
			this.Controls.Add(this.CustomerNameTextBox);
			this.Name = "addCustomerForm";
			this.Text = "Customer";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MaskedTextBox CustomerNameTextBox;
		private System.Windows.Forms.MaskedTextBox ContactPersonTextBox;
		private System.Windows.Forms.MaskedTextBox ContactNoTextBox;
		private System.Windows.Forms.MaskedTextBox EmailTextBox;
		private System.Windows.Forms.Label SupplierNameLabel;
		private System.Windows.Forms.Label ContactPersonLabel;
		private System.Windows.Forms.Label ContactNoLabel;
		private System.Windows.Forms.Label EmailLabel;
		private System.Windows.Forms.Button SubmitButton;
	}
}