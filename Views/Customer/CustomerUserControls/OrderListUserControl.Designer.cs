namespace Fastfood_Kiosk_v2.Views.Customer.CustomerUserControls
{
    partial class OrderListUserControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.ProductNameLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.QuantityLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.RemoveOrderButton = new Guna.UI2.WinForms.Guna2Button();
            this.AddQuantityButton = new Guna.UI2.WinForms.Guna2Button();
            this.SubtractQuantityButton = new Guna.UI2.WinForms.Guna2Button();
            this.QuantityTitleLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.QuantityTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(223)))), ((int)(((byte)(206)))));
            this.guna2Panel1.BorderRadius = 30;
            this.guna2Panel1.BorderThickness = 5;
            this.guna2Panel1.Controls.Add(this.QuantityTextBox);
            this.guna2Panel1.Controls.Add(this.QuantityTitleLabel);
            this.guna2Panel1.Controls.Add(this.SubtractQuantityButton);
            this.guna2Panel1.Controls.Add(this.AddQuantityButton);
            this.guna2Panel1.Controls.Add(this.RemoveOrderButton);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.Controls.Add(this.QuantityLabel);
            this.guna2Panel1.Controls.Add(this.ProductNameLabel);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(223)))), ((int)(((byte)(206)))));
            this.guna2Panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.guna2Panel1.Location = new System.Drawing.Point(153, 20);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1621, 318);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.label1.Location = new System.Drawing.Point(52, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1525, 3);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.ProductNameLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.ProductNameLabel.Location = new System.Drawing.Point(52, 41);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(260, 45);
            this.ProductNameLabel.TabIndex = 1;
            this.ProductNameLabel.Text = "Product Name";
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.BackColor = System.Drawing.Color.Transparent;
            this.QuantityLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.QuantityLabel.Location = new System.Drawing.Point(844, 41);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(40, 45);
            this.QuantityLabel.TabIndex = 2;
            this.QuantityLabel.Text = "x2";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(1387, 41);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(190, 45);
            this.guna2HtmlLabel1.TabIndex = 3;
            this.guna2HtmlLabel1.Text = "Php 400.00";
            // 
            // RemoveOrderButton
            // 
            this.RemoveOrderButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.RemoveOrderButton.BorderRadius = 20;
            this.RemoveOrderButton.BorderThickness = 2;
            this.RemoveOrderButton.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.RemoveOrderButton.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.RemoveOrderButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(223)))), ((int)(((byte)(206)))));
            this.RemoveOrderButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.RemoveOrderButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(223)))), ((int)(((byte)(206)))));
            this.RemoveOrderButton.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveOrderButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.RemoveOrderButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.RemoveOrderButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.RemoveOrderButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(223)))), ((int)(((byte)(206)))));
            this.RemoveOrderButton.Location = new System.Drawing.Point(34, 236);
            this.RemoveOrderButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RemoveOrderButton.Name = "RemoveOrderButton";
            this.RemoveOrderButton.Size = new System.Drawing.Size(181, 55);
            this.RemoveOrderButton.TabIndex = 4;
            this.RemoveOrderButton.Text = "Remove";
            // 
            // AddQuantityButton
            // 
            this.AddQuantityButton.BackColor = System.Drawing.Color.Transparent;
            this.AddQuantityButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(166)))), ((int)(((byte)(110)))));
            this.AddQuantityButton.BorderRadius = 20;
            this.AddQuantityButton.BorderThickness = 2;
            this.AddQuantityButton.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(166)))), ((int)(((byte)(110)))));
            this.AddQuantityButton.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(166)))), ((int)(((byte)(110)))));
            this.AddQuantityButton.DisabledState.FillColor = System.Drawing.Color.Transparent;
            this.AddQuantityButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(92)))), ((int)(((byte)(47)))));
            this.AddQuantityButton.FillColor = System.Drawing.Color.Transparent;
            this.AddQuantityButton.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddQuantityButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(92)))), ((int)(((byte)(47)))));
            this.AddQuantityButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(166)))), ((int)(((byte)(110)))));
            this.AddQuantityButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(166)))), ((int)(((byte)(110)))));
            this.AddQuantityButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(92)))), ((int)(((byte)(47)))));
            this.AddQuantityButton.Location = new System.Drawing.Point(935, 245);
            this.AddQuantityButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddQuantityButton.Name = "AddQuantityButton";
            this.AddQuantityButton.Size = new System.Drawing.Size(67, 55);
            this.AddQuantityButton.TabIndex = 5;
            this.AddQuantityButton.Text = "+";
            // 
            // SubtractQuantityButton
            // 
            this.SubtractQuantityButton.BackColor = System.Drawing.Color.Transparent;
            this.SubtractQuantityButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(166)))), ((int)(((byte)(110)))));
            this.SubtractQuantityButton.BorderRadius = 20;
            this.SubtractQuantityButton.BorderThickness = 2;
            this.SubtractQuantityButton.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(166)))), ((int)(((byte)(110)))));
            this.SubtractQuantityButton.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(166)))), ((int)(((byte)(110)))));
            this.SubtractQuantityButton.DisabledState.FillColor = System.Drawing.Color.Transparent;
            this.SubtractQuantityButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(92)))), ((int)(((byte)(47)))));
            this.SubtractQuantityButton.FillColor = System.Drawing.Color.Transparent;
            this.SubtractQuantityButton.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtractQuantityButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(92)))), ((int)(((byte)(47)))));
            this.SubtractQuantityButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(166)))), ((int)(((byte)(110)))));
            this.SubtractQuantityButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(166)))), ((int)(((byte)(110)))));
            this.SubtractQuantityButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(92)))), ((int)(((byte)(47)))));
            this.SubtractQuantityButton.Location = new System.Drawing.Point(743, 245);
            this.SubtractQuantityButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SubtractQuantityButton.Name = "SubtractQuantityButton";
            this.SubtractQuantityButton.Size = new System.Drawing.Size(67, 55);
            this.SubtractQuantityButton.TabIndex = 6;
            this.SubtractQuantityButton.Text = "-";
            // 
            // QuantityTitleLabel
            // 
            this.QuantityTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.QuantityTitleLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.QuantityTitleLabel.Location = new System.Drawing.Point(821, 191);
            this.QuantityTitleLabel.Name = "QuantityTitleLabel";
            this.QuantityTitleLabel.Size = new System.Drawing.Size(105, 32);
            this.QuantityTitleLabel.TabIndex = 7;
            this.QuantityTitleLabel.Text = "Quantity";
            this.QuantityTitleLabel.Click += new System.EventHandler(this.QuantityTitleLabel_Click);
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.QuantityTextBox.BorderRadius = 20;
            this.QuantityTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.QuantityTextBox.DefaultText = "2";
            this.QuantityTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.QuantityTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.QuantityTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.QuantityTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.QuantityTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(223)))), ((int)(((byte)(206)))));
            this.QuantityTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.QuantityTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.QuantityTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.QuantityTextBox.Location = new System.Drawing.Point(821, 245);
            this.QuantityTextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.PasswordChar = '\0';
            this.QuantityTextBox.PlaceholderText = "";
            this.QuantityTextBox.SelectedText = "";
            this.QuantityTextBox.Size = new System.Drawing.Size(103, 55);
            this.QuantityTextBox.TabIndex = 8;
            this.QuantityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OrderListUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.Controls.Add(this.guna2Panel1);
            this.Name = "OrderListUserControl";
            this.Size = new System.Drawing.Size(1920, 364);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2HtmlLabel ProductNameLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel QuantityLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button RemoveOrderButton;
        private Guna.UI2.WinForms.Guna2Button AddQuantityButton;
        private Guna.UI2.WinForms.Guna2HtmlLabel QuantityTitleLabel;
        private Guna.UI2.WinForms.Guna2Button SubtractQuantityButton;
        private Guna.UI2.WinForms.Guna2TextBox QuantityTextBox;
    }
}
