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
            this.DineInButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(223)))), ((int)(((byte)(206)))));
            this.DineInButton.BorderRadius = 20;
            this.DineInButton.BorderThickness = 2;
            this.DineInButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DineInButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DineInButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DineInButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DineInButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(223)))), ((int)(((byte)(206)))));
            this.DineInButton.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DineInButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.DineInButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.DineInButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(223)))), ((int)(((byte)(206)))));
            this.DineInButton.Location = new System.Drawing.Point(505, 347);
            this.DineInButton.Name = "DineInButton";
            this.DineInButton.Size = new System.Drawing.Size(333, 244);
            this.DineInButton.TabIndex = 0;
            this.DineInButton.Text = "Dine-in";
            this.DineInButton.Click += new System.EventHandler(this.DineInButton_Click);
            // 
            // TakeOutButton
            // 
            this.TakeOutButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(223)))), ((int)(((byte)(206)))));
            this.TakeOutButton.BorderRadius = 20;
            this.TakeOutButton.BorderThickness = 2;
            this.TakeOutButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.TakeOutButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.TakeOutButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.TakeOutButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.TakeOutButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(223)))), ((int)(((byte)(206)))));
            this.TakeOutButton.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TakeOutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.TakeOutButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.TakeOutButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(223)))), ((int)(((byte)(206)))));
            this.TakeOutButton.Location = new System.Drawing.Point(1030, 347);
            this.TakeOutButton.Name = "TakeOutButton";
            this.TakeOutButton.Size = new System.Drawing.Size(333, 244);
            this.TakeOutButton.TabIndex = 2;
            this.TakeOutButton.Text = "Take-out";
            this.TakeOutButton.Click += new System.EventHandler(this.TakeOutButton_Click);
            // 
            // OrderTypeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.Controls.Add(this.TakeOutButton);
            this.Controls.Add(this.DineInButton);
            this.Name = "OrderTypeUserControl";
            this.Size = new System.Drawing.Size(1920, 1080);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TileButton DineInButton;
        private Guna.UI2.WinForms.Guna2TileButton TakeOutButton;
    }
}
