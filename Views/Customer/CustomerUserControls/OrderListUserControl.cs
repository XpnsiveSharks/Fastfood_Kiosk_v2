using Fastfood_Kiosk_v2.Views.Customer.CustomerOrderingComponentsUserControls;
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
        public event EventHandler ItemRemovedFromOrderList;
        public event EventHandler QuantityChanged;

        public ItemUserControl LinkedItemControl { get; set; }

        public OrderListUserControl()
        {
            InitializeComponent();
        }
        public int ProductId { get; set; }
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
            ItemRemovedFromOrderList?.Invoke(this, EventArgs.Empty);
            LinkedItemControl?.TriggerRemoveItemClicked();

        }
        private void DecreaseOrderButton_Click(object sender, EventArgs e)
        {
            if (Qty > 1)
            {
                Qty--;
                Quantity = Qty;
                TotalPrice = Quantity * (TotalPrice / (Quantity + 1));
                QuantityChanged?.Invoke(this, EventArgs.Empty);

                if (LinkedItemControl != null)
                {
                    LinkedItemControl.Quantity = Quantity;
                    LinkedItemControl.Total = TotalPrice;
                }
            }
            else
            {
                MessageBox.Show("Quantity cannot be less than 1.");
            }
        }

        private void IncreaseOrderButton_Click(object sender, EventArgs e)
        {
            Qty++;
            Quantity = Qty;
            TotalPrice = Quantity * (TotalPrice / (Quantity - 1));
            QuantityChanged?.Invoke(this, EventArgs.Empty);

            // Update the linked ItemUserControl
            if (LinkedItemControl != null)
            {
                LinkedItemControl.Quantity = Quantity;
                LinkedItemControl.Total = TotalPrice;
            }
        }

        private void QuantityTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(QuantityTextBox.Text, out var newQty) && newQty > 0)
            {
                Quantity = newQty;
                TotalPrice = Quantity * (TotalPrice / Qty);
                Qty = newQty;

                if (LinkedItemControl != null)
                {
                    LinkedItemControl.Quantity = newQty;
                    LinkedItemControl.Total = newQty * LinkedItemControl.Price;
                }

                QuantityChanged?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Invalid quantity entered.");
            }
        }
        
        public void UpdateQuantity(int newQuantity)
        {
            Qty = newQuantity;
            Quantity = newQuantity;
            TotalPrice = newQuantity * (TotalPrice / Qty);

            QuantityChanged?.Invoke(this, EventArgs.Empty);
        }

    }
}
