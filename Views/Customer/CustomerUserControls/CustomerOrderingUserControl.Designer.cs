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
            this.SearchTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.CartPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.CustomerOrderingLabelPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.ProductsFLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.CustomerOrderingLabelPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuFlowLayoutPanel
            // 
            this.MenuFlowLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.MenuFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuFlowLayoutPanel.Name = "MenuFlowLayoutPanel";
            this.MenuFlowLayoutPanel.Size = new System.Drawing.Size(220, 1080);
            this.MenuFlowLayoutPanel.TabIndex = 0;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.SearchTextBox.BorderRadius = 20;
            this.SearchTextBox.BorderThickness = 2;
            this.SearchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchTextBox.DefaultText = "Search";
            this.SearchTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.SearchTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.SearchTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(144)))));
            this.SearchTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchTextBox.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(144)))));
            this.SearchTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.SearchTextBox.Location = new System.Drawing.Point(1010, 18);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.PasswordChar = '\0';
            this.SearchTextBox.PlaceholderText = "";
            this.SearchTextBox.SelectedText = "";
            this.SearchTextBox.Size = new System.Drawing.Size(295, 42);
            this.SearchTextBox.TabIndex = 3;
            this.SearchTextBox.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // CartPanel
            // 
            this.CartPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(223)))), ((int)(((byte)(206)))));
            this.CartPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.CartPanel.Location = new System.Drawing.Point(1564, 0);
            this.CartPanel.Name = "CartPanel";
            this.CartPanel.Size = new System.Drawing.Size(356, 1080);
            this.CartPanel.TabIndex = 4;
            // 
            // CustomerOrderingLabelPanel
            // 
            this.CustomerOrderingLabelPanel.Controls.Add(this.SearchTextBox);
            this.CustomerOrderingLabelPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CustomerOrderingLabelPanel.Location = new System.Drawing.Point(220, 0);
            this.CustomerOrderingLabelPanel.Margin = new System.Windows.Forms.Padding(2);
            this.CustomerOrderingLabelPanel.Name = "CustomerOrderingLabelPanel";
            this.CustomerOrderingLabelPanel.Size = new System.Drawing.Size(1344, 83);
            this.CustomerOrderingLabelPanel.TabIndex = 5;
            // 
            // ProductsFLayoutPanel
            // 
            this.ProductsFLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductsFLayoutPanel.Location = new System.Drawing.Point(220, 83);
            this.ProductsFLayoutPanel.Name = "ProductsFLayoutPanel";
            this.ProductsFLayoutPanel.Size = new System.Drawing.Size(1344, 997);
            this.ProductsFLayoutPanel.TabIndex = 6;
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
            this.CustomerOrderingLabelPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel MenuFlowLayoutPanel;
        private Guna.UI2.WinForms.Guna2TextBox SearchTextBox;
        private Guna.UI2.WinForms.Guna2Panel CartPanel;
        private Guna.UI2.WinForms.Guna2Panel CustomerOrderingLabelPanel;
        private System.Windows.Forms.FlowLayoutPanel ProductsFLayoutPanel;
    }
}
