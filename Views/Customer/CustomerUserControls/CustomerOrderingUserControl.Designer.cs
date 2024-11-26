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
            this.ProductsFLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SearchTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.CartPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.SuspendLayout();
            // 
            // MenuFlowLayoutPanel
            // 
            this.MenuFlowLayoutPanel.Location = new System.Drawing.Point(0, 106);
            this.MenuFlowLayoutPanel.Name = "MenuFlowLayoutPanel";
            this.MenuFlowLayoutPanel.Size = new System.Drawing.Size(225, 649);
            this.MenuFlowLayoutPanel.TabIndex = 0;
            // 
            // ProductsFLayoutPanel
            // 
            this.ProductsFLayoutPanel.Location = new System.Drawing.Point(231, 106);
            this.ProductsFLayoutPanel.Name = "ProductsFLayoutPanel";
            this.ProductsFLayoutPanel.Size = new System.Drawing.Size(728, 649);
            this.ProductsFLayoutPanel.TabIndex = 2;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchTextBox.DefaultText = "Search";
            this.SearchTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SearchTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SearchTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SearchTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchTextBox.Location = new System.Drawing.Point(759, 64);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.PasswordChar = '\0';
            this.SearchTextBox.PlaceholderText = "";
            this.SearchTextBox.SelectedText = "";
            this.SearchTextBox.Size = new System.Drawing.Size(200, 36);
            this.SearchTextBox.TabIndex = 3;
            // 
            // CartPanel
            // 
            this.CartPanel.Location = new System.Drawing.Point(965, 3);
            this.CartPanel.Name = "CartPanel";
            this.CartPanel.Size = new System.Drawing.Size(367, 752);
            this.CartPanel.TabIndex = 4;
            // 
            // CustomerOrderingUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CartPanel);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.ProductsFLayoutPanel);
            this.Controls.Add(this.MenuFlowLayoutPanel);
            this.Name = "CustomerOrderingUserControl";
            this.Size = new System.Drawing.Size(1335, 758);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel MenuFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel ProductsFLayoutPanel;
        private Guna.UI2.WinForms.Guna2TextBox SearchTextBox;
        private Guna.UI2.WinForms.Guna2Panel CartPanel;
    }
}
