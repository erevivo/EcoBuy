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

            Dictionary<ProductsCategory, Dictionary<int, double>> dict = getPriceByCategoriesFor5Months(PurchasedProducts);

            CategoriesExpenses.Electricity = new List<double>() { 0,0,0,0,0 };
            CategoriesExpenses.Food = new List<double>() { 0, 0, 0, 0, 0 };
            CategoriesExpenses.Health = new List<double>() { 0, 0, 0, 0, 0 };
            CategoriesExpenses.Fashion = new List<double>() { 0, 0, 0, 0, 0 };

            foreach (KeyValuePair<int, double> entry in dict[ProductsCategory.Electricity])
            {
                CategoriesExpenses.Electricity.Insert(4 - entry.Key, entry.Value);
            }
            foreach (KeyValuePair<int, double> entry in dict[ProductsCategory.Food])
            {
                CategoriesExpenses.Food.Insert(4 - entry.Key, entry.Value);
            }
            foreach (KeyValuePair<int, double> entry in dict[ProductsCategory.Health])
            {
                CategoriesExpenses.Health.Insert(4 - entry.Key, entry.Value);
            }
            foreach (KeyValuePair<int, double> entry in dict[ProductsCategory.Fashion])
            {
                CategoriesExpenses.Fashion.Insert(4 - entry.Key, entry.Value);
            }
            //בסוף הלולאה המערך יהיה מוכן
            /*CategoriesExpenses.Electricity = new List<double>() { 13, 11, 23, 41, 50 };
            CategoriesExpenses.Health = new List<double>() { 13, 11, 23, 41, 50 };
            CategoriesExpenses.Fashion = new List<double>() { 25, 70, 10, 20, 23 };
            CategoriesExpenses.Food = new List<double>() { 28, 30, 10, 60, 10 };*/

        }
        public void LabelsGen()
        {
            //Number Of Month 
            Labels = new string[5];
            for (int i = 0; i < 5; i++)
            {
                Labels[i] = (DateTime.Today.AddMonths(i - 4)).ToString("MMM", CultureInfo.InvariantCulture);
            }
            YFormatter = value => value.ToString("C");
        }
        public int InRange(PurchasedProduct Pr)
        {

            DateTime currentDate = DateTime.Now;
            //int range = (DateTime.Now - Pr.PurchaseDate();
            int range = (currentDate.Year - Pr.PurchaseDate.Year) * 12 + currentDate.Month - Pr.PurchaseDate.Month;
            return range;
        }
       
        public Dictionary<ProductsCategory, Dictionary<int, double>> getPriceByCategoriesFor5Months(ObservableCollection<PurchasedProduct> P)
        {
            Dictionary<ProductsCategory, Dictionary<int, double>> dict = new Dictionary<ProductsCategory, Dictionary<int, double>>();

            foreach (var item in P)
            {
                int range = InRange(item);
                if (range <= 4 && range >= 0)
                {
                    if (!dict.ContainsKey(item.Category))
                    {
                        dict[item.Category] = new Dictionary<int, double>();
                    }
                    if (!dict[item.Category].ContainsKey(range))
                        dict[item.Category][range] = 0;
                    dict[item.Category][range] += item.Price;
                }
            }
            return dict;
        }

    }
}