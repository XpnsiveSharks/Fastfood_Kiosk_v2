using Fastfood_Kiosk_v2.Helpers;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Fastfood_Kiosk_v2.Views.AdminViews.AdminViewsUserControl
{
    public partial class DashboardUserControl : UserControl
    {
        SalesData salesData = new SalesData();
        public DashboardUserControl()
        {
            InitializeComponent();
            LoadData();
           
        }
        private void LoadChart()
        {
            var dailySales = salesData.GetSalesData();
            pieChart.Series.Clear();
            foreach (var sale in dailySales)
            {
                pieChart.Series.Add(new PieSeries
                {
                    Title = sale.OrderDate.ToShortDateString(),
                    Values = new ChartValues<int> { sale.OrderCount },
                    DataLabels = true,
                    LabelPoint = chartPoint => $"{chartPoint.Y} Orders ({chartPoint.Participation:P})"
                });
            }
            pieChart.LegendLocation = LegendLocation.Bottom;
        }   
        private void LoadDataGridView(List<SalesData> dailySales)
        {
            OrderDataGridView.DataSource = null;
            OrderDataGridView.DataSource = dailySales;
        }
        private void LoadData()
        {
            var dailySales = salesData.GetSalesData();
            LoadChart();
            LoadDataGridView(dailySales);
        }
        private void LoadButton_Click(object sender, EventArgs e)
        {
            LoadChart();
        }



        private void DashboardUserControl_Load(object sender, EventArgs e)
        {

        }
        private void OrderDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
