namespace Fastfood_Kiosk_v2.Views.AdminViews.AdminViewsUserControl
{
    partial class SettingsUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ChangePassword = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.username_database = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CreateAccount = new Guna.UI2.WinForms.Guna2Button();
            this.SettingsIndexPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.SettingsIndexPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChangePassword
            // 
            this.ChangePassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ChangePassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ChangePassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ChangePassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ChangePassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ChangePassword.ForeColor = System.Drawing.Color.White;
            this.ChangePassword.Location = new System.Drawing.Point(263, 485);
            this.ChangePassword.Name = "ChangePassword";
            this.ChangePassword.Size = new System.Drawing.Size(164, 39);
            this.ChangePassword.TabIndex = 34;
            this.ChangePassword.Text = "Change Passwod";
            this.ChangePassword.Click += new System.EventHandler(this.ChangePassword_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(259, 446);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Password and Authentication";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(259, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "Username : ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // username_database
            // 
            this.username_database.AutoSize = true;
            this.username_database.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_database.Location = new System.Drawing.Point(367, 175);
            this.username_database.Name = "username_database";
            this.username_database.Size = new System.Drawing.Size(83, 20);
            this.username_database.TabIndex = 37;
            this.username_database.Text = "Username";
            this.username_database.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(259, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 20);
            this.label8.TabIndex = 38;
            this.label8.Text = "My account";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(798, 446);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "Account Creation";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CreateAccount
            // 
            this.CreateAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CreateAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CreateAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CreateAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CreateAccount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CreateAccount.ForeColor = System.Drawing.Color.White;
            this.CreateAccount.Location = new System.Drawing.Point(802, 485);
            this.CreateAccount.Name = "CreateAccount";
            this.CreateAccount.Size = new System.Drawing.Size(164, 39);
            this.CreateAccount.TabIndex = 39;
            this.CreateAccount.Text = "Create Account";
            this.CreateAccount.Click += new System.EventHandler(this.CreateAccount_Click);
            // 
            // SettingsIndexPanel
            // 
            this.SettingsIndexPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(223)))), ((int)(((byte)(206)))));
            this.SettingsIndexPanel.Controls.Add(this.CreateAccount);
            this.SettingsIndexPanel.Controls.Add(this.label1);
            this.SettingsIndexPanel.Controls.Add(this.ChangePassword);
            this.SettingsIndexPanel.Controls.Add(this.label4);
            this.SettingsIndexPanel.Controls.Add(this.label8);
            this.SettingsIndexPanel.Controls.Add(this.label5);
            this.SettingsIndexPanel.Controls.Add(this.username_database);
            this.SettingsIndexPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsIndexPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(223)))), ((int)(((byte)(206)))));
            this.SettingsIndexPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(223)))), ((int)(((byte)(206)))));
            this.SettingsIndexPanel.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(223)))), ((int)(((byte)(206)))));
            this.SettingsIndexPanel.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(223)))), ((int)(((byte)(206)))));
            this.SettingsIndexPanel.Location = new System.Drawing.Point(0, 0);
            this.SettingsIndexPanel.Name = "SettingsIndexPanel";
            this.SettingsIndexPanel.Size = new System.Drawing.Size(1576, 1080);
            this.SettingsIndexPanel.TabIndex = 41;
            // 
            // SettingsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SettingsIndexPanel);
            this.Name = "SettingsUserControl";
            this.Size = new System.Drawing.Size(1576, 1080);
            this.SettingsIndexPanel.ResumeLayout(false);
            this.SettingsIndexPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button ChangePassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label username_database;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button CreateAccount;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel SettingsIndexPanel;
    }
}
