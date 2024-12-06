namespace Fastfood_Kiosk_v2.Views.AdminViews.AdminViewsUserControl
{
    partial class OrderDetailsUserControl
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
            this.OrderDetailsPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.PrintButton = new Guna.UI2.WinForms.Guna2TileButton();
            this.ProductName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.OrderTypeLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.OrderDateLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.OrderNumberLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CompleteOrderButton = new Guna.UI2.WinForms.Guna2TileButton();
            this.OrderDetailsPanel.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderDetailsPanel
            // 
            this.OrderDetailsPanel.BackColor = System.Drawing.Color.Transparent;
            this.OrderDetailsPanel.BorderRadius = 20;
            this.OrderDetailsPanel.Controls.Add(this.CompleteOrderButton);
            this.OrderDetailsPanel.Controls.Add(this.PrintButton);
            this.OrderDetailsPanel.Controls.Add(this.ProductName);
            this.OrderDetailsPanel.Controls.Add(this.guna2Panel1);
            this.OrderDetailsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.OrderDetailsPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(223)))), ((int)(((byte)(206)))));
            this.OrderDetailsPanel.Location = new System.Drawing.Point(0, 0);
            this.OrderDetailsPanel.Name = "OrderDetailsPanel";
            this.OrderDetailsPanel.Size = new System.Drawing.Size(474, 459);
            this.OrderDetailsPanel.TabIndex = 0;
            // 
            // PrintButton
            // 
            this.PrintButton.BorderRadius = 20;
            this.PrintButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PrintButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PrintButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PrintButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PrintButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(92)))), ((int)(((byte)(47)))));
            this.PrintButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.PrintButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(92)))), ((int)(((byte)(47)))));
            this.PrintButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(92)))), ((int)(((byte)(47)))));
            this.PrintButton.Location = new System.Drawing.Point(25, 392);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(180, 44);
            this.PrintButton.TabIndex = 4;
            this.PrintButton.Text = "Print";
            // 
            // ProductName
            // 
            this.ProductName.BackColor = System.Drawing.Color.Transparent;
            this.ProductName.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(92)))), ((int)(((byte)(47)))));
            this.ProductName.Location = new System.Drawing.Point(25, 179);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(69, 25);
            this.ProductName.TabIndex = 3;
            this.ProductName.Text = "Meal 1";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.Controls.Add(this.OrderTypeLabel);
            this.guna2Panel1.Controls.Add(this.OrderDateLabel);
            this.guna2Panel1.Controls.Add(this.OrderNumberLabel);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(92)))), ((int)(((byte)(47)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(474, 149);
            this.guna2Panel1.TabIndex = 0;
            // 
            // OrderTypeLabel
            // 
            this.OrderTypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.OrderTypeLabel.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.OrderTypeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.OrderTypeLabel.Location = new System.Drawing.Point(13, 101);
            this.OrderTypeLabel.Name = "OrderTypeLabel";
            this.OrderTypeLabel.Size = new System.Drawing.Size(130, 27);
            this.OrderTypeLabel.TabIndex = 2;
            this.OrderTypeLabel.Text = "Order Type:";
            // 
            // OrderDateLabel
            // 
            this.OrderDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.OrderDateLabel.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.OrderDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.OrderDateLabel.Location = new System.Drawing.Point(13, 63);
            this.OrderDateLabel.Name = "OrderDateLabel";
            this.OrderDateLabel.Size = new System.Drawing.Size(62, 27);
            this.OrderDateLabel.TabIndex = 1;
            this.OrderDateLabel.Text = "Date: ";
            // 
            // OrderNumberLabel
            // 
            this.OrderNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.OrderNumberLabel.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.OrderNumberLabel.Location = new System.Drawing.Point(13, 23);
            this.OrderNumberLabel.Name = "OrderNumberLabel";
            this.OrderNumberLabel.Size = new System.Drawing.Size(107, 27);
            this.OrderNumberLabel.TabIndex = 0;
            this.OrderNumberLabel.Text = "Order No.";
            // 
            // CompleteOrderButton
            // 
            this.CompleteOrderButton.BorderRadius = 20;
            this.CompleteOrderButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CompleteOrderButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CompleteOrderButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CompleteOrderButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CompleteOrderButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(92)))), ((int)(((byte)(47)))));
            this.CompleteOrderButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompleteOrderButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.CompleteOrderButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(92)))), ((int)(((byte)(47)))));
            this.CompleteOrderButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(92)))), ((int)(((byte)(47)))));
            this.CompleteOrderButton.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.CompleteOrderButton.IndicateFocus = true;
            this.CompleteOrderButton.Location = new System.Drawing.Point(245, 392);
            this.CompleteOrderButton.Name = "CompleteOrderButton";
            this.CompleteOrderButton.Size = new System.Drawing.Size(180, 44);
            this.CompleteOrderButton.TabIndex = 5;
            this.CompleteOrderButton.Text = "Complete";
            // 
            // OrderDetailsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.OrderDetailsPanel);
            this.Name = "OrderDetailsUserControl";
            this.Size = new System.Drawing.Size(474, 459);
            this.OrderDetailsPanel.ResumeLayout(false);
            this.OrderDetailsPanel.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel OrderDetailsPanel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel OrderTypeLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel OrderDateLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel OrderNumberLabel;
        private Guna.UI2.WinForms.Guna2TileButton PrintButton;
        private Guna.UI2.WinForms.Guna2HtmlLabel ProductName;
        private Guna.UI2.WinForms.Guna2TileButton CompleteOrderButton;
    }
}
