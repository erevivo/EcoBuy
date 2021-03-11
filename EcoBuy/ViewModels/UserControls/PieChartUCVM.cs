using EcoBuy.BE;
using EcoBuy.Commands.PieChart;
using EcoBuy.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;

namespace EcoBuy.ViewModels
{
    public class PieChartUCVM : ViewModelBase
    {
        #region Properties
        public CategoriesCount CategoriesCount { get; set; }
        public ObservableCollection<PurchasedProduct> PurchasedProducts { get; set; }
        public ICommand TodayCmd { get; set; }
        public ICommand WeekCmd { get; set; }
        public ICommand MonthCmd { get; set; }
        #endregion

        // Constructor
        public PieChartUCVM()
        {
            Test();
            GroupByCategory();
            TodayCmd = new RelayCommand(() => FilterByDay());
            WeekCmd = new RelayCommand(() => FilterByWeek());
            MonthCmd = new RelayCommand(() => FilterByMonth());

           
        }

        private void Test()
        {
            CategoriesCount = new CategoriesCount();
            PurchasedProducts = new ObservableCollection<PurchasedProduct>(DataSource.PurchasedProducts);
        }
        public void GroupByCategory()
        {
            CategoriesCount.Food = 0;
            CategoriesCount.Electricity = 0;
            CategoriesCount.Health = 0;
            CategoriesCount.Fashion = 0;

            foreach (var product in PurchasedProducts.GroupBy(p => p.Category)
                                    .Select(group => new
                                    {
                                        cate = group.Key,
                                        Count = group.Count()
                                    })
                                    .OrderBy(x => x.cate))
            {
                switch (product.cate)
                {
                    case ProductsCategory.Food:
                        CategoriesCount.Food = product.Count;
                        break;

                    case ProductsCategory.Electricity:
                        CategoriesCount.Electricity = product.Count;
                        break;
                    case ProductsCategory.Health:
                        CategoriesCount.Health = product.Count;
                        break;
                    case ProductsCategory.Fashion:
                        CategoriesCount.Fashion = product.Count;
                        break;
                    default:
                        Console.WriteLine("Nothing");
                        break;
                }
            }
        }
        private void FilterByDay()
        {
            Test();
            var items = this.PurchasedProducts.Where(prod => prod.PurchaseDate == DateTime.Now.Date);
            PurchasedProducts = new ObservableCollection<PurchasedProduct>(items);
            GroupByCategory();
        }

        public void FilterByWeek()
        {
            Test();
            DateTime date = DateTime.Now;
            var Start = date.Date.AddDays(-(int)date.DayOfWeek);
            var End = Start.AddDays(7).AddSeconds(-1);
            var items = this.PurchasedProducts.Where(prod => prod.PurchaseDate >= Start && prod.PurchaseDate<=End);
            PurchasedProducts = new ObservableCollection<PurchasedProduct>(items);
            GroupByCategory();
            CategoriesCount = new CategoriesCount(CategoriesCount);
        }

        public void FilterByMonth()
        {
            Test();
            var items = this.PurchasedProducts.Where(prod => prod.PurchaseDate.Month == DateTime.Now.Month);
            PurchasedProducts = new ObservableCollection<PurchasedProduct>(items);
            GroupByCategory();
            CategoriesCount = new CategoriesCount(CategoriesCount);
        }

    }
}
