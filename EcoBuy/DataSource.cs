using EcoBuy.BE;
using EcoBuy.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoBuy
{
    public static class DataSource
    {
        public static ObservableCollection<Store> Stores = new ObservableCollection<Store>()
        {
                new Store(1, 200, "שופרסל"),
                new Store(1, 166, "יינות ביתן"),
                new Store(1, 133, "אושר עד"),
                new Store(1, 69, "מעיין 2000"),
                new Store(1, 106, "רמי לוי"),
                new Store(1, 201, "מחסני השוק"),
                new Store(1, 136, "ניו-פארם"),
                new Store(1, 137, "ראלף לורן"),
                new Store(1, 138, "מחסני חשמל"),

        };
        public static ObservableCollection<PurchasedProduct> PurchasedProducts = new ObservableCollection<PurchasedProduct>()
        {
            //
                new PurchasedProduct(new DateTime(2021, 3, 16), 10, 1, 1, "פתיתים אפויים 500 גר' אסם", "C:\\Users\\Evyatar\\Desktop\\2.jpg", ProductsCategory.Food, 200),
                new PurchasedProduct(new DateTime(2021, 3, 16), 5, 2, 2, "לחם אחיד פרוס אנג'ל", "C:\\Users\\Evyatar\\Desktop\\1.jpg", ProductsCategory.Food, 200),
                new PurchasedProduct(new DateTime(2021, 3, 16), 20, 3, 3, "חלב 3% שומן תנובה", "C:\\Users\\Evyatar\\Desktop\\3.jpg", ProductsCategory.Food, 200),
                new PurchasedProduct(new DateTime(2021, 3, 8), 5, 2, 2, "גבינת קוטג' 5% תנובה", "C:\\Users\\Evyatar\\Desktop\\4.jpg", ProductsCategory.Food, 200),
                new PurchasedProduct(new DateTime(2021, 2, 5), 20, 3, 3, "ממרח נוטלה 350 גר'", "https://www.farfel.co.il/wp-content/uploads/2018/01/127.jpg", ProductsCategory.Food, 200),
                new PurchasedProduct(new DateTime(2021, 2, 2), 5, 2, 2, "בושם לגברים Lacoste Essential 75 מ\"ל ", "https://superpharmstorage.blob.core.windows.net/hybris/products/desktop/medium/737052483214.jpg", ProductsCategory.Health, 136),
                new PurchasedProduct(new DateTime(2021, 3, 16), 20, 3, 3, "חולצת פולו ראלף לורן M", "C:\\Users\\Evyatar\\Desktop\\ral.jpg", ProductsCategory.Fashion, 137),
                new PurchasedProduct(new DateTime(2020, 12, 9), 35, 3, 3, "טלוויזיה Samsung QE65Q60T 4K ‏65 ‏אינטש", "https://img.zap.co.il/pics/3/2/5/1/56591523c.gif", ProductsCategory.Electricity, 139),
                new PurchasedProduct(new DateTime(2020, 11, 2), 45, 4, 4, "מחשב אינטל NUC", "https://www.ivory.co.il/files/catalog/org/1566199487C87HL.jpg", ProductsCategory.Electricity, 139)
            };

    };
    //public static List<PurchasedProduct> PurchasedProducts = new List<PurchasedProduct>();
    //new PurchasedProduct(new DateTime(2020, 3, 5), 10, 1, 1, "פתיתים אפויים 500 גר' אסם", "C:\\Users\\Evyatar\\Desktop\\2.jpg", ProductsCategory.Food , new Store(1,1,null))
}
