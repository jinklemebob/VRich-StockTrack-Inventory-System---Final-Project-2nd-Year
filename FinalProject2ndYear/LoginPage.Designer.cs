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
            ((System.ComponentModel.ISupportInitialize)(this.SystemLogo)).BeginInit();
            this.LoginPanel.SuspendLayout();
            this.UsernamePanel.SuspendLayout();
            this.PasswordPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SystemLogo
            // 
            this.SystemLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SystemLogo.Image = ((System.Drawing.Image)(resources.GetObject("SystemLogo.Image")));
            this.SystemLogo.Location = new System.Drawing.Point(20, 167);
            this.SystemLogo.Margin = new System.Windows.Forms.Padding(4);
            this.SystemLogo.Name = "SystemLogo";
            this.SystemLogo.Size = new System.Drawing.Size(323, 182);
            this.SystemLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SystemLogo.TabIndex = 5;
            this.SystemLogo.TabStop = false;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.PasswordTextBox.Location = new System.Drawing.Point(8, 13);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(208, 17);
            this.PasswordTextBox.TabIndex = 3;
            this.PasswordTextBox.Text = "Password";
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.GhostWhite;
            this.LoginButton.Location = new System.Drawing.Point(547, 353);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(4);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(103, 45);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "LOGIN";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.UsernameTextBox.Location = new System.Drawing.Point(10, 14);
            this.UsernameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(206, 17);
            this.UsernameTextBox.TabIndex = 2;
            this.UsernameTextBox.Text = "Username";
            this.UsernameTextBox.TextChanged += new System.EventHandler(this.UsernameTextBox_TextChanged);
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.ForeColor = System.Drawing.Color.Black;
            this.LoginLabel.Location = new System.Drawing.Point(543, 148);
            this.LoginLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(100, 32);
            this.LoginLabel.TabIndex = 6;
            this.LoginLabel.Text = "Log-in";
            this.LoginLabel.Click += new System.EventHandler(this.LoginLabel_Click);
            // 
            // LoginPanel
            // 
            this.LoginPanel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LoginPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.LoginPanel.Controls.Add(this.SystemLogo);
            this.LoginPanel.Location = new System.Drawing.Point(13, 13);
            this.LoginPanel.Margin = new System.Windows.Forms.Padding(4);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(360, 505);
            this.LoginPanel.TabIndex = 0;
            this.LoginPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LoginPanel_Paint);
            // 
            // UsernamePanel
            // 
            this.UsernamePanel.BackColor = System.Drawing.SystemColors.Window;
            this.UsernamePanel.Controls.Add(this.UsernameTextBox);
            this.UsernamePanel.Location = new System.Drawing.Point(485, 201);
            this.UsernamePanel.Name = "UsernamePanel";
            this.UsernamePanel.Size = new System.Drawing.Size(220, 45);
            this.UsernamePanel.TabIndex = 7;
            // 
            // PasswordPanel
            // 
            this.PasswordPanel.BackColor = System.Drawing.SystemColors.Window;
            this.PasswordPanel.Controls.Add(this.PasswordTextBox);
            this.PasswordPanel.Location = new System.Drawing.Point(485, 260);
            this.PasswordPanel.Name = "PasswordPanel";
            this.PasswordPanel.Size = new System.Drawing.Size(220, 45);
            this.PasswordPanel.TabIndex = 8;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(804, 531);
            this.Controls.Add(this.PasswordPanel);
            this.Controls.Add(this.UsernamePanel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.LoginButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vitarich StockTrack";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SystemLogo)).EndInit();
            this.LoginPanel.ResumeLayout(false);
            this.UsernamePanel.ResumeLayout(false);
            this.UsernamePanel.PerformLayout();
            this.PasswordPanel.ResumeLayout(false);
            this.PasswordPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

