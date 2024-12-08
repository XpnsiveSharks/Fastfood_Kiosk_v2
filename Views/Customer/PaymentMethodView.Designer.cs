namespace Fastfood_Kiosk_v2.Views.Customer
{
    partial class PaymentMethodView
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
            this.QRPayButton = new Guna.UI2.WinForms.Guna2Button();
            this.CashPaymentButton = new Guna.UI2.WinForms.Guna2Button();
            this.OnlinePayment = new Guna.UI2.WinForms.Guna2Button();
            this.BackButton = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // QRPayButton
            // 
            this.QRPayButton.BorderRadius = 18;
            this.QRPayButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.QRPayButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.QRPayButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.QRPayButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.QRPayButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.QRPayButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QRPayButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.QRPayButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.QRPayButton.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.QRPayButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.QRPayButton.Location = new System.Drawing.Point(278, 101);
            this.QRPayButton.Name = "QRPayButton";
            this.QRPayButton.Size = new System.Drawing.Size(262, 45);
            this.QRPayButton.TabIndex = 0;
            this.QRPayButton.Text = "QR Pay";
            this.QRPayButton.Click += new System.EventHandler(this.QRPayButton_Click);
            // 
            // CashPaymentButton
            // 
            this.CashPaymentButton.BorderRadius = 18;
            this.CashPaymentButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CashPaymentButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CashPaymentButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CashPaymentButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CashPaymentButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.CashPaymentButton.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.CashPaymentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.CashPaymentButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.CashPaymentButton.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.CashPaymentButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.CashPaymentButton.Location = new System.Drawing.Point(278, 152);
            this.CashPaymentButton.Name = "CashPaymentButton";
            this.CashPaymentButton.Size = new System.Drawing.Size(262, 45);
            this.CashPaymentButton.TabIndex = 1;
            this.CashPaymentButton.Text = "Cash (Pay at the counter)";
            this.CashPaymentButton.Click += new System.EventHandler(this.CashPaymentButton_Click);
            // 
            // OnlinePayment
            // 
            this.OnlinePayment.BorderRadius = 18;
            this.OnlinePayment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.OnlinePayment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.OnlinePayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.OnlinePayment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.OnlinePayment.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.OnlinePayment.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.OnlinePayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.OnlinePayment.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.OnlinePayment.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.OnlinePayment.Location = new System.Drawing.Point(278, 203);
            this.OnlinePayment.Name = "OnlinePayment";
            this.OnlinePayment.Size = new System.Drawing.Size(262, 45);
            this.OnlinePayment.TabIndex = 2;
            this.OnlinePayment.Text = "Online Payment";
            this.OnlinePayment.Click += new System.EventHandler(this.OnlinePayment_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Transparent;
            this.BackButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.BackButton.BorderRadius = 18;
            this.BackButton.BorderThickness = 1;
            this.BackButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BackButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BackButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BackButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BackButton.FillColor = System.Drawing.Color.Transparent;
            this.BackButton.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.BackButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.BackButton.Location = new System.Drawing.Point(317, 318);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(180, 45);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "Back";
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // PaymentMethodView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 474);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.OnlinePayment);
            this.Controls.Add(this.CashPaymentButton);
            this.Controls.Add(this.QRPayButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaymentMethodView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentMethodView";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button QRPayButton;
        private Guna.UI2.WinForms.Guna2Button CashPaymentButton;
        private Guna.UI2.WinForms.Guna2Button OnlinePayment;
        private Guna.UI2.WinForms.Guna2Button BackButton;
    }
}