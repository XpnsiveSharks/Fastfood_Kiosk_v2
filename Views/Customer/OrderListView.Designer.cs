namespace Fastfood_Kiosk_v2.Views.Customer
{
    partial class OrderListView
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
            this.AddOrderButton = new Guna.UI2.WinForms.Guna2Button();
            this.CheckoutButton = new Guna.UI2.WinForms.Guna2Button();
            this.OrderListButtonsPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.OrderListPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.OrderListFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.OrderListLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.OrderListButtonsPanel.SuspendLayout();
            this.OrderListPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddOrderButton
            // 
            this.AddOrderButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.AddOrderButton.BorderRadius = 20;
            this.AddOrderButton.BorderThickness = 2;
            this.AddOrderButton.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.AddOrderButton.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.AddOrderButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.AddOrderButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.AddOrderButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.AddOrderButton.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddOrderButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.AddOrderButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.AddOrderButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.AddOrderButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.AddOrderButton.Location = new System.Drawing.Point(576, 26);
            this.AddOrderButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddOrderButton.Name = "AddOrderButton";
            this.AddOrderButton.Size = new System.Drawing.Size(350, 55);
            this.AddOrderButton.TabIndex = 2;
            this.AddOrderButton.Text = "Add order";
            // 
            // CheckoutButton
            // 
            this.CheckoutButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.CheckoutButton.BorderRadius = 20;
            this.CheckoutButton.BorderThickness = 2;
            this.CheckoutButton.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.CheckoutButton.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.CheckoutButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.CheckoutButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.CheckoutButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.CheckoutButton.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckoutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.CheckoutButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.CheckoutButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.CheckoutButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.CheckoutButton.Location = new System.Drawing.Point(1068, 26);
            this.CheckoutButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CheckoutButton.Name = "CheckoutButton";
            this.CheckoutButton.Size = new System.Drawing.Size(350, 55);
            this.CheckoutButton.TabIndex = 3;
            this.CheckoutButton.Text = "Checkout";
            // 
            // OrderListButtonsPanel
            // 
            this.OrderListButtonsPanel.Controls.Add(this.CheckoutButton);
            this.OrderListButtonsPanel.Controls.Add(this.AddOrderButton);
            this.OrderListButtonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OrderListButtonsPanel.Location = new System.Drawing.Point(0, 980);
            this.OrderListButtonsPanel.Name = "OrderListButtonsPanel";
            this.OrderListButtonsPanel.Size = new System.Drawing.Size(1920, 100);
            this.OrderListButtonsPanel.TabIndex = 4;
            // 
            // OrderListPanel
            // 
            this.OrderListPanel.Controls.Add(this.OrderListLabel);
            this.OrderListPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.OrderListPanel.Location = new System.Drawing.Point(0, 0);
            this.OrderListPanel.Name = "OrderListPanel";
            this.OrderListPanel.Size = new System.Drawing.Size(1920, 119);
            this.OrderListPanel.TabIndex = 5;
            // 
            // OrderListFlowLayoutPanel
            // 
            this.OrderListFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderListFlowLayoutPanel.Location = new System.Drawing.Point(0, 119);
            this.OrderListFlowLayoutPanel.Name = "OrderListFlowLayoutPanel";
            this.OrderListFlowLayoutPanel.Size = new System.Drawing.Size(1920, 861);
            this.OrderListFlowLayoutPanel.TabIndex = 6;
            // 
            // OrderListLabel
            // 
            this.OrderListLabel.BackColor = System.Drawing.Color.Transparent;
            this.OrderListLabel.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderListLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.OrderListLabel.Location = new System.Drawing.Point(853, 33);
            this.OrderListLabel.Name = "OrderListLabel";
            this.OrderListLabel.Size = new System.Drawing.Size(237, 64);
            this.OrderListLabel.TabIndex = 0;
            this.OrderListLabel.Text = "Order List";
            // 
            // OrderListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.OrderListFlowLayoutPanel);
            this.Controls.Add(this.OrderListPanel);
            this.Controls.Add(this.OrderListButtonsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderListView";
            this.OrderListButtonsPanel.ResumeLayout(false);
            this.OrderListPanel.ResumeLayout(false);
            this.OrderListPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button AddOrderButton;
        private Guna.UI2.WinForms.Guna2Button CheckoutButton;
        private Guna.UI2.WinForms.Guna2Panel OrderListButtonsPanel;
        private Guna.UI2.WinForms.Guna2Panel OrderListPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel OrderListLabel;
        private System.Windows.Forms.FlowLayoutPanel OrderListFlowLayoutPanel;
    }
}