using EcoBuy.Models;
using EcoBuy.ViewModels;
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

        public static readonly DependencyProperty CategoiesCountProperty = DependencyProperty.Register(
                                                                    "CategoiesCount",
                                                                    typeof(CategoiesCount),
                                                                    typeof(PieChartUC),
                                                                    new PropertyMetadata(default(CategoiesCount)));

        public PieChartDataModel CategoryPieChartModel
        {
            get => (PieChartDataModel)GetValue(PieChartUC.CategoryPieChartModelProperty);
            set => SetValue(PieChartUC.CategoryPieChartModelProperty, value);
        }

        public CategoiesCount CategoiesCount
        {
            get => (CategoiesCount)GetValue(PieChartUC.CategoiesCountProperty);
            set => SetValue(PieChartUC.CategoiesCountProperty, value);
        }

        public PieChartUC()
        {
            InitializeComponent();

            CategoiesCount = new CategoiesCount();

            PointLabel = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
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