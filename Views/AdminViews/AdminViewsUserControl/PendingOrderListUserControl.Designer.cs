namespace Fastfood_Kiosk_v2.Views.AdminViews.AdminViewsUserControl
{
    partial class PendingOrderListUserControl
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
            this.PendingOrdersfLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // PendingOrdersfLayoutPanel
            // 
            this.PendingOrdersfLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PendingOrdersfLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.PendingOrdersfLayoutPanel.Name = "PendingOrdersfLayoutPanel";
            this.PendingOrdersfLayoutPanel.Size = new System.Drawing.Size(1690, 1080);
            this.PendingOrdersfLayoutPanel.TabIndex = 0;
            this.PendingOrdersfLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PendingOrdersfLayoutPanel_Paint);
            // 
            // PendingOrderListUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.Controls.Add(this.PendingOrdersfLayoutPanel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.Name = "PendingOrderListUserControl";
            this.Size = new System.Drawing.Size(1690, 1080);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel PendingOrdersfLayoutPanel;
    }
}
