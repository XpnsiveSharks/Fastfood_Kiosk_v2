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
        public DashboardUserControl()
        {
            InitializeComponent();
        }

        private void DashboardUserControl_Load(object sender, EventArgs e)
        {
            pieChart.LegendLocation = LegendLocation.Bottom;
        }

        Func<ChartPoint, string> labelPoint = chartpoint => string.Format("{0} ({1:P)", chartpoint.Y, chartpoint.Participation);

        private void LoadButton_Click(object sender, EventArgs e)
        {
            SeriesCollection series = new SeriesCollection();
            foreach (var obj in orderDataSet.OrderDataTable)
                series.Add(new PieSeries() { Title = obj.Date.ToString(), Values = new ChartValues<int> { obj.Total_Sales }, DataLabels = true, LabelPoint = labelPoint });
            pieChart.Series = series;
        }

        private void OrderDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
