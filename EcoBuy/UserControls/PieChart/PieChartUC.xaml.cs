using EcoBuy.Models;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace EcoBuy.UserControls
{
    /// <summary>
    /// Interaction logic for PieChartUC.xaml
    /// </summary>
    public partial class PieChartUC : UserControl
    {
        public static readonly DependencyProperty CategoryPieChartModelProperty = DependencyProperty.Register(
                                                                               "CategoryPieChartModel",
                                                                               typeof(PieChartDataModel),
                                                                               typeof(PieChartUC),
                                                                               new PropertyMetadata(default(PieChartDataModel)));
        public PieChartDataModel CategoryPieChartModel
        {
            get => (PieChartDataModel)GetValue(PieChartUC.CategoryPieChartModelProperty);
            set => SetValue(PieChartUC.CategoryPieChartModelProperty, value);
        }

        public CategoiesCount CategoiesCount = new CategoiesCount();

        public PieChartUC()
        {
            InitializeComponent();

            DataContext = this;

            PointLabel = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
            
            CreatePieChartData(CategoiesCount);

            Task.Delay(2000).ContinueWith(t =>
            {
                Dispatcher.Invoke(() =>
                {
                    CreatePieChartData(new CategoiesCount() { Electricity = 10, Fashion = 5, Food = 5, Health = 20 });
                });
                
            });
        }

        public Func<ChartPoint, string> PointLabel { get; set; }

        private void CreatePieChartData(CategoiesCount categoriesCount)
        {
            this.CategoryPieChartModel = new PieChartDataModel(categoriesCount);
        }

        private void Chart_OnDataClick(object sender, ChartPoint chartpoint)
        {
            var chart = (LiveCharts.Wpf.PieChart)chartpoint.ChartView;

            //clear selected slice.
            foreach (PieSeries series in chart.Series)
                series.PushOut = 0;

            var selectedSeries = (PieSeries)chartpoint.SeriesView;
            selectedSeries.PushOut = 8;
        }
    }
}