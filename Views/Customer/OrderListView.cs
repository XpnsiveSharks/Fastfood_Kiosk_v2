using Fastfood_Kiosk_v2.Views.Customer.CustomerOrderingComponentsUserControls;
using Fastfood_Kiosk_v2.Views.Customer.CustomerUserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fastfood_Kiosk_v2.Views.Customer
{
    public partial class OrderListView : Form
    {
        public List<OrderListUserControl> OrderItems { get; set; } = new List<OrderListUserControl>();
        //private OrderListView orderListView = new OrderListView();
        public OrderListView()
        {
            InitializeComponent();

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
                // Subscribe to the ItemRemoved event
                orderItem.ItemRemoved += OnItemRemoved;
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
        private void AddMoreButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void UpdateSubtotal()
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
        }
        private void OnQuantityChanged(object sender, EventArgs e)
        {
            // Recalculate subtotal when quantities change
            UpdateSubtotal();
        }

    }


}
