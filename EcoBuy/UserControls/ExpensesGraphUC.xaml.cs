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
        public ExpensesGraphUC()
        {
            InitializeComponent();

           SeriesCollection = new SeriesCollection
            {
                 new LineSeries
                  {
                      Title = "חשמל",
                      Values = new ChartValues<double> { 4, 6, 5, 2 ,4 },
                      LineSmoothness = 0, //0: straight lines, 1: really smooth lines
                      PointGeometry = DefaultGeometries.Circle
                  }/*,
                  new LineSeries
                  {
                      Title = "אופנה",
                      Values = new ChartValues<double> { 6, 7, 3, 4 ,6 },
                      LineSmoothness = 0, //0: straight lines, 1: really smooth lines
                      PointGeometry = DefaultGeometries.Circle,
                  },
                  new LineSeries
                  {
                      Title = "מזון",
                      Values = new ChartValues<double> { 4,2,7,2,7 },
                      LineSmoothness = 0, //0: straight lines, 1: really smooth lines
                      PointGeometry = DefaultGeometries.Circle
                  },
                  new LineSeries
                  {
                  Title = "בריאות",
                  Values = new ChartValues<double> { 5, 3, 2, 4 },
                  LineSmoothness = 0, //0: straight lines, 1: really smooth lines
                  PointGeometry = DefaultGeometries.Circle
                   },*/
           };
            string a = (DateTime.Today.AddMonths(-4)).ToString("MMM", CultureInfo.InvariantCulture);
            string b = (DateTime.Today.AddMonths(-3)).ToString("MMM", CultureInfo.InvariantCulture);
            string c = (DateTime.Today.AddMonths(-2)).ToString("MMM", CultureInfo.InvariantCulture);
            string d = (DateTime.Today.AddMonths(-1)).ToString("MMM", CultureInfo.InvariantCulture);
            string e = (DateTime.Today).ToString("MMM", CultureInfo.InvariantCulture);

            Labels = new[] { a, b, c, d, e };
            YFormatter = value => value.ToString("C");

            //modifying the series collection will animate and update the chart


            //modifying any series values will also animate and update the chart
            SeriesCollection[0].Values.Add(5d);

            DataContext = this;
        }

        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> YFormatter { get; set; }

    }
}