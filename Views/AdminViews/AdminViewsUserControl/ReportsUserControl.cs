using Fastfood_Kiosk_v2.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Fastfood_Kiosk_v2.Views.AdminViews.AdminViewsUserControl
{
    public partial class ReportsUserControl : UserControl
    {
        private OrdersViewModel _ordersViewModel;

        public ReportsUserControl()
        {
            InitializeComponent();
            _ordersViewModel = new OrdersViewModel();
            LoadData();
        }

        private void LoadData(string startDate = null, string endDate = null)
        {
            // Load orders using the ViewModel
            var orders = _ordersViewModel.LoadOrders(startDate, endDate);

            // Bind the data to the DataGridView
            ReportsDataGridView.AutoGenerateColumns = true;
            ReportsDataGridView.DataSource = orders;
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            // Get the selected date range
            string startDate = dtpStartDate.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string endDate = dtpEndDate.Value.ToString("yyyy-MM-dd HH:mm:ss");

            // Reload data with filters
            LoadData(startDate, endDate);
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell click events, if needed
        }
    }
}
