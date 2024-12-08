using Fastfood_Kiosk_v2.Views.Customer.CustomerUserControls;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Windows.Forms;

namespace Fastfood_Kiosk_v2.Views.Customer
{
    public partial class OrderListView : Form
    {
        public List<OrderListUserControl> OrderItems { get; set; } = new List<OrderListUserControl>();
        public string OrderType { get; set; }
        public OrderListView(string orderType)
        {
            InitializeComponent();
            OrderType = orderType;
        }
        public double SubTotal
        {
            get => double.TryParse(TotalLabel.Text, out var price) ? price : 0;
            set => TotalLabel.Text = value.ToString("F2");
        }
        private void CheckOutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order confirmed! Thank you.");
            this.Close(); 
        }
        private void OnItemRemoved(object sender, EventArgs e)
        {
            if (sender is OrderListUserControl orderItem)
            {
                OrderListFlowLayoutPanel.Controls.Remove(orderItem);
                OrderItems.Remove(orderItem);

                orderItem.Dispose(); 

                if (OrderListFlowLayoutPanel.Controls.Count == 0)
                {
                    MessageBox.Show("All items removed. Closing the order list.", "Cart Empty");
                    this.Close(); 
                }
                UpdateSubtotal();
            }
        }
        public void DisplayOrderItems()
        {
            OrderListFlowLayoutPanel.Controls.Clear();
            foreach (var orderItem in OrderItems)
            {
                orderItem.ItemRemovedFromOrderList += OnItemRemoved;
                orderItem.QuantityChanged += OnQuantityChanged;
                OrderListFlowLayoutPanel.Controls.Add(orderItem);
            }
            UpdateSubtotal();
        }     
        public void UpdateTotal()
        {
            double total = OrderItems.Sum(item => item.TotalPrice);
            SubTotal = total; 
        }    
        private void OnQuantityChanged(object sender, EventArgs e)
        {
            UpdateSubtotal();
        }
        private void AddMoreButton_Click(object sender, EventArgs e)
        {
            this.Hide(); 

        }

        public event Action<double> SubtotalUpdated;

        private void UpdateSubtotal()
        {
            double subtotal = 0;
            foreach (OrderListUserControl item in OrderListFlowLayoutPanel.Controls)
            {
                subtotal += item.TotalPrice;
            }
            SubTotal = subtotal;

            if (OrderListFlowLayoutPanel.Controls.Count == 0)
            {
                SubTotal = 0;
            }

            SubtotalUpdated?.Invoke(SubTotal);
        }
        private void CheckoutButton_Click_1(object sender, EventArgs e)
        {
            var paymentMethodView = new PaymentMethodView(OrderType, OrderItems);
            paymentMethodView.OrderListViewReference = this;
            paymentMethodView.Show();
            this.Hide();
        }

        private void TaxTextLabel_Click(object sender, EventArgs e)
        {

        }
    }


}
