using EcoBuy.BE;
using EcoBuy.Commands.PieChart;
using EcoBuy.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EcoBuy.ViewModels
{
    public class PieChartUCVM : ViewModelBase
    {
        public CategoriesCount CategoriesCount { get; set; }
        public ObservableCollection<PurchasedProduct> PurchasedProducts { get; set; }
        public ICommand TodayCmd { get; set; }

        public PieChartUCVM()
        {
            Test();
            GroupByCategory();
            TodayCmd = new RelayCommand(() => FilterByDay());
        }

        private void Test()
        {
            CategoriesCount = new CategoriesCount();
            PurchasedProducts = new ObservableCollection<PurchasedProduct>()
            {
                new PurchasedProduct(new DateTime(2020, 3, 5), 10, 1, 1, "פתיתים אפויים 500 גר' אסם", "C:\\Users\\Evyatar\\Desktop\\2.jpg", ProductsCategory.Food),
                new PurchasedProduct(new DateTime(2020, 11, 2), 5, 2, 2, "לחם אחיד פרוס אנג'ל", "C:\\Users\\Evyatar\\Desktop\\1.jpg", ProductsCategory.Food),
                new PurchasedProduct(new DateTime(2020, 12, 2), 20, 3, 3, "חלב 3% שומן תנובה", "C:\\Users\\Evyatar\\Desktop\\3.jpg", ProductsCategory.Health),
                new PurchasedProduct(new DateTime(2020, 11, 2), 5, 2, 2, "גבינת קוטג' 5% תנובה", "https://www.tnuva.co.il/uploads/f_5d0f283c02962_1561274428.png", ProductsCategory.Food),
                new PurchasedProduct(new DateTime(2020, 3, 5), 20, 3, 3, "ממרח נוטלה 350 גר'", "https://www.farfel.co.il/wp-content/uploads/2018/01/127.jpg", ProductsCategory.Fashion),
                new PurchasedProduct(new DateTime(2020, 11, 2), 5, 2, 2, "בושם לגברים Lacoste Essential 75 מ\"ל ", "https://superpharmstorage.blob.core.windows.net/hybris/products/desktop/medium/737052483214.jpg", ProductsCategory.Food),
                new PurchasedProduct(new DateTime(2020, 12, 2), 20, 3, 3, "חולצת פולו ראלף לורן M", "C:\\Users\\Evyatar\\Desktop\\ral.jpg", ProductsCategory.Fashion),
                new PurchasedProduct(new DateTime(2020, 12, 2), 3793, 3, 3, "טלוויזיה Samsung QE65Q60T 4K ‏65 ‏אינטש", "https://img.zap.co.il/pics/3/2/5/1/56591523c.gif", ProductsCategory.Health),
                new PurchasedProduct(new DateTime(2020, 12, 2), 7, 4, 4, "מחשב אינטל NUC", "https://www.ivory.co.il/files/catalog/org/1566199487C87HL.jpg", ProductsCategory.Electricity)
            };

        }
        public void GroupByCategory()
        {
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
        public void FilterByDay()
        {
            PurchasedProducts = (ObservableCollection<PurchasedProduct>)PurchasedProducts.Where(prod => prod.PurchaseDate == DateTime.Now);
        }
    }
}
