namespace Fastfood_Kiosk_v2.Views.AdminViews.AdminViewsUserControl
{
    partial class ProductButtonsUserControl
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
            this.ProductPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.ProductButton = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PriceLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ProductNameLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ProductPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductButton)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductPanel
            // 
            this.ProductPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(251)))));
            this.ProductPanel.BorderRadius = 30;
            this.ProductPanel.Controls.Add(this.ProductButton);
            this.ProductPanel.Controls.Add(this.PriceLabel);
            this.ProductPanel.Controls.Add(this.ProductNameLabel);
            this.ProductPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(251)))));
            this.ProductPanel.Location = new System.Drawing.Point(2, 2);
            this.ProductPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ProductPanel.Name = "ProductPanel";
            this.ProductPanel.Size = new System.Drawing.Size(171, 201);
            this.ProductPanel.TabIndex = 0;
            // 
            // ProductButton
            // 
            this.ProductButton.ImageRotate = 0F;
            this.ProductButton.Location = new System.Drawing.Point(-2, -2);
            this.ProductButton.Name = "ProductButton";
            this.ProductButton.Size = new System.Drawing.Size(175, 159);
            this.ProductButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProductButton.TabIndex = 3;
            this.ProductButton.TabStop = false;
            // 
            // PriceLabel
            // 
            this.PriceLabel.BackColor = System.Drawing.Color.Transparent;
            this.PriceLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(144)))));
            this.PriceLabel.Location = new System.Drawing.Point(5, 184);
            this.PriceLabel.Margin = new System.Windows.Forms.Padding(2);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(56, 19);
            this.PriceLabel.TabIndex = 2;
            this.PriceLabel.Text = "₱ 100.00";
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.ProductNameLabel.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameLabel.ForeColor = System.Drawing.Color.Black;
            this.ProductNameLabel.Location = new System.Drawing.Point(5, 162);
            this.ProductNameLabel.Margin = new System.Windows.Forms.Padding(2);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(109, 22);
            this.ProductNameLabel.TabIndex = 1;
            this.ProductNameLabel.Text = "Product Name";
            // 
            // ProductButtonsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.ProductPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ProductButtonsUserControl";
            this.Size = new System.Drawing.Size(175, 205);
            this.ProductPanel.ResumeLayout(false);
            this.ProductPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel ProductPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel ProductNameLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel PriceLabel;
        private Guna.UI2.WinForms.Guna2PictureBox ProductButton;
    }
}
