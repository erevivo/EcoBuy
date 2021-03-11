using EcoBuy.BE;
using EcoBuy.Models;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;


namespace EcoBuy.ViewModels
{
    public class ExpensesGraphUCVM : ViewModelBase
    {
        #region Properties
        public CategoriesExpenses CategoriesExpenses { get; set; }
        public ObservableCollection<PurchasedProduct> PurchasedProducts { get; set; }
        public ObservableCollection<double> Electricity { get; set; }
        public ObservableCollection<double> Fashion { get; set; }
        public ObservableCollection<double> Food { get; set; }
        public ObservableCollection<double> Health { get; set; }
        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> YFormatter { get; set; }
        #endregion
        //public SeriesCollection SeriesCollection { get; set; }

        public ExpensesGraphUCVM()
        {
            Test();
            GroupByCategory();
            LabelsGen();

        }

        private void Test()
        {
            CategoriesExpenses = new CategoriesExpenses();
            PurchasedProducts = new ObservableCollection<PurchasedProduct>(DataSource.PurchasedProducts);
        }
        public void GroupByCategory()
        {
            int a = DateTime.Today.AddMonths(-4).Month;
            int b = DateTime.Today.AddMonths(-3).Month;
            int c = DateTime.Today.AddMonths(-2).Month;
            int d = DateTime.Today.AddMonths(-1).Month;
            int e = DateTime.Today.Month;

            CategoriesExpenses.Electricity = new List<double>() { 10, 40, 50, 60, 20 };
            CategoriesExpenses.Health = new List<double>() { 13, 11, 23, 41, 50 };
            CategoriesExpenses.Fashion = new List<double>() { 25, 70, 10, 20, 23 };
            CategoriesExpenses.Food = new List<double>() { 28, 30, 10, 60, 10 };

    }
        public void LabelsGen()
        {
            //Number Of Month 
            Labels = new string[5];
            for (int i = 0; i < 5; i++)
            {
                Labels[i] = (DateTime.Today.AddMonths(i-4)).ToString("MMM", CultureInfo.InvariantCulture);
            }
            YFormatter = value => value.ToString("C");
        }

    }
}
