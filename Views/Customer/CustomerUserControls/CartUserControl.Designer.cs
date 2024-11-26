namespace Fastfood_Kiosk_v2.Views.Customer.CustomerUserControls
{
    partial class CartUserControl
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.SubTotalLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DiscountLabel = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.ProceedButton = new Guna.UI2.WinForms.Guna2Button();
            this.ClearOrderButton = new Guna.UI2.WinForms.Guna2Button();
            this.ItemsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Item = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.guna2Panel1.Controls.Add(this.SubTotalLabel);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.DiscountLabel);
            this.guna2Panel1.Controls.Add(this.label);
            this.guna2Panel1.Controls.Add(this.ProceedButton);
            this.guna2Panel1.Controls.Add(this.ClearOrderButton);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 530);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(367, 222);
            this.guna2Panel1.TabIndex = 0;
            // 
            // SubTotalLabel
            // 
            this.SubTotalLabel.AutoSize = true;
            this.SubTotalLabel.Location = new System.Drawing.Point(292, 34);
            this.SubTotalLabel.Name = "SubTotalLabel";
            this.SubTotalLabel.Size = new System.Drawing.Size(47, 13);
            this.SubTotalLabel.TabIndex = 6;
            this.SubTotalLabel.Text = "P000.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sub Total";
            // 
            // DiscountLabel
            // 
            this.DiscountLabel.AutoSize = true;
            this.DiscountLabel.Location = new System.Drawing.Point(304, 21);
            this.DiscountLabel.Name = "DiscountLabel";
            this.DiscountLabel.Size = new System.Drawing.Size(35, 13);
            this.DiscountLabel.TabIndex = 4;
            this.DiscountLabel.Text = "P0.00";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(23, 21);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(49, 13);
            this.label.TabIndex = 3;
            this.label.Text = "Discount";
            // 
            // ProceedButton
            // 
            this.ProceedButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ProceedButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ProceedButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ProceedButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ProceedButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ProceedButton.ForeColor = System.Drawing.Color.White;
            this.ProceedButton.Location = new System.Drawing.Point(93, 150);
            this.ProceedButton.Name = "ProceedButton";
            this.ProceedButton.Size = new System.Drawing.Size(180, 45);
            this.ProceedButton.TabIndex = 2;
            this.ProceedButton.Text = "Proceed";
            this.ProceedButton.Click += new System.EventHandler(this.ProceedButton_Click);
            // 
            // ClearOrderButton
            // 
            this.ClearOrderButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ClearOrderButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ClearOrderButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ClearOrderButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ClearOrderButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ClearOrderButton.ForeColor = System.Drawing.Color.White;
            this.ClearOrderButton.Location = new System.Drawing.Point(93, 99);
            this.ClearOrderButton.Name = "ClearOrderButton";
            this.ClearOrderButton.Size = new System.Drawing.Size(180, 45);
            this.ClearOrderButton.TabIndex = 1;
            this.ClearOrderButton.Text = "Clear Order";
            this.ClearOrderButton.Click += new System.EventHandler(this.ClearOrderButton_Click);
            // 
            // ItemsFlowLayoutPanel
            // 
            this.ItemsFlowLayoutPanel.Location = new System.Drawing.Point(3, 71);
            this.ItemsFlowLayoutPanel.Name = "ItemsFlowLayoutPanel";
            this.ItemsFlowLayoutPanel.Size = new System.Drawing.Size(361, 453);
            this.ItemsFlowLayoutPanel.TabIndex = 1;
            // 
            // Item
            // 
            this.Item.AutoSize = true;
            this.Item.Location = new System.Drawing.Point(3, 46);
            this.Item.Name = "Item";
            this.Item.Size = new System.Drawing.Size(27, 13);
            this.Item.TabIndex = 2;
            this.Item.Text = "Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Qty";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Price";
            // 
            // CartUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Item);
            this.Controls.Add(this.ItemsFlowLayoutPanel);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "CartUserControl";
            this.Size = new System.Drawing.Size(367, 752);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button ProceedButton;
        private Guna.UI2.WinForms.Guna2Button ClearOrderButton;
        private System.Windows.Forms.Label SubTotalLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DiscountLabel;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.FlowLayoutPanel ItemsFlowLayoutPanel;
        private System.Windows.Forms.Label Item;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
