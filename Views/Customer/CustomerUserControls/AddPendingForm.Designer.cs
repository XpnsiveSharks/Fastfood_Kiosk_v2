namespace Fastfood_Kiosk_v2.Views.Customer.CustomerUserControls
{
    partial class AddPendingForm
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
            this.OkayButton = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.OrderNameLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // OkayButton
            // 
            this.OkayButton.BorderColor = System.Drawing.Color.Transparent;
            this.OkayButton.BorderRadius = 19;
            this.OkayButton.BorderThickness = 2;
            this.OkayButton.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(92)))), ((int)(((byte)(47)))));
            this.OkayButton.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.OkayButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.OkayButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.OkayButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.OkayButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.OkayButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.OkayButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.OkayButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OkayButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(223)))), ((int)(((byte)(206)))));
            this.OkayButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.OkayButton.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.OkayButton.HoverState.FillColor2 = System.Drawing.Color.Transparent;
            this.OkayButton.HoverState.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.OkayButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.OkayButton.Location = new System.Drawing.Point(332, 271);
            this.OkayButton.Name = "OkayButton";
            this.OkayButton.Size = new System.Drawing.Size(153, 44);
            this.OkayButton.TabIndex = 16;
            this.OkayButton.Text = "Okay";
            // 
            // OrderNameLabel
            // 
            this.OrderNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.OrderNameLabel.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderNameLabel.ForeColor = System.Drawing.Color.Black;
            this.OrderNameLabel.Location = new System.Drawing.Point(238, 138);
            this.OrderNameLabel.Margin = new System.Windows.Forms.Padding(2);
            this.OrderNameLabel.Name = "OrderNameLabel";
            this.OrderNameLabel.Size = new System.Drawing.Size(357, 38);
            this.OrderNameLabel.TabIndex = 15;
            this.OrderNameLabel.Text = "Added to pending orders\r\n";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(322, 180);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(180, 38);
            this.guna2HtmlLabel1.TabIndex = 17;
            this.guna2HtmlLabel1.Text = "successfully!";
            // 
            // AddPendingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.OkayButton);
            this.Controls.Add(this.OrderNameLabel);
            this.Name = "AddPendingForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientTileButton OkayButton;
        private Guna.UI2.WinForms.Guna2HtmlLabel OrderNameLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}