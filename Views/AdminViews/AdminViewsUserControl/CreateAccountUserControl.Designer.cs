﻿namespace Fastfood_Kiosk_v2.Views.AdminViews.AdminViewsUserControl
{
    partial class CreateAccountUserControl
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
            Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
            this.CreateUserRole = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CreatePassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.CreateUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.ShowPassword = new Guna.UI2.WinForms.Guna2CheckBox();
            this.BackButton = new Guna.UI2.WinForms.Guna2TileButton();
            this.CreateAccountButton = new Guna.UI2.WinForms.Guna2TileButton();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            guna2HtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            guna2HtmlLabel1.Location = new System.Drawing.Point(241, 104);
            guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new System.Drawing.Size(234, 38);
            guna2HtmlLabel1.TabIndex = 0;
            guna2HtmlLabel1.Text = "CREATE ACOUNT";
            // 
            // CreateUserRole
            // 
            this.CreateUserRole.BackColor = System.Drawing.Color.Transparent;
            this.CreateUserRole.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.CreateUserRole.BorderRadius = 10;
            this.CreateUserRole.BorderThickness = 2;
            this.CreateUserRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CreateUserRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CreateUserRole.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CreateUserRole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CreateUserRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CreateUserRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CreateUserRole.ItemHeight = 30;
            this.CreateUserRole.Items.AddRange(new object[] {
            "Admin",
            "Customer"});
            this.CreateUserRole.Location = new System.Drawing.Point(282, 276);
            this.CreateUserRole.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CreateUserRole.Name = "CreateUserRole";
            this.CreateUserRole.Size = new System.Drawing.Size(267, 36);
            this.CreateUserRole.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.label1.Location = new System.Drawing.Point(366, 237);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "UserRole";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CreatePassword
            // 
            this.CreatePassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.CreatePassword.BorderRadius = 20;
            this.CreatePassword.BorderThickness = 2;
            this.CreatePassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CreatePassword.DefaultText = "";
            this.CreatePassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CreatePassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CreatePassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CreatePassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CreatePassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.CreatePassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CreatePassword.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.CreatePassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.CreatePassword.Location = new System.Drawing.Point(128, 470);
            this.CreatePassword.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.CreatePassword.Name = "CreatePassword";
            this.CreatePassword.PasswordChar = '●';
            this.CreatePassword.PlaceholderText = "Password";
            this.CreatePassword.SelectedText = "";
            this.CreatePassword.Size = new System.Drawing.Size(551, 72);
            this.CreatePassword.TabIndex = 37;
            this.CreatePassword.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // CreateUsername
            // 
            this.CreateUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.CreateUsername.BorderRadius = 20;
            this.CreateUsername.BorderThickness = 2;
            this.CreateUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CreateUsername.DefaultText = "";
            this.CreateUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CreateUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CreateUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CreateUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CreateUsername.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.CreateUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CreateUsername.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.CreateUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CreateUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.CreateUsername.Location = new System.Drawing.Point(127, 376);
            this.CreateUsername.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.CreateUsername.Name = "CreateUsername";
            this.CreateUsername.PasswordChar = '\0';
            this.CreateUsername.PlaceholderText = "Username";
            this.CreateUsername.SelectedText = "";
            this.CreateUsername.Size = new System.Drawing.Size(551, 72);
            this.CreateUsername.TabIndex = 38;
            this.CreateUsername.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // ShowPassword
            // 
            this.ShowPassword.AutoSize = true;
            this.ShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.ShowPassword.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ShowPassword.CheckedState.BorderRadius = 0;
            this.ShowPassword.CheckedState.BorderThickness = 0;
            this.ShowPassword.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ShowPassword.CheckMarkColor = System.Drawing.Color.Black;
            this.ShowPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.ShowPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ShowPassword.Location = new System.Drawing.Point(511, 561);
            this.ShowPassword.Name = "ShowPassword";
            this.ShowPassword.Size = new System.Drawing.Size(102, 17);
            this.ShowPassword.TabIndex = 41;
            this.ShowPassword.Text = "Show Password";
            this.ShowPassword.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ShowPassword.UncheckedState.BorderRadius = 0;
            this.ShowPassword.UncheckedState.BorderThickness = 0;
            this.ShowPassword.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ShowPassword.UseVisualStyleBackColor = false;
            this.ShowPassword.CheckedChanged += new System.EventHandler(this.ShowPassword_CheckedChanged);
            // 
            // BackButton
            // 
            this.BackButton.BorderColor = System.Drawing.Color.Transparent;
            this.BackButton.BorderRadius = 20;
            this.BackButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BackButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BackButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BackButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BackButton.FillColor = System.Drawing.Color.Transparent;
            this.BackButton.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.BackButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.BackButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.BackButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.BackButton.Location = new System.Drawing.Point(318, 897);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(196, 34);
            this.BackButton.TabIndex = 40;
            this.BackButton.Text = "back";
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // CreateAccountButton
            // 
            this.CreateAccountButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.CreateAccountButton.BorderRadius = 20;
            this.CreateAccountButton.BorderThickness = 2;
            this.CreateAccountButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CreateAccountButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CreateAccountButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CreateAccountButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CreateAccountButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.CreateAccountButton.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateAccountButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.CreateAccountButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.CreateAccountButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.CreateAccountButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.CreateAccountButton.Location = new System.Drawing.Point(140, 793);
            this.CreateAccountButton.Name = "CreateAccountButton";
            this.CreateAccountButton.Size = new System.Drawing.Size(551, 84);
            this.CreateAccountButton.TabIndex = 39;
            this.CreateAccountButton.Text = "Create Account";
            this.CreateAccountButton.Click += new System.EventHandler(this.CreateAccountButton_Click);
            // 
            // CreateAccountUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(223)))), ((int)(((byte)(206)))));
            this.Controls.Add(this.ShowPassword);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CreateAccountButton);
            this.Controls.Add(this.CreateUsername);
            this.Controls.Add(this.CreatePassword);
            this.Controls.Add(this.CreateUserRole);
            this.Controls.Add(this.label1);
            this.Controls.Add(guna2HtmlLabel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CreateAccountUserControl";
            this.Size = new System.Drawing.Size(804, 1055);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox CreateUserRole;
        private Guna.UI2.WinForms.Guna2TextBox CreatePassword;
        private Guna.UI2.WinForms.Guna2TextBox CreateUsername;
        private Guna.UI2.WinForms.Guna2CheckBox ShowPassword;
        private Guna.UI2.WinForms.Guna2TileButton BackButton;
        private Guna.UI2.WinForms.Guna2TileButton CreateAccountButton;
        private System.Windows.Forms.Label label1;
    }
}
