using EcoBuy.BE;
using EcoBuy.Commands;
using EcoBuy.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace EcoBuy.ViewModels
{
    public class LastPurchaseUCVM : ViewModelBase
    {

        #region Properties
        public ObservableCollection<PurchasedProduct> PurchasedProducts { get; set; }
        public PrintCommand PrintCmd { get; set; }
        public string LpLable;
        public ObservableCollection<PurchasedProduct> LastPurchasedList { get; set; }
        public DataGrid DataGridPurchasedList { get; set; }
        #endregion


        #region Constractor
        public LastPurchaseUCVM()
        {
            Test();
            LastPurchase();
            PrintCmd = new PrintCommand(this);
            LpLable = PurchasedProducts.Max(p => p.PurchaseDate).Date.ToString();
            DataGridPurchasedList = new DataGrid();
            DataGridPurchasedList.ItemsSource = PurchasedProducts;
        }
        #endregion

        public void Test()
        {
            PurchasedProducts = new ObservableCollection<PurchasedProduct>()
            {
                new PurchasedProduct(new DateTime(2021, 3, 9), 10, 1, 1, "פתיתים אפויים 500 גר' אסם", "C:\\Users\\Evyatar\\Desktop\\2.jpg", ProductsCategory.Food),
                new PurchasedProduct(new DateTime(2021, 3, 9), 5, 2, 2, "לחם אחיד פרוס אנג'ל", "C:\\Users\\Evyatar\\Desktop\\1.jpg", ProductsCategory.Food),
                new PurchasedProduct(new DateTime(2021, 3, 9), 20, 3, 3, "חלב 3% שומן תנובה", "C:\\Users\\Evyatar\\Desktop\\3.jpg", ProductsCategory.Food),
                new PurchasedProduct(new DateTime(2021, 3, 8), 5, 2, 2, "גבינת קוטג' 5% תנובה", "C:\\Users\\Evyatar\\Desktop\\4.jpg", ProductsCategory.Food),
                new PurchasedProduct(new DateTime(2021, 3, 5), 20, 3, 3, "ממרח נוטלה 350 גר'", "https://www.farfel.co.il/wp-content/uploads/2018/01/127.jpg", ProductsCategory.Food),
                new PurchasedProduct(new DateTime(2021, 1, 2), 5, 2, 2, "בושם לגברים Lacoste Essential 75 מ\"ל ", "https://superpharmstorage.blob.core.windows.net/hybris/products/desktop/medium/737052483214.jpg", ProductsCategory.Health),
                new PurchasedProduct(new DateTime(2021, 03, 7), 20, 3, 3, "חולצת פולו ראלף לורן M", "C:\\Users\\Evyatar\\Desktop\\ral.jpg", ProductsCategory.Fashion),
                new PurchasedProduct(new DateTime(2021, 3, 9), 3793, 3, 3, "טלוויזיה Samsung QE65Q60T 4K ‏65 ‏אינטש", "https://img.zap.co.il/pics/3/2/5/1/56591523c.gif", ProductsCategory.Electricity),
                new PurchasedProduct(new DateTime(2021, 3, 2), 7, 4, 4, "מחשב אינטל NUC", "https://www.ivory.co.il/files/catalog/org/1566199487C87HL.jpg", ProductsCategory.Electricity)
            };
        }

        public void LastPurchase()
        {
            DateTime? lastDate = PurchasedProducts.Max(p => p.PurchaseDate).Date;
            PurchasedProducts = new ObservableCollection<PurchasedProduct>(PurchasedProducts.Where(p => p.PurchaseDate == lastDate));
        }
    }
}
