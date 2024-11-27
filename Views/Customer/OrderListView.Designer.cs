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
            this.AddMoreButton = new Guna.UI2.WinForms.Guna2Button();
            this.CheckOutButton = new Guna.UI2.WinForms.Guna2Button();
            this.OrderListFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // AddMoreButton
            // 
            this.AddMoreButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddMoreButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddMoreButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddMoreButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddMoreButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddMoreButton.ForeColor = System.Drawing.Color.White;
            this.AddMoreButton.Location = new System.Drawing.Point(211, 510);
            this.AddMoreButton.Name = "AddMoreButton";
            this.AddMoreButton.Size = new System.Drawing.Size(180, 45);
            this.AddMoreButton.TabIndex = 0;
            this.AddMoreButton.Text = "Add More";
            this.AddMoreButton.Click += new System.EventHandler(this.AddMoreButton_Click);
            // 
            // CheckOutButton
            // 
            this.CheckOutButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CheckOutButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CheckOutButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CheckOutButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CheckOutButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CheckOutButton.ForeColor = System.Drawing.Color.White;
            this.CheckOutButton.Location = new System.Drawing.Point(471, 510);
            this.CheckOutButton.Name = "CheckOutButton";
            this.CheckOutButton.Size = new System.Drawing.Size(180, 45);
            this.CheckOutButton.TabIndex = 1;
            this.CheckOutButton.Text = "Check Out";
            this.CheckOutButton.Click += new System.EventHandler(this.CheckOutButton_Click);
            // 
            // OrderListFlowLayoutPanel
            // 
            this.OrderListFlowLayoutPanel.AutoScroll = true;
            this.OrderListFlowLayoutPanel.Location = new System.Drawing.Point(56, 74);
            this.OrderListFlowLayoutPanel.Name = "OrderListFlowLayoutPanel";
            this.OrderListFlowLayoutPanel.Size = new System.Drawing.Size(754, 373);
            this.OrderListFlowLayoutPanel.TabIndex = 2;
            this.OrderListFlowLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.OrderListFlowLayoutPanel_Paint);
            // 
            // OrderListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 590);
            this.Controls.Add(this.OrderListFlowLayoutPanel);
            this.Controls.Add(this.CheckOutButton);
            this.Controls.Add(this.AddMoreButton);
            this.Name = "OrderListView";
            this.Text = "OrderListView";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button AddMoreButton;
        private Guna.UI2.WinForms.Guna2Button CheckOutButton;
        private System.Windows.Forms.FlowLayoutPanel OrderListFlowLayoutPanel;
    }
}