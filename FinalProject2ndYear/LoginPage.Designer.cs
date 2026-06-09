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
            this.LoginFormPanel = new System.Windows.Forms.Panel();
            this.Line = new System.Windows.Forms.Panel();
            this.PasswordPanel = new System.Windows.Forms.Panel();
            this.UsernamePanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SystemLogo)).BeginInit();
            this.LoginPanel.SuspendLayout();
            this.LoginFormPanel.SuspendLayout();
            this.PasswordPanel.SuspendLayout();
            this.UsernamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // SystemLogo
            // 
            this.SystemLogo.BackColor = System.Drawing.Color.Transparent;
            this.SystemLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SystemLogo.Image = ((System.Drawing.Image)(resources.GetObject("SystemLogo.Image")));
            this.SystemLogo.Location = new System.Drawing.Point(-56, 52);
            this.SystemLogo.Name = "SystemLogo";
            this.SystemLogo.Size = new System.Drawing.Size(370, 254);
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
            this.LoginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.GhostWhite;
            this.LoginButton.Location = new System.Drawing.Point(29, 206);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(208, 37);
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
            this.LoginLabel.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.LoginLabel.Location = new System.Drawing.Point(28, 41);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(223, 26);
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
            this.LoginPanel.Location = new System.Drawing.Point(9, -1);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(584, 411);
            this.LoginPanel.TabIndex = 0;
            this.LoginPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LoginPanel_Paint);
            // 
            // LoginFormPanel
            // 
            this.LoginFormPanel.BackColor = System.Drawing.Color.GhostWhite;
            this.LoginFormPanel.Controls.Add(this.Line);
            this.LoginFormPanel.Controls.Add(this.PasswordPanel);
            this.LoginFormPanel.Controls.Add(this.LoginLabel);
            this.LoginFormPanel.Controls.Add(this.LoginButton);
            this.LoginFormPanel.Controls.Add(this.UsernamePanel);
            this.LoginFormPanel.Location = new System.Drawing.Point(257, 54);
            this.LoginFormPanel.Name = "LoginFormPanel";
            this.LoginFormPanel.Size = new System.Drawing.Size(264, 288);
            this.LoginFormPanel.TabIndex = 9;
            // 
            // Line
            // 
            this.Line.BackColor = System.Drawing.Color.DodgerBlue;
            this.Line.Location = new System.Drawing.Point(99, 81);
            this.Line.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(59, 8);
            this.Line.TabIndex = 9;
            // 
            // PasswordPanel
            // 
            this.PasswordPanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.PasswordPanel.Controls.Add(this.PasswordTextBox);
            this.PasswordPanel.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordPanel.Location = new System.Drawing.Point(29, 159);
            this.PasswordPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PasswordPanel.Name = "PasswordPanel";
            this.PasswordPanel.Size = new System.Drawing.Size(208, 37);
            this.PasswordPanel.TabIndex = 8;
            // 
            // UsernamePanel
            // 
            this.UsernamePanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.UsernamePanel.Controls.Add(this.UsernameTextBox);
            this.UsernamePanel.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernamePanel.Location = new System.Drawing.Point(29, 111);
            this.UsernamePanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UsernamePanel.Name = "UsernamePanel";
            this.UsernamePanel.Size = new System.Drawing.Size(208, 37);
            this.UsernamePanel.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(10, 228);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(341, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(272, 152);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(341, 181);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(601, 417);
            this.Controls.Add(this.LoginPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VRich StockTrack";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginPage_FormClosing);
            this.Load += new System.EventHandler(this.LoginPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SystemLogo)).EndInit();
            this.LoginPanel.ResumeLayout(false);
            this.LoginFormPanel.ResumeLayout(false);
            this.LoginFormPanel.PerformLayout();
            this.PasswordPanel.ResumeLayout(false);
            this.PasswordPanel.PerformLayout();
            this.UsernamePanel.ResumeLayout(false);
            this.UsernamePanel.PerformLayout();
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

