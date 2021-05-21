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
    public static class DataSource2
    {
        public static ObservableCollection<Store> Stores = new ObservableCollection<Store>()
        {
                new Store(1, 200, "שופרסל"),
                new Store(2, 166, "יינות ביתן"),
                new Store(3, 133, "אושר עד"),
                new Store(4, 69, "מעיין 2000"),
                new Store(5, 106, "רמי לוי"),
                new Store(6, 201, "מחסני השוק"),
                new Store(7, 136, "ניו-פארם"),
                new Store(8, 137, "ראלף לורן"),
                new Store(9, 138, "מחסני חשמל"),

        };
        public static ObservableCollection<PurchasedProduct> PurchasedProducts = new ObservableCollection<PurchasedProduct>()
        {
            //
                new PurchasedProduct(new DateTime(2021, 3, 16), 10, 1, 11, "פתיתים אפויים 500 גר' אסם", "C:\\Users\\Evyatar\\Documents\\GitHub\\EcoBuy\\EcoBuy\\Images\\Product\\2.jpg", ProductsCategory.Food, 200),
                new PurchasedProduct(new DateTime(2021, 3, 16), 5, 2, 22, "לחם אחיד פרוס אנג'ל", "C:\\Users\\Evyatar\\Documents\\GitHub\\EcoBuy\\EcoBuy\\Images\\Product\\1.jpg", ProductsCategory.Food, 200),
                new PurchasedProduct(new DateTime(2021, 3, 16), 20, 3, 33, "חלב 3% שומן תנובה", "C:\\Users\\Evyatar\\Documents\\GitHub\\EcoBuy\\EcoBuy\\Images\\Product\\3.jpg", ProductsCategory.Food, 200),
                new PurchasedProduct(new DateTime(2021, 3, 16), 5, 4, 44, "גבינת קוטג' 5% תנובה", "C:\\Users\\Evyatar\\Documents\\GitHub\\EcoBuy\\EcoBuy\\Images\\Product\\4.jpg", ProductsCategory.Food, 200),
                new PurchasedProduct(new DateTime(2021, 3, 16), 20, 5, 55, "ממרח נוטלה 350 גר'", "https://www.farfel.co.il/wp-content/uploads/2018/01/127.jpg", ProductsCategory.Food, 200),
                new PurchasedProduct(new DateTime(2021, 3, 16), 5, 6, 66, "בושם לגברים Lacoste Essential 75 מ\"ל ", "https://superpharmstorage.blob.core.windows.net/hybris/products/desktop/medium/737052483214.jpg", ProductsCategory.Health, 136),
                new PurchasedProduct(new DateTime(2021, 3, 16), 20, 7, 77, "חולצת פולו ראלף לורן M", "C:\\Users\\Evyatar\\Desktop\\ral.jpg", ProductsCategory.Fashion, 137),
                new PurchasedProduct(new DateTime(2020, 12, 9), 35, 8, 88, "טלוויזיה Samsung QE65Q60T 4K ‏65 ‏אינטש", "https://img.zap.co.il/pics/3/2/5/1/56591523c.gif", ProductsCategory.Electricity, 138),
                new PurchasedProduct(new DateTime(2020, 11, 2), 45, 9, 99, "מחשב אינטל NUC", "https://www.ivory.co.il/files/catalog/org/1566199487C87HL.jpg", ProductsCategory.Electricity, 138),

                new PurchasedProduct(new DateTime(2021, 3, 18), 6.90, 1, 1, "חלב 3% שומן", "https://www.nfarm.co.il/wp-content/uploads/2020/04/%D7%97%D7%9C%D7%91-3-%D7%90%D7%97%D7%95%D7%96.jpg", ProductsCategory.Food, 200),
                new PurchasedProduct(new DateTime(2021, 3, 18), 4.90, 2, 2, "כריות תלמה", "https://www.telma-cereals.co.il/wp-content/uploads/2016/05/children_kariot-nugat-686.png", ProductsCategory.Food, 200),
                new PurchasedProduct(new DateTime(2021, 3, 18), 5.90, 3, 3, "קערות חד פעמי", "https://office-master.co.il/image/cache/catalog/hadpami/OM_dessert_bowl-200x200.jpg", ProductsCategory.Food, 200),
                new PurchasedProduct(new DateTime(2021, 3, 18), 12.90, 4, 4, "כפיות חד פעמי", "https://www.peamitstore.co.il/sites/peamitstore/cache/w_1500/4324(6).png", ProductsCategory.Food, 200),
                new PurchasedProduct(new DateTime(2021, 3, 18), 10.90, 5, 5, "שמן קנולה", "https://storage.googleapis.com/sp-public/gs1-products/1107/large/7290002374312.jpg", ProductsCategory.Food, 200),
                new PurchasedProduct(new DateTime(2021, 3, 18), 13.90, 6, 6, "סוכר 1 ק''ג", "https://m.pricez.co.il/ProductPictures/7290000211503.jpg", ProductsCategory.Food, 200),
            };

        public static ObservableCollection<PurchasedProduct> LastPurchasedProducts = new ObservableCollection<PurchasedProduct>()
        {

        };

    };
    //public static List<PurchasedProduct> PurchasedProducts = new List<PurchasedProduct>();
    //new PurchasedProduct(new DateTime(2020, 3, 5), 10, 1, 1, "פתיתים אפויים 500 גר' אסם", "C:\\Users\\Evyatar\\Desktop\\2.jpg", ProductsCategory.Food , new Store(1,1,null))
}
