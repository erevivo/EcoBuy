using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EcoBuy.UserControls
{
    /// <summary>
    /// Interaction logic for PieChartUI.xaml
    /// </summary>
    public partial class PieChartUI : UserControl
    {
        public int Food { get; set; }

        public PieChartUI()
        {
            InitializeComponent();
        PointLabel = chartPoint =>
                string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
 
            DataContext = this;
        }
 
        public Func<ChartPoint, string> PointLabel { get; set; }
 
        private void Chart_OnDataClick(object sender, ChartPoint chartpoint)
        {
            var chart = (LiveCharts.Wpf.PieChart) chartpoint.ChartView;
            
            //clear selected slice.
            foreach (PieSeries series in chart.Series)
                series.PushOut = 0;
 
            var selectedSeries = (PieSeries) chartpoint.SeriesView;
            selectedSeries.PushOut = 8;
        }

        private void UserControlBG_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}