using Fastfood_Kiosk_v2.Views.Customer.CustomerOrderingComponentsUserControls;
using System;
using System.Windows.Forms;

namespace Fastfood_Kiosk_v2.Views.Customer.CustomerUserControls
{
    public partial class CartUserControl : UserControl
    {
        public CartUserControl()
        {
            InitializeComponent();
        }
        public FlowLayoutPanel itemsFlowLayoutPanel
        {
            get { return this.ItemsFlowLayoutPanel; }
        }
        public double SubTotal
        {
            get => double.TryParse(SubTotalLabel.Text, out var price) ? price : 0;
            set => SubTotalLabel.Text = value.ToString("F2");
        }
        public void AddItem(ItemUserControl itemControl)
        {
            if (itemControl == null) throw new ArgumentNullException(nameof(itemControl));
            itemControl.RemoveItemClicked += OnRemoveItemClicked;
            ItemsFlowLayoutPanel.Controls.Add(itemControl);
        }
        private void OnRemoveItemClicked(object sender, EventArgs e)
        {
            if (sender is ItemUserControl itemControl)
            {
                ItemsFlowLayoutPanel.Controls.Remove(itemControl);
                itemControl.Dispose();
                UpdateSubtotal();
            }
        }
        public void UpdateSubtotal()
        {
            double subtotal = 0;
            foreach (ItemUserControl item in itemsFlowLayoutPanel.Controls)
            {
                subtotal += item.Total;
            }
            SubTotal = subtotal;

            if (ItemsFlowLayoutPanel.Controls.Count == 0)
            {
                SubTotal = 0;
            }
        }
        private void ClearOrderButton_Click(object sender, EventArgs e)
        {
            ItemsFlowLayoutPanel.Controls.Clear();
            SubTotal = 0;
        }
        private void ProceedButton_Click(object sender, EventArgs e)
        {
            if(SubTotal != 0)
                MessageBox.Show($"Proceeding with order. Subtotal: {SubTotal:C}");
            else
                MessageBox.Show($"Please add  items");  
        }
    }
}
