using EcoBuy.BE;
using EcoBuy.Models;
using System;
using System.Collections.ObjectModel;

namespace EcoBuy
{
    public static class DataSource
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
                new PurchasedProduct(DateTime.Today.Date,               System.Math.Round(10.90,2), 1, 11, "פתיתים אפויים 500 גר' אסם", "C:\\Users\\Evyatar\\Documents\\GitHub\\EcoBuy\\EcoBuy\\Images\\Products\\ptitim.jpg", ProductsCategory.Food, 200),
                new PurchasedProduct(DateTime.Today.Date,               System.Math.Round(5.90,2), 2, 22, "לחם אחיד פרוס אנג'ל", "C:\\Users\\Evyatar\\Documents\\GitHub\\EcoBuy\\EcoBuy\\Images\\Products\\braid.jpg", ProductsCategory.Food, 200),
                new PurchasedProduct(DateTime.Today.Date.AddDays(-4),   System.Math.Round(5.70,2), 3, 33, "חלב 3% שומן תנובה", "C:\\Users\\Evyatar\\Documents\\GitHub\\EcoBuy\\EcoBuy\\Images\\Products\\milk.jpg", ProductsCategory.Food, 200),
                new PurchasedProduct(DateTime.Today.Date,               System.Math.Round(6.90,2), 4, 44, "גבינת קוטג' 5% תנובה", "C:\\Users\\Evyatar\\Documents\\GitHub\\EcoBuy\\EcoBuy\\Images\\Products\\koteg.jpg", ProductsCategory.Food, 200),
                new PurchasedProduct(DateTime.Today.Date,               System.Math.Round(10.90,2), 5, 55, "ממרח נוטלה 350 גר'", "C:\\Users\\Evyatar\\Documents\\GitHub\\EcoBuy\\EcoBuy\\Images\\Products\\nutela.jpg", ProductsCategory.Food, 200),
                new PurchasedProduct(DateTime.Today.Date.AddDays(-3), System.Math.Round(99.90,2), 6, 66, "בושם לגברים Lacoste Essential 75 מ\"ל ", "C:\\Users\\Evyatar\\Documents\\GitHub\\EcoBuy\\EcoBuy\\Images\\Products\\lacoste.jpg", ProductsCategory.Health, 136),
                new PurchasedProduct(DateTime.Today.Date.AddDays(-3), 349, 7, 77, "חולצת פולו ראלף לורן M", "C:\\Users\\Evyatar\\Documents\\GitHub\\EcoBuy\\EcoBuy\\Images\\Products\\polo.jpg", ProductsCategory.Fashion, 137),
                new PurchasedProduct(DateTime.Today.Date.AddDays(-3), 2899, 8, 88, "טלוויזיה Samsung QE65Q60T 4K ‏65 ‏אינטש", "C:\\Users\\Evyatar\\Documents\\GitHub\\EcoBuy\\EcoBuy\\Images\\Products\\tv.png", ProductsCategory.Electricity, 138),
                new PurchasedProduct(DateTime.Today.Date.AddDays(-3), 650, 9, 99, "מחשב אינטל NUC", "https://www.ivory.co.il/files/catalog/org/1566199487C87HL.jpg", ProductsCategory.Electricity, 138),
                new PurchasedProduct(DateTime.Today.Date, System.Math.Round(14.90,2), 10, 1010, "כריות תלמה 750 גר'", "C:\\Users\\Evyatar\\Documents\\GitHub\\EcoBuy\\EcoBuy\\Images\\Products\\kariot.png", ProductsCategory.Food, 200),
                new PurchasedProduct(DateTime.Today.Date, System.Math.Round(5.90,2), 11, 111, "קערות חד פעמי 50 יחידות", "C:\\Users\\Evyatar\\Documents\\GitHub\\EcoBuy\\EcoBuy\\Images\\Products\\kaara.jpg", ProductsCategory.Food, 200),
                new PurchasedProduct(DateTime.Today.Date.AddDays(-12), System.Math.Round(12.90,2), 12, 1212, "כפיות חד פעמי 100 יח'", "C:\\Users\\Evyatar\\Documents\\GitHub\\EcoBuy\\EcoBuy\\Images\\Products\\kapit.png", ProductsCategory.Food, 200),
                new PurchasedProduct(DateTime.Today.Date.AddDays(-12), System.Math.Round(5.90,2), 13, 1313, "שמן קנולה", "C:\\Users\\Evyatar\\Documents\\GitHub\\EcoBuy\\EcoBuy\\Images\\Products\\shemen.jpg", ProductsCategory.Food, 200),
                new PurchasedProduct(DateTime.Today.Date.AddDays(-12), System.Math.Round(5.90,2), 14, 1414, "סוכר 1 ק''ג", "C:\\Users\\Evyatar\\Documents\\GitHub\\EcoBuy\\EcoBuy\\Images\\Products\\sugar.jpg", ProductsCategory.Food, 200),

                new PurchasedProduct(DateTime.Today.Date.AddDays(-30),             System.Math.Round(10.90,2), 1, 11, "פתיתים אפויים 500 גר' אסם", "C:\\Users\\Evyatar\\Documents\\GitHub\\EcoBuy\\EcoBuy\\Images\\Products\\ptitim.jpg", ProductsCategory.Food, 200),
                new PurchasedProduct(DateTime.Today.Date.AddDays(-30),             System.Math.Round(5.90,2), 2, 22, "לחם אחיד פרוס אנג'ל", "C:\\Users\\Evyatar\\Documents\\GitHub\\EcoBuy\\EcoBuy\\Images\\Products\\braid.jpg", ProductsCategory.Food, 200),
                new PurchasedProduct(DateTime.Today.Date.AddDays(-30),   System.Math.Round(5.70,2), 3, 33, "חלב 3% שומן תנובה", "C:\\Users\\Evyatar\\Documents\\GitHub\\EcoBuy\\EcoBuy\\Images\\Products\\milk.jpg", ProductsCategory.Food, 200),
                new PurchasedProduct(DateTime.Today.Date.AddDays(-30),        System.Math.Round(6.90,2), 4, 44, "גבינת קוטג' 5% תנובה", "C:\\Users\\Evyatar\\Documents\\GitHub\\EcoBuy\\EcoBuy\\Images\\Products\\koteg.jpg", ProductsCategory.Food, 200),
                new PurchasedProduct(DateTime.Today.Date.AddDays(-120),          System.Math.Round(10.90,2), 5, 55, "ממרח נוטלה 350 גר'", "C:\\Users\\Evyatar\\Documents\\GitHub\\EcoBuy\\EcoBuy\\Images\\Products\\nutela.jpg", ProductsCategory.Food, 200),
                new PurchasedProduct(DateTime.Today.Date.AddDays(-90), System.Math.Round(99.90,2), 6, 66, "בושם לגברים Lacoste Essential 75 מ\"ל ", "C:\\Users\\Evyatar\\Documents\\GitHub\\EcoBuy\\EcoBuy\\Images\\Products\\lacoste.jpg", ProductsCategory.Health, 136),
                new PurchasedProduct(DateTime.Today.Date.AddDays(-90), 349, 7, 77, "חולצת פולו ראלף לורן M", "C:\\Users\\Evyatar\\Documents\\GitHub\\EcoBuy\\EcoBuy\\Images\\Products\\polo.jpg", ProductsCategory.Fashion, 137),
                new PurchasedProduct(DateTime.Today.Date.AddDays(-90), 2899, 8, 88, "טלוויזיה Samsung QE65Q60T 4K ‏65 ‏אינטש", "C:\\Users\\Evyatar\\Documents\\GitHub\\EcoBuy\\EcoBuy\\Images\\Products\\tv.png", ProductsCategory.Electricity, 138),
                new PurchasedProduct(DateTime.Today.Date.AddDays(-60), 650, 9, 99, "מחשב אינטל NUC", "https://www.ivory.co.il/files/catalog/org/1566199487C87HL.jpg", ProductsCategory.Electricity, 138),
                new PurchasedProduct(DateTime.Today.Date.AddDays(-120), System.Math.Round(14.90,2), 10, 1010, "כריות תלמה 750 גר'", "C:\\Users\\Evyatar\\Documents\\GitHub\\EcoBuy\\EcoBuy\\Images\\Products\\kariot.png", ProductsCategory.Food, 200),
                new PurchasedProduct(DateTime.Today.Date.AddDays(-60), System.Math.Round(5.90,2), 11, 111, "קערות חד פעמי 50 יחידות", "C:\\Users\\Evyatar\\Documents\\GitHub\\EcoBuy\\EcoBuy\\Images\\Products\\kaara.jpg", ProductsCategory.Food, 200),
                new PurchasedProduct(DateTime.Today.Date.AddDays(-60), System.Math.Round(12.90,2), 12, 1212, "כפיות חד פעמי 100 יח'", "C:\\Users\\Evyatar\\Documents\\GitHub\\EcoBuy\\EcoBuy\\Images\\Products\\kapit.png", ProductsCategory.Food, 200),
                new PurchasedProduct(DateTime.Today.Date.AddDays(-120), System.Math.Round(5.90,2), 13, 1313, "שמן קנולה", "C:\\Users\\Evyatar\\Documents\\GitHub\\EcoBuy\\EcoBuy\\Images\\Products\\shemen.jpg", ProductsCategory.Food, 200),

            };

        public static ObservableCollection<PurchasedProduct> LastPurchasedProducts = new ObservableCollection<PurchasedProduct>()
        {

        };

    };
    //public static List<PurchasedProduct> PurchasedProducts = new List<PurchasedProduct>();
    //new PurchasedProduct(new DateTime(2020, 3, 5), 10, 1, 1, "פתיתים אפויים 500 גר' אסם", "C:\\Users\\Evyatar\\Desktop\\2.jpg", ProductsCategory.Food , new Store(1,1,null))
}
