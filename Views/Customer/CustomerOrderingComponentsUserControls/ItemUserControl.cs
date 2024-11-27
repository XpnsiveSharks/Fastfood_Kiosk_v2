using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fastfood_Kiosk_v2.Views.Customer.CustomerOrderingComponentsUserControls
{
    public partial class ItemUserControl : UserControl
    {
        public ItemUserControl()
        {
            InitializeComponent();
        }
        public string Product 
        { 
            get => ProductLabel.Text; 
            set => ProductLabel.Text = value; 
        }
        public double Price 
        {
            get => double.TryParse(PriceLabel.Text, out var price) ? price : 0;
            set => PriceLabel.Text = value.ToString("F2");
        }
        public int Quantity 
        {
            get => int.TryParse(QuantityLabel.Text, out var quantity) ? quantity : 0; 
            set => QuantityLabel.Text = value.ToString();
        }
        public double MyProperty 
        { 
            get => double.TryParse(TotalLabel.Text, out var total) ? total : 0; 
            set => TotalLabel.Text = value.ToString(); 
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {

        }

        private void PriceLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
