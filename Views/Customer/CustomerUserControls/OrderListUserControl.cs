using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fastfood_Kiosk_v2.Views.Customer.CustomerUserControls
{
    public partial class OrderListUserControl : UserControl
    {
        public event EventHandler ItemRemoved;
        public event EventHandler QuantityChanged;


        public OrderListUserControl()
        {
            InitializeComponent();
        }
        public string Product 
        { 
            get => OrderNameLabel.Text; 
            set => OrderNameLabel.Text = value; 
        }
        public int Quantity
        { 
            get => int.TryParse(OrderQuantityLabel.Text, out var quantity) ? quantity : 0;
            set => OrderQuantityLabel.Text = value.ToString();
        }
        public double TotalPrice 
        {
            get => double.TryParse(OrderTotalLabel.Text, out var price) ? price : 0;
            set => OrderTotalLabel.Text = value.ToString("F2");
        }

        public int Qty 
        {
            get => int.TryParse(QuantityTextBox.Text, out var quantity) ? quantity : 0;
            set => QuantityTextBox.Text = value.ToString();
        }
        public double OrderPrice
        {
            get => double.TryParse(OrderPriceLabel.Text, out var price) ? price : 0;
            set => OrderPriceLabel.Text = value.ToString("F2");
        }
        private void RemoveOrderButton_Click(object sender, EventArgs e)
        {
            ItemRemoved?.Invoke(this, EventArgs.Empty); 
        }

        private void DecreaseOrderButton_Click(object sender, EventArgs e)
        {
            if (Qty > 1)
            {
                Qty--;
                Quantity = Qty;
                TotalPrice = Quantity * (TotalPrice / (Quantity + 1));
                QuantityChanged?.Invoke(this, EventArgs.Empty); 
            }
            else
            {
                MessageBox.Show("Quantity cannot be less than 1.");
            }
        }

        private void QuantityTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(QuantityTextBox.Text, out var newQty) && newQty > 0)
            {
                Quantity = newQty;
                TotalPrice = Quantity * (TotalPrice / Qty);
                Qty = newQty;
                QuantityChanged?.Invoke(this, EventArgs.Empty); 
            }
            else
        {
                MessageBox.Show("Invalid quantity entered.");
            }
        }

        private void IncreaseOrderButton_Click(object sender, EventArgs e)
        {
            Qty++;
            Quantity = Qty;
            TotalPrice = Quantity * (TotalPrice / (Quantity - 1));
            QuantityChanged?.Invoke(this, EventArgs.Empty); 
        }

    }
}
