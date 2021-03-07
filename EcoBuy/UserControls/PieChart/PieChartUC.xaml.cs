using EcoBuy.Models;
using EcoBuy.ViewModels;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

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

        public static readonly DependencyProperty CategoriesCountProperty = DependencyProperty.Register(
                                                                    "CategoriesCount",
                                                                    typeof(CategoriesCount),
                                                                    typeof(PieChartUC),
                                                                    new PropertyMetadata(default(CategoriesCount)));

        public static readonly DependencyProperty TodayCommandProperty = DependencyProperty.Register(
                                                                    "TodayCommand",
                                                                    typeof(ICommand),
                                                                    typeof(PieChartUC),
                                                                    new PropertyMetadata(default(ICommand)));

        public static readonly DependencyProperty WeekCommandProperty = DependencyProperty.Register(
                                                                    "WeekCommand",
                                                                    typeof(ICommand),
                                                                    typeof(PieChartUC),
                                                                    new PropertyMetadata(default(ICommand)));

        public static readonly DependencyProperty MonthCommandProperty = DependencyProperty.Register(
                                                                    "MonthCommand",
                                                                    typeof(ICommand),
                                                                    typeof(PieChartUC),
                                                                    new PropertyMetadata(default(ICommand)));

        public PieChartDataModel CategoryPieChartModel
        {
            get => (PieChartDataModel)GetValue(CategoryPieChartModelProperty);
            set => SetValue(CategoryPieChartModelProperty, value);
        }

        public CategoriesCount CategoriesCount
        {
            get => (CategoriesCount)GetValue(CategoriesCountProperty);
            set => SetValue(CategoriesCountProperty, value);
        }

        public ICommand TodayCommand
        {
            get => (ICommand)GetValue(TodayCommandProperty);
            set => SetValue(TodayCommandProperty, value);
        }

        public ICommand WeekCommand
        {
            get => (ICommand)GetValue(WeekCommandProperty);
            set => SetValue(WeekCommandProperty, value);
        }

        public ICommand MonthCommand
        {
            get => (ICommand)GetValue(MonthCommandProperty);
            set => SetValue(MonthCommandProperty, value);
        }

        public PieChartUC()
        {
            InitializeComponent();

            CategoriesCount = new CategoriesCount();

            PointLabel = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
        }

        public Func<ChartPoint, string> PointLabel { get; set; }

        private void CreatePieChartData(CategoriesCount categoriesCount)
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