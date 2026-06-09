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
            this.components = new System.ComponentModel.Container();
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
            this.Line = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SystemLogo)).BeginInit();
            this.LoginPanel.SuspendLayout();
            this.UsernamePanel.SuspendLayout();
            this.PasswordPanel.SuspendLayout();
            this.LoginFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // SystemLogo
            // 
            this.SystemLogo.BackColor = System.Drawing.Color.Transparent;
            this.SystemLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SystemLogo.Image = ((System.Drawing.Image)(resources.GetObject("SystemLogo.Image")));
            this.SystemLogo.Location = new System.Drawing.Point(61, 109);
            this.SystemLogo.Margin = new System.Windows.Forms.Padding(4);
            this.SystemLogo.Name = "SystemLogo";
            this.SystemLogo.Size = new System.Drawing.Size(242, 275);
            this.SystemLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.SystemLogo.TabIndex = 5;
            this.SystemLogo.TabStop = false;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTextBox.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.PasswordTextBox.Location = new System.Drawing.Point(8, 14);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(208, 18);
            this.PasswordTextBox.TabIndex = 3;
            this.PasswordTextBox.Text = "Password...";
            this.PasswordTextBox.Click += new System.EventHandler(this.PasswordTextBox_Click);
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged_1);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.GhostWhite;
            this.LoginButton.Location = new System.Drawing.Point(39, 254);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(4);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(278, 46);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.UsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsernameTextBox.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.UsernameTextBox.Location = new System.Drawing.Point(11, 14);
            this.UsernameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(205, 18);
            this.UsernameTextBox.TabIndex = 2;
            this.UsernameTextBox.Text = "Username...";
            this.UsernameTextBox.Click += new System.EventHandler(this.UsernameTextBox_Click);
            this.UsernameTextBox.TextChanged += new System.EventHandler(this.UsernameTextBox_TextChanged_1);
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.LoginLabel.Location = new System.Drawing.Point(37, 50);
            this.LoginLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(280, 32);
            this.LoginLabel.TabIndex = 6;
            this.LoginLabel.Text = "Login to your account.";
            // 
            // LoginPanel
            // 
            this.LoginPanel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LoginPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.LoginPanel.Controls.Add(this.LoginFormPanel);
            this.LoginPanel.Controls.Add(this.SystemLogo);
            this.LoginPanel.Controls.Add(this.pictureBox1);
            this.LoginPanel.Controls.Add(this.pictureBox2);
            this.LoginPanel.Location = new System.Drawing.Point(13, 13);
            this.LoginPanel.Margin = new System.Windows.Forms.Padding(4);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(778, 506);
            this.LoginPanel.TabIndex = 0;
            this.LoginPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LoginPanel_Paint);
            // 
            // UsernamePanel
            // 
            this.UsernamePanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.UsernamePanel.Controls.Add(this.UsernameTextBox);
            this.UsernamePanel.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernamePanel.Location = new System.Drawing.Point(39, 137);
            this.UsernamePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UsernamePanel.Name = "UsernamePanel";
            this.UsernamePanel.Size = new System.Drawing.Size(278, 46);
            this.UsernamePanel.TabIndex = 7;
            // 
            // PasswordPanel
            // 
            this.PasswordPanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.PasswordPanel.Controls.Add(this.PasswordTextBox);
            this.PasswordPanel.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordPanel.Location = new System.Drawing.Point(39, 196);
            this.PasswordPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PasswordPanel.Name = "PasswordPanel";
            this.PasswordPanel.Size = new System.Drawing.Size(278, 46);
            this.PasswordPanel.TabIndex = 8;
            // 
            // LoginFormPanel
            // 
            this.LoginFormPanel.BackColor = System.Drawing.Color.GhostWhite;
            this.LoginFormPanel.Controls.Add(this.Line);
            this.LoginFormPanel.Controls.Add(this.PasswordPanel);
            this.LoginFormPanel.Controls.Add(this.LoginLabel);
            this.LoginFormPanel.Controls.Add(this.LoginButton);
            this.LoginFormPanel.Controls.Add(this.UsernamePanel);
            this.LoginFormPanel.Location = new System.Drawing.Point(388, 77);
            this.LoginFormPanel.Margin = new System.Windows.Forms.Padding(4);
            this.LoginFormPanel.Name = "LoginFormPanel";
            this.LoginFormPanel.Size = new System.Drawing.Size(352, 354);
            this.LoginFormPanel.TabIndex = 9;
            // 
            // Line
            // 
            this.Line.BackColor = System.Drawing.Color.DodgerBlue;
            this.Line.Location = new System.Drawing.Point(132, 100);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(79, 10);
            this.Line.TabIndex = 9;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(13, 280);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(455, 223);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(362, 187);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(455, 223);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(804, 530);
            this.Controls.Add(this.LoginPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VRich StockTrack";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginPage_FormClosing);
            this.Load += new System.EventHandler(this.LoginPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SystemLogo)).EndInit();
            this.LoginPanel.ResumeLayout(false);
            this.UsernamePanel.ResumeLayout(false);
            this.UsernamePanel.PerformLayout();
            this.PasswordPanel.ResumeLayout(false);
            this.PasswordPanel.PerformLayout();
            this.LoginFormPanel.ResumeLayout(false);
            this.LoginFormPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox SystemLogo;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Panel UsernamePanel;
        private System.Windows.Forms.Panel PasswordPanel;
        public System.Windows.Forms.TextBox PasswordTextBox;
        public System.Windows.Forms.Button LoginButton;
        public System.Windows.Forms.TextBox UsernameTextBox;
        public System.Windows.Forms.Panel LoginFormPanel;
        private System.Windows.Forms.Panel Line;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

