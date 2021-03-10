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
            PurchasedProducts = new ObservableCollection<PurchasedProduct>()
            {
                new PurchasedProduct(new DateTime(2021, 3, 9), 10, 1, 1, "פתיתים אפויים 500 גר' אסם", "C:\\Users\\Evyatar\\Desktop\\2.jpg", ProductsCategory.Food),
                new PurchasedProduct(new DateTime(2021, 3, 9), 5, 2, 2, "לחם אחיד פרוס אנג'ל", "C:\\Users\\Evyatar\\Desktop\\1.jpg", ProductsCategory.Food),
                new PurchasedProduct(new DateTime(2021, 3, 9), 20, 3, 3, "חלב 3% שומן תנובה", "C:\\Users\\Evyatar\\Desktop\\3.jpg", ProductsCategory.Food),
                new PurchasedProduct(new DateTime(2021, 3, 8), 5, 2, 2, "גבינת קוטג' 5% תנובה", "https://www.tnuva.co.il/uploads/f_5d0f283c02962_1561274428.png", ProductsCategory.Food),
                new PurchasedProduct(new DateTime(2021, 3, 5), 20, 3, 3, "ממרח נוטלה 350 גר'", "https://www.farfel.co.il/wp-content/uploads/2018/01/127.jpg", ProductsCategory.Food),
                new PurchasedProduct(new DateTime(2021, 11, 2), 5, 2, 2, "בושם לגברים Lacoste Essential 75 מ\"ל ", "https://superpharmstorage.blob.core.windows.net/hybris/products/desktop/medium/737052483214.jpg", ProductsCategory.Health),
                new PurchasedProduct(new DateTime(2021, 03, 7), 20, 3, 3, "חולצת פולו ראלף לורן M", "C:\\Users\\Evyatar\\Desktop\\ral.jpg", ProductsCategory.Fashion),
                new PurchasedProduct(new DateTime(2021, 3, 9), 3793, 3, 3, "טלוויזיה Samsung QE65Q60T 4K ‏65 ‏אינטש", "https://img.zap.co.il/pics/3/2/5/1/56591523c.gif", ProductsCategory.Electricity),
                new PurchasedProduct(new DateTime(2021, 3, 2), 7, 4, 4, "מחשב אינטל NUC", "https://www.ivory.co.il/files/catalog/org/1566199487C87HL.jpg", ProductsCategory.Electricity)
            };
        }
        public void GroupByCategory()
        {
            CategoriesExpenses.Electricity = new List<double>() { 10, 40, 50, 60, 20 };
            CategoriesExpenses.Health = new List<double>() { 13, 11, 23, 41, 50 };
            CategoriesExpenses.Fashion = new List<double>() { 25, 70, 10, 20, 23 };
            CategoriesExpenses.Food = new List<double>() { 28, 30, 10, 60, 10 };



            //Electricity = new ObservableCollection<double>() { 10, 40, 50, 60, 20 };
            //Fashion = new ObservableCollection<double>() { 30, 11, 23, 41, 50 };
            //Food = new ObservableCollection<double>() { 10, 70, 10, 20, 23 };
            //Health = new ObservableCollection<double>() { 10, 30, 10, 60, 10 };
        }
        public void LabelsGen()
        {

            string a = (DateTime.Today.AddMonths(-4)).ToString("MMM", CultureInfo.InvariantCulture);
            string b = (DateTime.Today.AddMonths(-3)).ToString("MMM", CultureInfo.InvariantCulture);
            string c = (DateTime.Today.AddMonths(-2)).ToString("MMM", CultureInfo.InvariantCulture);
            string d = (DateTime.Today.AddMonths(-1)).ToString("MMM", CultureInfo.InvariantCulture);
            string e = (DateTime.Today).ToString("MMM", CultureInfo.InvariantCulture);

            Labels = new[] { a, b, c, d, e };
            YFormatter = value => value.ToString("C");
        }

    }
}
