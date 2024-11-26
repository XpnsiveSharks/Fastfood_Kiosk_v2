using Fastfood_Kiosk_v2.Views.Customer.CustomerUserControls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fastfood_Kiosk_v2.Views.AdminViews.AdminViewsUserControl
{
    public partial class ProductButtonsUserControl : UserControl
    {
        public event EventHandler<(string ProductName, double ProductPrice)> ProductClicked;
        public ProductButtonsUserControl()
        {
            InitializeComponent();
            AttachClickEvents();
        }
        public int ProductId { get; set; }
        public Image ProductImage
        {
            get => ProductButton.Image;
            set => ProductButton.Image = value;
        }
        public string ProductNames
        {
            get => ProductNameLabel.Text;
            set => ProductNameLabel.Text = value;
        }
        public double ProductPrice
        {
            get => double.TryParse(PriceLabel.Text, out var price) ? price : 0;
            set => PriceLabel.Text = value.ToString("F2");
        }
        private void AttachClickEvents()
        {
            ProductButton.Click += NotifyProductClicked;
            ProductNameLabel.Click += NotifyProductClicked;
            PriceLabel.Click += NotifyProductClicked;
            ProductPanel.Click += NotifyProductClicked;
        }
        private void NotifyProductClicked(object sender, EventArgs e)
        {
            ProductClicked?.Invoke(this, (ProductNames, ProductPrice));
        }
    }

}
