namespace Fastfood_Kiosk_v2.Views.Customer.CustomerUserControls
{
    partial class CustomerOrderingUserControl
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
            this.MenuFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.CartPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.CustomerOrderingLabelPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.ProductsFLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // MenuFlowLayoutPanel
            // 
            this.MenuFlowLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.MenuFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MenuFlowLayoutPanel.Name = "MenuFlowLayoutPanel";
            this.MenuFlowLayoutPanel.Size = new System.Drawing.Size(241, 1080);
            this.MenuFlowLayoutPanel.TabIndex = 0;
            // 
            // CartPanel
            // 
            this.CartPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(223)))), ((int)(((byte)(206)))));
            this.CartPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.CartPanel.Location = new System.Drawing.Point(1541, 0);
            this.CartPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CartPanel.Name = "CartPanel";
            this.CartPanel.Size = new System.Drawing.Size(379, 1080);
            this.CartPanel.TabIndex = 4;
            // 
            // CustomerOrderingLabelPanel
            // 
            this.CustomerOrderingLabelPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CustomerOrderingLabelPanel.Location = new System.Drawing.Point(241, 0);
            this.CustomerOrderingLabelPanel.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.CustomerOrderingLabelPanel.Name = "CustomerOrderingLabelPanel";
            this.CustomerOrderingLabelPanel.Size = new System.Drawing.Size(1300, 67);
            this.CustomerOrderingLabelPanel.TabIndex = 5;
            // 
            // ProductsFLayoutPanel
            // 
            this.ProductsFLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductsFLayoutPanel.Location = new System.Drawing.Point(241, 67);
            this.ProductsFLayoutPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ProductsFLayoutPanel.Name = "ProductsFLayoutPanel";
            this.ProductsFLayoutPanel.Size = new System.Drawing.Size(1300, 1013);
            this.ProductsFLayoutPanel.TabIndex = 6;
            this.ProductsFLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ProductsFLayoutPanel_Paint);
            // 
            // CustomerOrderingUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.Controls.Add(this.ProductsFLayoutPanel);
            this.Controls.Add(this.CustomerOrderingLabelPanel);
            this.Controls.Add(this.CartPanel);
            this.Controls.Add(this.MenuFlowLayoutPanel);
            this.Name = "CustomerOrderingUserControl";
            this.Size = new System.Drawing.Size(1920, 1080);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel MenuFlowLayoutPanel;
        private Guna.UI2.WinForms.Guna2Panel CartPanel;
        private Guna.UI2.WinForms.Guna2Panel CustomerOrderingLabelPanel;
        private System.Windows.Forms.FlowLayoutPanel ProductsFLayoutPanel;
    }
}
