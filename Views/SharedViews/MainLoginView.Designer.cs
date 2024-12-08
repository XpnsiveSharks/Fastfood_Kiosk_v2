namespace Fastfood_Kiosk_v2.Views.SharedViews
{
    partial class MainLoginView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainLoginView));
            this.AdminLoginButton = new Guna.UI2.WinForms.Guna2TileButton();
            this.CustomerLoginButton = new Guna.UI2.WinForms.Guna2TileButton();
            this.LoginAsLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LoginPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminLoginButton
            // 
            this.AdminLoginButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.AdminLoginButton.BorderRadius = 20;
            this.AdminLoginButton.BorderThickness = 2;
            this.AdminLoginButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AdminLoginButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AdminLoginButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AdminLoginButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AdminLoginButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.AdminLoginButton.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminLoginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.AdminLoginButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.AdminLoginButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.AdminLoginButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.AdminLoginButton.Location = new System.Drawing.Point(132, 278);
            this.AdminLoginButton.Margin = new System.Windows.Forms.Padding(2);
            this.AdminLoginButton.Name = "AdminLoginButton";
            this.AdminLoginButton.Size = new System.Drawing.Size(307, 52);
            this.AdminLoginButton.TabIndex = 0;
            this.AdminLoginButton.Text = "Admin";
            this.AdminLoginButton.Click += new System.EventHandler(this.AdminLoginButton_Click);
            // 
            // CustomerLoginButton
            // 
            this.CustomerLoginButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.CustomerLoginButton.BorderRadius = 20;
            this.CustomerLoginButton.BorderThickness = 2;
            this.CustomerLoginButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CustomerLoginButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CustomerLoginButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CustomerLoginButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CustomerLoginButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.CustomerLoginButton.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerLoginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.CustomerLoginButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.CustomerLoginButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.CustomerLoginButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.CustomerLoginButton.Location = new System.Drawing.Point(132, 350);
            this.CustomerLoginButton.Margin = new System.Windows.Forms.Padding(2);
            this.CustomerLoginButton.Name = "CustomerLoginButton";
            this.CustomerLoginButton.Size = new System.Drawing.Size(307, 52);
            this.CustomerLoginButton.TabIndex = 2;
            this.CustomerLoginButton.Text = "Customer";
            this.CustomerLoginButton.Click += new System.EventHandler(this.CustomerLoginButton_Click);
            // 
            // LoginAsLabel
            // 
            this.LoginAsLabel.AutoSize = false;
            this.LoginAsLabel.BackColor = System.Drawing.Color.Transparent;
            this.LoginAsLabel.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginAsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.LoginAsLabel.Location = new System.Drawing.Point(121, 220);
            this.LoginAsLabel.Margin = new System.Windows.Forms.Padding(2);
            this.LoginAsLabel.Name = "LoginAsLabel";
            this.LoginAsLabel.Size = new System.Drawing.Size(327, 55);
            this.LoginAsLabel.TabIndex = 3;
            this.LoginAsLabel.Text = "Login as:";
            this.LoginAsLabel.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LoginPanel
            // 
            this.LoginPanel.Controls.Add(this.LoginAsLabel);
            this.LoginPanel.Controls.Add(this.CustomerLoginButton);
            this.LoginPanel.Controls.Add(this.AdminLoginButton);
            this.LoginPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.LoginPanel.Location = new System.Drawing.Point(719, 0);
            this.LoginPanel.Margin = new System.Windows.Forms.Padding(2);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(561, 702);
            this.LoginPanel.TabIndex = 4;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(719, 702);
            this.guna2PictureBox1.TabIndex = 5;
            this.guna2PictureBox1.TabStop = false;
            // 
            // MainLoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1280, 702);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.LoginPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainLoginView";
            this.Text = "MainLogin";
            this.LoginPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TileButton AdminLoginButton;
        private Guna.UI2.WinForms.Guna2TileButton CustomerLoginButton;
        private Guna.UI2.WinForms.Guna2HtmlLabel LoginAsLabel;
        private Guna.UI2.WinForms.Guna2Panel LoginPanel;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}