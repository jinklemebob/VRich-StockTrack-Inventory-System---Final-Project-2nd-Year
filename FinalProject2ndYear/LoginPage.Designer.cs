namespace FinalProject2ndYear
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.SystemLogo = new System.Windows.Forms.PictureBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.UsernamePanel = new System.Windows.Forms.Panel();
            this.PasswordPanel = new System.Windows.Forms.Panel();
            this.LoginFormPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.SystemLogo)).BeginInit();
            this.LoginPanel.SuspendLayout();
            this.UsernamePanel.SuspendLayout();
            this.PasswordPanel.SuspendLayout();
            this.LoginFormPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SystemLogo
            // 
            this.SystemLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SystemLogo.Image = ((System.Drawing.Image)(resources.GetObject("SystemLogo.Image")));
            this.SystemLogo.Location = new System.Drawing.Point(-112, 32);
            this.SystemLogo.Name = "SystemLogo";
            this.SystemLogo.Size = new System.Drawing.Size(493, 328);
            this.SystemLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SystemLogo.TabIndex = 5;
            this.SystemLogo.TabStop = false;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTextBox.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.PasswordTextBox.Location = new System.Drawing.Point(6, 11);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(156, 14);
            this.PasswordTextBox.TabIndex = 3;
            this.PasswordTextBox.Text = "Password...";
            this.PasswordTextBox.Click += new System.EventHandler(this.PasswordTextBox_Click);
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged_1);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.GhostWhite;
            this.LoginButton.Location = new System.Drawing.Point(44, 156);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(165, 37);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "LOGIN";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.UsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsernameTextBox.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.UsernameTextBox.Location = new System.Drawing.Point(8, 11);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(154, 14);
            this.UsernameTextBox.TabIndex = 2;
            this.UsernameTextBox.Text = "Username...";
            this.UsernameTextBox.Click += new System.EventHandler(this.UsernameTextBox_Click);
            this.UsernameTextBox.TextChanged += new System.EventHandler(this.UsernameTextBox_TextChanged_1);
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Trebuchet MS", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.LoginLabel.Location = new System.Drawing.Point(3, 13);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(257, 28);
            this.LoginLabel.TabIndex = 6;
            this.LoginLabel.Text = "Login to your account.";
            this.LoginLabel.Click += new System.EventHandler(this.LoginLabel_Click);
            // 
            // LoginPanel
            // 
            this.LoginPanel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LoginPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.LoginPanel.Controls.Add(this.SystemLogo);
            this.LoginPanel.Location = new System.Drawing.Point(10, 11);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(270, 410);
            this.LoginPanel.TabIndex = 0;
            this.LoginPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LoginPanel_Paint);
            // 
            // UsernamePanel
            // 
            this.UsernamePanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.UsernamePanel.Controls.Add(this.UsernameTextBox);
            this.UsernamePanel.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernamePanel.Location = new System.Drawing.Point(44, 61);
            this.UsernamePanel.Margin = new System.Windows.Forms.Padding(2);
            this.UsernamePanel.Name = "UsernamePanel";
            this.UsernamePanel.Size = new System.Drawing.Size(165, 37);
            this.UsernamePanel.TabIndex = 7;
            this.UsernamePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.UsernamePanel_Paint);
            // 
            // PasswordPanel
            // 
            this.PasswordPanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.PasswordPanel.Controls.Add(this.PasswordTextBox);
            this.PasswordPanel.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordPanel.Location = new System.Drawing.Point(44, 109);
            this.PasswordPanel.Margin = new System.Windows.Forms.Padding(2);
            this.PasswordPanel.Name = "PasswordPanel";
            this.PasswordPanel.Size = new System.Drawing.Size(165, 37);
            this.PasswordPanel.TabIndex = 8;
            this.PasswordPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PasswordPanel_Paint);
            // 
            // LoginFormPanel
            // 
            this.LoginFormPanel.Controls.Add(this.PasswordPanel);
            this.LoginFormPanel.Controls.Add(this.LoginLabel);
            this.LoginFormPanel.Controls.Add(this.LoginButton);
            this.LoginFormPanel.Controls.Add(this.UsernamePanel);
            this.LoginFormPanel.Location = new System.Drawing.Point(309, 106);
            this.LoginFormPanel.Name = "LoginFormPanel";
            this.LoginFormPanel.Size = new System.Drawing.Size(259, 208);
            this.LoginFormPanel.TabIndex = 9;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(603, 431);
            this.Controls.Add(this.LoginFormPanel);
            this.Controls.Add(this.LoginPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VRich StockTrack";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SystemLogo)).EndInit();
            this.LoginPanel.ResumeLayout(false);
            this.UsernamePanel.ResumeLayout(false);
            this.UsernamePanel.PerformLayout();
            this.PasswordPanel.ResumeLayout(false);
            this.PasswordPanel.PerformLayout();
            this.LoginFormPanel.ResumeLayout(false);
            this.LoginFormPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox SystemLogo;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Panel UsernamePanel;
        private System.Windows.Forms.Panel PasswordPanel;
        private System.Windows.Forms.Panel LoginFormPanel;
    }
}

