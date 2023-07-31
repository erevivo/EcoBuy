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
                new PurchasedProduct(DateTime.Today.Date,               10.90, 1, 1, "פתיתים אפויים 500 גר' אסם", "C:\\Users\\Evyatar\\Documents\\GitHub\\EcoBuy\\EcoBuy\\Images\\Products\\ptitim.jpg", ProductsCategory.Food, 200),
                new PurchasedProduct(DateTime.Today.Date,               5.90, 2, 2, "לחם אחיד פרוס אנג'ל", "C:\\Users\\Evyatar\\Documents\\GitHub\\EcoBuy\\EcoBuy\\Images\\Products\\braid.jpg", ProductsCategory.Food, 200),
                new PurchasedProduct(DateTime.Today.Date.AddDays(-4),   5.70, 3, 3, "חלב 3% שומן תנובה", "C:\\Users\\Evyatar\\Documents\\GitHub\\EcoBuy\\EcoBuy\\Images\\Products\\milk.jpg", ProductsCategory.Food, 200),
                new PurchasedProduct(DateTime.Today.Date,               6.90, 4, 4, "גבינת קוטג' 5% תנובה", "C:\\Users\\Evyatar\\Documents\\GitHub\\EcoBuy\\EcoBuy\\Images\\Products\\koteg.jpg", ProductsCategory.Food, 200),
                new PurchasedProduct(DateTime.Today.Date,               10.90, 5, 5, "ממרח נוטלה 350 גר'", "C:\\Users\\Evyatar\\Documents\\GitHub\\EcoBuy\\EcoBuy\\Images\\Products\\nutela.jpg", ProductsCategory.Food, 200),
                new PurchasedProduct(DateTime.Today.Date.AddDays(-3),   99.90, 6, 6, "בושם לגברים Lacoste Essential 75 מ\"ל ", "C:\\Users\\Evyatar\\Documents\\GitHub\\EcoBuy\\EcoBuy\\Images\\Products\\lacoste.jpg", ProductsCategory.Health, 136),
                new PurchasedProduct(DateTime.Today.Date.AddDays(-3),   349.90, 7, 7, "חולצת פולו ראלף לורן M", "C:\\Users\\Evyatar\\Documents\\GitHub\\EcoBuy\\EcoBuy\\Images\\Products\\polo.jpg", ProductsCategory.Fashion, 137),
                new PurchasedProduct(DateTime.Today.Date.AddDays(-3),   2899.00, 8, 8, "טלוויזיה Samsung QE65Q60T 4K ‏65 ‏אינטש", "C:\\Users\\Evyatar\\Documents\\GitHub\\EcoBuy\\EcoBuy\\Images\\Products\\tv.png", ProductsCategory.Electricity, 138),
                new PurchasedProduct(DateTime.Today.Date.AddDays(-3),   650.00, 9, 9, "מחשב אינטל NUC", "https://www.ivory.co.il/files/catalog/org/1566199487C87HL.jpg", ProductsCategory.Electricity, 138),
                new PurchasedProduct(DateTime.Today.Date, 14.90, 10, 10, "כריות תלמה 750 גר'", "C:\\Users\\Evyatar\\Documents\\GitHub\\EcoBuy\\EcoBuy\\Images\\Products\\kariot.png", ProductsCategory.Food, 200),
                new PurchasedProduct(DateTime.Today.Date, 5.90, 11, 11, "קערות חד פעמי 50 יחידות", "C:\\Users\\Evyatar\\Documents\\GitHub\\EcoBuy\\EcoBuy\\Images\\Products\\kaara.jpg", ProductsCategory.Food, 200),
                new PurchasedProduct(DateTime.Today.Date.AddDays(-12), 12.90, 12, 12, "כפיות חד פעמי 100 יח'", "C:\\Users\\Evyatar\\Documents\\GitHub\\EcoBuy\\EcoBuy\\Images\\Products\\kapit.png", ProductsCategory.Food, 200),
                new PurchasedProduct(DateTime.Today.Date.AddDays(-12), 5.90, 13, 13, "שמן קנולה", "C:\\Users\\Evyatar\\Documents\\GitHub\\EcoBuy\\EcoBuy\\Images\\Products\\shemen.jpg", ProductsCategory.Food, 200),
                new PurchasedProduct(DateTime.Today.Date.AddDays(-12), 5.90, 14, 14, "סוכר 1 ק''ג", "C:\\Users\\Evyatar\\Documents\\GitHub\\EcoBuy\\EcoBuy\\Images\\Products\\sugar.jpg", ProductsCategory.Food, 200),

                new PurchasedProduct(DateTime.Today.Date.AddDays(-30),             10.90, 1, 1, "פתיתים אפויים 500 גר' אסם", "C:\\Users\\Evyatar\\Documents\\GitHub\\EcoBuy\\EcoBuy\\Images\\Products\\ptitim.jpg", ProductsCategory.Food, 200),
                new PurchasedProduct(DateTime.Today.Date.AddDays(-30),            5.90, 2, 2, "לחם אחיד פרוס אנג'ל", "C:\\Users\\Evyatar\\Documents\\GitHub\\EcoBuy\\EcoBuy\\Images\\Products\\braid.jpg", ProductsCategory.Food, 200),
                new PurchasedProduct(DateTime.Today.Date.AddDays(-30),  5.70, 3, 3, "חלב 3% שומן תנובה", "C:\\Users\\Evyatar\\Documents\\GitHub\\EcoBuy\\EcoBuy\\Images\\Products\\milk.jpg", ProductsCategory.Food, 200),
                new PurchasedProduct(DateTime.Today.Date.AddDays(-30),       6.90, 4, 4, "גבינת קוטג' 5% תנובה", "C:\\Users\\Evyatar\\Documents\\GitHub\\EcoBuy\\EcoBuy\\Images\\Products\\koteg.jpg", ProductsCategory.Food, 200),
                new PurchasedProduct(DateTime.Today.Date.AddDays(-120),          10.90, 5, 5, "ממרח נוטלה 350 גר'", "C:\\Users\\Evyatar\\Documents\\GitHub\\EcoBuy\\EcoBuy\\Images\\Products\\nutela.jpg", ProductsCategory.Food, 200),
                new PurchasedProduct(DateTime.Today.Date.AddDays(-90), 99.90, 6, 6, "בושם לגברים Lacoste Essential 75 מ\"ל ", "C:\\Users\\Evyatar\\Documents\\GitHub\\EcoBuy\\EcoBuy\\Images\\Products\\lacoste.jpg", ProductsCategory.Health, 136),
                new PurchasedProduct(DateTime.Today.Date.AddDays(-90), 349, 7, 77, "חולצת פולו ראלף לורן M", "C:\\Users\\Evyatar\\Documents\\GitHub\\EcoBuy\\EcoBuy\\Images\\Products\\polo.jpg", ProductsCategory.Fashion, 137),
                new PurchasedProduct(DateTime.Today.Date.AddDays(-90), 2899, 8, 88, "טלוויזיה Samsung QE65Q60T 4K ‏65 ‏אינטש", "C:\\Users\\Evyatar\\Documents\\GitHub\\EcoBuy\\EcoBuy\\Images\\Products\\tv.png", ProductsCategory.Electricity, 138),
                new PurchasedProduct(DateTime.Today.Date.AddDays(-60), 650, 9, 99, "מחשב אינטל NUC", "https://www.ivory.co.il/files/catalog/org/1566199487C87HL.jpg", ProductsCategory.Electricity, 138),
                new PurchasedProduct(DateTime.Today.Date.AddDays(-120), 14.90, 10, 10, "כריות תלמה 750 גר'", "C:\\Users\\Evyatar\\Documents\\GitHub\\EcoBuy\\EcoBuy\\Images\\Products\\kariot.png", ProductsCategory.Food, 200),
                new PurchasedProduct(DateTime.Today.Date.AddDays(-60), 5.90, 11, 11, "קערות חד פעמי 50 יחידות", "C:\\Users\\Evyatar\\Documents\\GitHub\\EcoBuy\\EcoBuy\\Images\\Products\\kaara.jpg", ProductsCategory.Food, 200),
                new PurchasedProduct(DateTime.Today.Date.AddDays(-60), 12.90, 12, 12, "כפיות חד פעמי 100 יח'", "C:\\Users\\Evyatar\\Documents\\GitHub\\EcoBuy\\EcoBuy\\Images\\Products\\kapit.png", ProductsCategory.Food, 200),
                new PurchasedProduct(DateTime.Today.Date.AddDays(-120), 5.90, 13, 13, "שמן קנולה", "C:\\Users\\Evyatar\\Documents\\GitHub\\EcoBuy\\EcoBuy\\Images\\Products\\shemen.jpg", ProductsCategory.Food, 200),

            };

        public static ObservableCollection<PurchasedProduct> LastPurchasedProducts = new ObservableCollection<PurchasedProduct>()
        {

        };

    };
    //public static List<PurchasedProduct> PurchasedProducts = new List<PurchasedProduct>();
    //new PurchasedProduct(new DateTime(2020, 3, 5), 10, 1, 1, "פתיתים אפויים 500 גר' אסם", "C:\\Users\\Evyatar\\Desktop\\2.jpg", ProductsCategory.Food , new Store(1,1,null))
}
