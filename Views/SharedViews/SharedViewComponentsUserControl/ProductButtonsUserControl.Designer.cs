﻿namespace Fastfood_Kiosk_v2.Views.AdminViews.AdminViewsUserControl
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
            this.ProductPanel.BackColor = System.Drawing.Color.Transparent;
            this.ProductPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(223)))), ((int)(((byte)(206)))));
            this.ProductPanel.BorderRadius = 30;
            this.ProductPanel.BorderThickness = 2;
            this.ProductPanel.Controls.Add(this.ProductButton);
            this.ProductPanel.Controls.Add(this.PriceLabel);
            this.ProductPanel.Controls.Add(this.ProductNameLabel);
            this.ProductPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(223)))), ((int)(((byte)(206)))));
            this.ProductPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(223)))), ((int)(((byte)(206)))));
            this.ProductPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(251)))));
            this.ProductPanel.Location = new System.Drawing.Point(0, 0);
            this.ProductPanel.Name = "ProductPanel";
            this.ProductPanel.Size = new System.Drawing.Size(265, 330);
            this.ProductPanel.TabIndex = 0;
            // 
            // ProductButton
            // 
            this.ProductButton.BorderRadius = 20;
            this.ProductButton.ImageRotate = 0F;
            this.ProductButton.Location = new System.Drawing.Point(14, 18);
            this.ProductButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProductButton.Name = "ProductButton";
            this.ProductButton.Size = new System.Drawing.Size(238, 234);
            this.ProductButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProductButton.TabIndex = 3;
            this.ProductButton.TabStop = false;
            // 
            // PriceLabel
            // 
            this.PriceLabel.BackColor = System.Drawing.Color.Transparent;
            this.PriceLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(92)))), ((int)(((byte)(47)))));
            this.PriceLabel.Location = new System.Drawing.Point(15, 295);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(84, 25);
            this.PriceLabel.TabIndex = 2;
            this.PriceLabel.Text = "₱ 100.00";
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.ProductNameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(92)))), ((int)(((byte)(47)))));
            this.ProductNameLabel.Location = new System.Drawing.Point(14, 258);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(176, 32);
            this.ProductNameLabel.TabIndex = 1;
            this.ProductNameLabel.Text = "Product Name";
            // 
            // ProductButtonsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ProductPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "ProductButtonsUserControl";
            this.Size = new System.Drawing.Size(265, 330);
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
