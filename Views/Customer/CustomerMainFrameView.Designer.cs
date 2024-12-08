namespace Fastfood_Kiosk_v2.Views.Customer
{
    partial class CustomerMainFrameView
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
            this.CustomerMainFramePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.SuspendLayout();
            // 
            // CustomerMainFramePanel
            // 
            this.CustomerMainFramePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.CustomerMainFramePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomerMainFramePanel.Location = new System.Drawing.Point(0, 0);
            this.CustomerMainFramePanel.Name = "CustomerMainFramePanel";
            this.CustomerMainFramePanel.Size = new System.Drawing.Size(1620, 920);
            this.CustomerMainFramePanel.TabIndex = 0;
            // 
            // CustomerMainFrameView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1620, 920);
            this.Controls.Add(this.CustomerMainFramePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CustomerMainFrameView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerMainFrameView";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel CustomerMainFramePanel;
    }
}