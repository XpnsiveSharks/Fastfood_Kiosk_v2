namespace Fastfood_Kiosk_v2.Views.Customer.CustomerUserControls
{
    partial class OrderTypeUserControl
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
            this.DineInButton = new Guna.UI2.WinForms.Guna2TileButton();
            this.TakeOutButton = new Guna.UI2.WinForms.Guna2TileButton();
            this.SuspendLayout();
            // 
            // DineInButton
            // 
            this.DineInButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DineInButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DineInButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DineInButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DineInButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DineInButton.ForeColor = System.Drawing.Color.White;
            this.DineInButton.Location = new System.Drawing.Point(364, 267);
            this.DineInButton.Name = "DineInButton";
            this.DineInButton.Size = new System.Drawing.Size(180, 180);
            this.DineInButton.TabIndex = 0;
            this.DineInButton.Text = "Dine-in";
            this.DineInButton.Click += new System.EventHandler(this.DineInButton_Click);
            // 
            // TakeOutButton
            // 
            this.TakeOutButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.TakeOutButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.TakeOutButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.TakeOutButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.TakeOutButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TakeOutButton.ForeColor = System.Drawing.Color.White;
            this.TakeOutButton.Location = new System.Drawing.Point(712, 267);
            this.TakeOutButton.Name = "TakeOutButton";
            this.TakeOutButton.Size = new System.Drawing.Size(180, 180);
            this.TakeOutButton.TabIndex = 1;
            this.TakeOutButton.Text = "Take out";
            this.TakeOutButton.Click += new System.EventHandler(this.TakeOutButton_Click);
            // 
            // OrderTypeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TakeOutButton);
            this.Controls.Add(this.DineInButton);
            this.Name = "OrderTypeUserControl";
            this.Size = new System.Drawing.Size(1335, 758);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TileButton DineInButton;
        private Guna.UI2.WinForms.Guna2TileButton TakeOutButton;
    }
}
