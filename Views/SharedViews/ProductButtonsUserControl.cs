using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fastfood_Kiosk_v2.Views.AdminViews.AdminViewsUserControl
{
    public partial class ProductButtonsUserControl : UserControl
    {
        public ProductButtonsUserControl()
        {
            InitializeComponent();
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
            get
            {
                return double.TryParse(PriceLabel.Text, out double price) ? price : 0;
            }
            set
            {
                PriceLabel.Text = value.ToString("F2");
            }
        }
    }

}
