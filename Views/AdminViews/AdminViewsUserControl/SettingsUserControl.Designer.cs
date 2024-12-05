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
            this.label6 = new System.Windows.Forms.Label();
            this.ShowPassword = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserRole_Account = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Username_Account = new Guna.UI2.WinForms.Guna2TextBox();
            this.Password_Account = new Guna.UI2.WinForms.Guna2TextBox();
            this.CreateAccount = new Guna.UI2.WinForms.Guna2Button();
            this.ChangePassword = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.username_database = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(167, 354);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 25);
            this.label6.TabIndex = 28;
            this.label6.Text = "Password";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShowPassword
            // 
            this.ShowPassword.AutoSize = true;
            this.ShowPassword.Location = new System.Drawing.Point(419, 469);
            this.ShowPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ShowPassword.Name = "ShowPassword";
            this.ShowPassword.Size = new System.Drawing.Size(125, 20);
            this.ShowPassword.TabIndex = 27;
            this.ShowPassword.Text = "Show Password";
            this.ShowPassword.UseVisualStyleBackColor = true;
            this.ShowPassword.CheckedChanged += new System.EventHandler(this.ShowPassword_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(167, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "Username";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 236);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "UserRole";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(167, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Create Account";
            // 
            // UserRole_Account
            // 
            this.UserRole_Account.BackColor = System.Drawing.Color.Transparent;
            this.UserRole_Account.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.UserRole_Account.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UserRole_Account.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserRole_Account.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserRole_Account.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.UserRole_Account.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.UserRole_Account.ItemHeight = 30;
            this.UserRole_Account.Items.AddRange(new object[] {
            "Admin",
            "Staff",
            "Customer"});
            this.UserRole_Account.Location = new System.Drawing.Point(172, 278);
            this.UserRole_Account.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UserRole_Account.Name = "UserRole_Account";
            this.UserRole_Account.Size = new System.Drawing.Size(195, 36);
            this.UserRole_Account.TabIndex = 30;
            // 
            // Username_Account
            // 
            this.Username_Account.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Username_Account.DefaultText = "";
            this.Username_Account.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Username_Account.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Username_Account.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Username_Account.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Username_Account.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Username_Account.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Username_Account.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Username_Account.Location = new System.Drawing.Point(172, 172);
            this.Username_Account.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Username_Account.Name = "Username_Account";
            this.Username_Account.PasswordChar = '\0';
            this.Username_Account.PlaceholderText = "";
            this.Username_Account.SelectedText = "";
            this.Username_Account.Size = new System.Drawing.Size(383, 43);
            this.Username_Account.TabIndex = 31;
            // 
            // Password_Account
            // 
            this.Password_Account.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password_Account.DefaultText = "";
            this.Password_Account.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Password_Account.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Password_Account.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password_Account.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password_Account.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Password_Account.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Password_Account.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Password_Account.Location = new System.Drawing.Point(172, 399);
            this.Password_Account.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Password_Account.Name = "Password_Account";
            this.Password_Account.PasswordChar = '●';
            this.Password_Account.PlaceholderText = "";
            this.Password_Account.SelectedText = "";
            this.Password_Account.Size = new System.Drawing.Size(383, 43);
            this.Password_Account.TabIndex = 32;
            // 
            // CreateAccount
            // 
            this.CreateAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CreateAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CreateAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CreateAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CreateAccount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CreateAccount.ForeColor = System.Drawing.Color.White;
            this.CreateAccount.Location = new System.Drawing.Point(172, 506);
            this.CreateAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CreateAccount.Name = "CreateAccount";
            this.CreateAccount.Size = new System.Drawing.Size(151, 48);
            this.CreateAccount.TabIndex = 33;
            this.CreateAccount.Text = "sign up";
            this.CreateAccount.Click += new System.EventHandler(this.CreateAccount_Click);
            // 
            // ChangePassword
            // 
            this.ChangePassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ChangePassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ChangePassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ChangePassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ChangePassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ChangePassword.ForeColor = System.Drawing.Color.White;
            this.ChangePassword.Location = new System.Drawing.Point(672, 266);
            this.ChangePassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ChangePassword.Name = "ChangePassword";
            this.ChangePassword.Size = new System.Drawing.Size(219, 48);
            this.ChangePassword.TabIndex = 34;
            this.ChangePassword.Text = "Change Passwod";
            this.ChangePassword.Click += new System.EventHandler(this.ChangePassword_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(667, 218);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(265, 25);
            this.label4.TabIndex = 35;
            this.label4.Text = "Password and Authentication";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(670, 129);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 25);
            this.label5.TabIndex = 36;
            this.label5.Text = "Username : ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // username_database
            // 
            this.username_database.AutoSize = true;
            this.username_database.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_database.Location = new System.Drawing.Point(813, 129);
            this.username_database.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.username_database.Name = "username_database";
            this.username_database.Size = new System.Drawing.Size(102, 25);
            this.username_database.TabIndex = 37;
            this.username_database.Text = "Username";
            this.username_database.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.username_database.Click += new System.EventHandler(this.username_database_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(670, 76);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 25);
            this.label8.TabIndex = 38;
            this.label8.Text = "My account";
            // 
            // SettingsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.username_database);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ChangePassword);
            this.Controls.Add(this.CreateAccount);
            this.Controls.Add(this.Password_Account);
            this.Controls.Add(this.Username_Account);
            this.Controls.Add(this.UserRole_Account);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ShowPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SettingsUserControl";
            this.Size = new System.Drawing.Size(2101, 1329);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox ShowPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox UserRole_Account;
        private Guna.UI2.WinForms.Guna2TextBox Username_Account;
        private Guna.UI2.WinForms.Guna2Button CreateAccount;
        private Guna.UI2.WinForms.Guna2TextBox Password_Account;
        private Guna.UI2.WinForms.Guna2Button ChangePassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label username_database;
    }
}
