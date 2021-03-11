using EcoBuy.Models;
using EcoBuy.ViewModels;
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
        #region DependencyProperties
        public static readonly DependencyProperty ElectricityProperty = DependencyProperty.Register(
                                                            "Electricity",
                                                            typeof(CategoriesExpenses),
                                                            typeof(ExpensesGraphUC),
                                                            new PropertyMetadata(default(CategoriesExpenses)));
        #endregion
        #region Properties
        public CategoriesExpenses CategoriesExpenses
        {
            get => (CategoriesExpenses)GetValue(ElectricityProperty);
            set => SetValue(ElectricityProperty, value);
        }
        #endregion
        public ExpensesGraphUC()
        {
            InitializeComponent();
            this.DataContext = new ExpensesGraphUCVM();
            Test();
           

            //modifying the series collection will animate and update the chart


            //modifying any series values will also animate and update the chart
            //SeriesCollection[0].Values.Add(5d);

           // DataContext = this;
        }
        void Test()
        {

        }
    }
}