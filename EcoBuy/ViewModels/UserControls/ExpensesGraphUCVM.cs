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
            Dictionary<ProductsCategory, Dictionary<int, double>> dict = getPriceByCategoriesFor5Months(PurchasedProducts);
            CategoriesExpenses.Electricity = new List<double>() { 0, 0, 0, 0, 0 };
            CategoriesExpenses.Food = new List<double>() { 0, 0, 0, 0, 0 };
            CategoriesExpenses.Health = new List<double>() { 0, 0, 0, 0, 0 };
            CategoriesExpenses.Fashion = new List<double>() { 0, 0, 0, 0, 0 };

            foreach (KeyValuePair<int, double> entry in dict[ProductsCategory.Electricity])
            {
                CategoriesExpenses.Electricity[4 - entry.Key] = entry.Value;
            }
            foreach (KeyValuePair<int, double> entry in dict[ProductsCategory.Food])
            {
                CategoriesExpenses.Food[4 - entry.Key] = entry.Value;
            }
            foreach (KeyValuePair<int, double> entry in dict[ProductsCategory.Health])
            {
                CategoriesExpenses.Health[4 - entry.Key] = entry.Value;
            }
            foreach (KeyValuePair<int, double> entry in dict[ProductsCategory.Fashion])
            {
                CategoriesExpenses.Fashion[4 - entry.Key] = entry.Value;
            }
        }
        public void LabelsGen()
        {
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