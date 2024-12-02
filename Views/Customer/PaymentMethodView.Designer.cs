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
            this.QRPayButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.QRPayButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.QRPayButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.QRPayButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.QRPayButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.QRPayButton.ForeColor = System.Drawing.Color.White;
            this.QRPayButton.Location = new System.Drawing.Point(296, 101);
            this.QRPayButton.Name = "QRPayButton";
            this.QRPayButton.Size = new System.Drawing.Size(180, 45);
            this.QRPayButton.TabIndex = 0;
            this.QRPayButton.Text = "QR Pay";
            this.QRPayButton.Click += new System.EventHandler(this.QRPayButton_Click);
            // 
            // CashPaymentButton
            // 
            this.CashPaymentButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CashPaymentButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CashPaymentButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CashPaymentButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CashPaymentButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CashPaymentButton.ForeColor = System.Drawing.Color.White;
            this.CashPaymentButton.Location = new System.Drawing.Point(296, 162);
            this.CashPaymentButton.Name = "CashPaymentButton";
            this.CashPaymentButton.Size = new System.Drawing.Size(180, 45);
            this.CashPaymentButton.TabIndex = 1;
            this.CashPaymentButton.Text = "Cash (Pay at the counter)";
            this.CashPaymentButton.Click += new System.EventHandler(this.CashPaymentButton_Click);
            // 
            // OnlinePayment
            // 
            this.OnlinePayment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.OnlinePayment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.OnlinePayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.OnlinePayment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.OnlinePayment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.OnlinePayment.ForeColor = System.Drawing.Color.White;
            this.OnlinePayment.Location = new System.Drawing.Point(296, 229);
            this.OnlinePayment.Name = "OnlinePayment";
            this.OnlinePayment.Size = new System.Drawing.Size(180, 45);
            this.OnlinePayment.TabIndex = 2;
            this.OnlinePayment.Text = "Online Payment";
            this.OnlinePayment.Click += new System.EventHandler(this.OnlinePayment_Click);
            // 
            // BackButton
            // 
            this.BackButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BackButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BackButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BackButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BackButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BackButton.ForeColor = System.Drawing.Color.White;
            this.BackButton.Location = new System.Drawing.Point(296, 378);
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
            this.Name = "PaymentMethodView";
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