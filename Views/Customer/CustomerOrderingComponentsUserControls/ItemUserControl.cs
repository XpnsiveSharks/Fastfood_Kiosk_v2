using Fastfood_Kiosk_v2.Models;
using Fastfood_Kiosk_v2.Views.Customer.CustomerUserControls;
using System;
using System.Windows.Forms;

namespace Fastfood_Kiosk_v2.Views.Customer.CustomerOrderingComponentsUserControls
{
    public partial class ItemUserControl : UserControl
    {
        public event EventHandler RemoveItemClicked;
        public OrderListUserControl LinkedOrderControl { get; set; }

        public ItemUserControl()
        {
            InitializeComponent();

        }
        public string Product 
        { 
            get => ProductLabel.Text; 
            set => ProductLabel.Text = value; 
        }
        public int ProductId { get; set; }
        public double Price 
        {
            get => double.TryParse(PriceLabel.Text, out var price) ? price : 0;
            set => PriceLabel.Text = value.ToString("F2");
        }
        public int Quantity
        {
            get => int.TryParse(QuantityLabel.Text, out var quantity) ? quantity : 0;
            set
            {
                QuantityLabel.Text = value.ToString();
                Total = value * Price;
                LinkedOrderControl?.UpdateQuantity(value);//
            }
        }

        public double Total
        { 
            get => double.TryParse(TotalLabel.Text, out var total) ? total : 0; 
            set => TotalLabel.Text = value.ToString(); 
        }
        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            RemoveItemClicked?.Invoke(this, EventArgs.Empty);
            Console.WriteLine("Remove");
        }

        private void PriceLabel_Click(object sender, EventArgs e)
        {

        }
        public void TriggerRemoveItemClicked()
        {
            RemoveItemClicked?.Invoke(this, EventArgs.Empty);
        }

    }
}
