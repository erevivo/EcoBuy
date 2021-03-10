using EcoBuy.Models;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public ObservableCollection<double> F { get; set; }
        public CategoriesExpenses CategoriesExpenses { get; set; }
        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> YFormatter { get; set; }

        public ExpensesGraphUC()
        {
            InitializeComponent();
            Test();
            F = new ObservableCollection<double>() { 10, 40, 50, 60, 20 };

            string a = (DateTime.Today.AddMonths(-4)).ToString("MMM", CultureInfo.InvariantCulture);
            string b = (DateTime.Today.AddMonths(-3)).ToString("MMM", CultureInfo.InvariantCulture);
            string c = (DateTime.Today.AddMonths(-2)).ToString("MMM", CultureInfo.InvariantCulture);
            string d = (DateTime.Today.AddMonths(-1)).ToString("MMM", CultureInfo.InvariantCulture);
            string e = (DateTime.Today).ToString("MMM", CultureInfo.InvariantCulture);

            Labels = new[] { a, b, c, d, e };
            YFormatter = value => value.ToString("C");

            //modifying the series collection will animate and update the chart


            //modifying any series values will also animate and update the chart
            //SeriesCollection[0].Values.Add(5d);

           // DataContext = this;
        }
        
        void Test()
        {
            CategoriesExpenses = new CategoriesExpenses()
            {
                Electricity = new List<double>() { 100, 50, 70, 10, 20 },
                Food = new List<double>() { 10, 10, 40, 30, 50 },
                Health = new List<double>() { 11, 43, 12, 25, 60 },
                Fashion = new List<double>() { 18, 26, 51, 33, 40 }
            };

        }
        

    }
}