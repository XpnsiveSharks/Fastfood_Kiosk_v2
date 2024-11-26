namespace Fastfood_Kiosk_v2.Views.Customer.CustomerOrderingComponentsUserControls
{
    partial class ItemUserControl
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
            this.ProductLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.RemoveItemButton = new Guna.UI2.WinForms.Guna2TileButton();
            this.SuspendLayout();
            // 
            // ProductLabel
            // 
            this.ProductLabel.AutoSize = true;
            this.ProductLabel.Location = new System.Drawing.Point(3, 22);
            this.ProductLabel.Name = "ProductLabel";
            this.ProductLabel.Size = new System.Drawing.Size(30, 13);
            this.ProductLabel.TabIndex = 1;
            this.ProductLabel.Text = "Meal";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(3, 52);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(47, 13);
            this.PriceLabel.TabIndex = 2;
            this.PriceLabel.Text = "P000.00";
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Location = new System.Drawing.Point(158, 38);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(13, 13);
            this.QuantityLabel.TabIndex = 3;
            this.QuantityLabel.Text = "2";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(204, 38);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(47, 13);
            this.TotalLabel.TabIndex = 4;
            this.TotalLabel.Text = "P000.00";
            // 
            // RemoveItemButton
            // 
            this.RemoveItemButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RemoveItemButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RemoveItemButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RemoveItemButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RemoveItemButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RemoveItemButton.ForeColor = System.Drawing.Color.White;
            this.RemoveItemButton.Location = new System.Drawing.Point(278, 24);
            this.RemoveItemButton.Name = "RemoveItemButton";
            this.RemoveItemButton.Size = new System.Drawing.Size(45, 41);
            this.RemoveItemButton.TabIndex = 5;
            this.RemoveItemButton.Text = "Del";
            this.RemoveItemButton.Click += new System.EventHandler(this.RemoveItemButton_Click);
            // 
            // ItemUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RemoveItemButton);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.ProductLabel);
            this.Name = "ItemUserControl";
            this.Size = new System.Drawing.Size(346, 88);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProductLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Label TotalLabel;
        private Guna.UI2.WinForms.Guna2TileButton RemoveItemButton;
    }
}
