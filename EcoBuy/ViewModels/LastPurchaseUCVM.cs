using EcoBuy.BE;
using EcoBuy.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoBuy.ViewModels
{
    public class LastPurchaseUCVM : ViewModelBase
    {
        #region Private Fields

        private string _searchText;
        private ObservableCollection<PurchasedProduct> _originalItems;

        #endregion

        #region Constructor
        public ObservableCollection<PurchasedProduct> PurchasedProducts { get; set; }
        public ObservableCollection<PurchasedProduct> LastPurchasedList { get; set; }
        public LastPurchaseUCVM()
        {
            Test();
            LastPurchase();
        }

        public void Test()
        {
            PurchasedProducts = new ObservableCollection<PurchasedProduct>()
            {
                new PurchasedProduct(new DateTime(2020, 10, 2), 10, 1, 1, "פתיתים אפויים 500 גר' אסם", "C:\\Users\\Evyatar\\Desktop\\2.jpg", ProductsCategory.Food),
                new PurchasedProduct(new DateTime(2020, 10, 2), 5, 2, 2, "לחם אחיד פרוס אנג'ל", "C:\\Users\\Evyatar\\Desktop\\1.jpg", ProductsCategory.Food),
                new PurchasedProduct(new DateTime(2020, 12, 2), 20, 3, 3, "חלב 3% שומן תנובה", "C:\\Users\\Evyatar\\Desktop\\3.jpg", ProductsCategory.Food),
                new PurchasedProduct(new DateTime(2020, 12, 2), 5, 2, 2, "גבינת קוטג' 5% תנובה", "https://www.boker.co.il/UserFiles/web_pages/picture_102.jpg", ProductsCategory.Food),
                new PurchasedProduct(new DateTime(2020, 11, 2), 20, 3, 3, "ממרח נוטלה 350 גר'", "https://www.farfel.co.il/wp-content/uploads/2018/01/127.jpg", ProductsCategory.Food),
                new PurchasedProduct(new DateTime(2020, 11, 2), 5, 2, 2, "בושם לגברים Lacoste Essential 75 מ\"ל ", "https://superpharmstorage.blob.core.windows.net/hybris/products/desktop/medium/737052483214.jpg", ProductsCategory.Food),
                new PurchasedProduct(new DateTime(2020, 12, 2), 20, 3, 3, "חולצת פולו ראלף לורן M", "C:\\Users\\Evyatar\\Desktop\\ral.jpg", ProductsCategory.Food),
                new PurchasedProduct(new DateTime(2020, 12, 2), 3793, 3, 3, "טלוויזיה Samsung QE65Q60T 4K ‏65 ‏אינטש", "https://img.zap.co.il/pics/3/2/5/1/56591523c.gif", ProductsCategory.Electricity),
                new PurchasedProduct(new DateTime(2020, 12, 2), 7, 4, 4, "מחשב אינטל NUC", "https://www.ivory.co.il/files/catalog/org/1566199487C87HL.jpg", ProductsCategory.Electricity)
            };
        }

        public void LastPurchase()
        {
            DateTime? lastDate = PurchasedProducts.Max(p => p.PurchaseDate).Date;
            PurchasedProducts = new ObservableCollection<PurchasedProduct>(PurchasedProducts.Where(p => p.PurchaseDate == lastDate));
        }

        #endregion
    }
}
