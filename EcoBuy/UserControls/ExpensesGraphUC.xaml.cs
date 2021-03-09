using EcoBuy.Models;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Globalization;
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
    /// Interaction logic for ExpensesGraphUC.xaml
    /// </summary>
    public partial class ExpensesGraphUC : UserControl
    {
        #region Dependency Properties
        public static readonly DependencyProperty CategoriesExpensesModelProperty = DependencyProperty.Register(
                                                                    "CategoryPieChartModel",
                                                                    typeof(ExpensesGraphDataModel),
                                                                    typeof(ExpensesGraphUC),
                                                                    new PropertyMetadata(default(ExpensesGraphDataModel)));

        public static readonly DependencyProperty CategoriesExpensesProperty = DependencyProperty.Register(
                                                                    "CategoriesExpenses",
                                                                    typeof(CategoriesExpenses),
                                                                    typeof(ExpensesGraphUC),
                                                                    new PropertyMetadata(default(CategoriesExpenses)));

        #endregion

        #region Properties
        public ExpensesGraphDataModel ExpensesGraphDataModel
        {
            get => (ExpensesGraphDataModel)GetValue(CategoriesExpensesModelProperty);
            set => SetValue(CategoriesExpensesModelProperty, value);
        }

        public CategoriesExpenses CategoriesExpenses
        {
            get => (CategoriesExpenses)GetValue(CategoriesExpensesProperty);
            set => SetValue(CategoriesExpensesProperty, value);
        }

        public Func<ChartPoint, string> PointLabel { get; set; }
        #endregion
        public ExpensesGraphUC()
        {
            InitializeComponent();
            CategoriesExpenses = new CategoriesExpenses();
            PointLabel = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            string a = (DateTime.Today.AddMonths(-4)).ToString("MMM", CultureInfo.InvariantCulture);
            string b = (DateTime.Today.AddMonths(-3)).ToString("MMM", CultureInfo.InvariantCulture);
            string c = (DateTime.Today.AddMonths(-2)).ToString("MMM", CultureInfo.InvariantCulture);
            string d = (DateTime.Today.AddMonths(-1)).ToString("MMM", CultureInfo.InvariantCulture);
            string e = (DateTime.Today).ToString("MMM", CultureInfo.InvariantCulture);

            Labels = new[] { a, b, c, d, e };
            YFormatter = value => value.ToString("C");
        }
        private void CreatePieChartData(CategoriesExpenses categoriesExpenses)
        {
            this.ExpensesGraphDataModel = new ExpensesGraphDataModel(categoriesExpenses);
        }
        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> YFormatter { get; set; }

    }
}