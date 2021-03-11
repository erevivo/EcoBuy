using EcoBuy.BE;
using System;
using System.Collections.Generic;

namespace EcoBuy.Models
{
    public class PurchasedProduct : Product
    {
        public DateTime PurchaseDate { get; set; }
        public Store Store { get; set; }
        public double Price { get; set; }
        public PurchasedProduct(DateTime purchaseDate, double price, 
                                int id, int productId, string productName, 
                                string ImageUrl, ProductsCategory category, Store store) : 
            base(id, productId, productName, ImageUrl, category)
        {
            PurchaseDate = purchaseDate;
            Price = price;
            Store = store;
        }

        internal static IEnumerable<object> GroupBy(Func<object, object> p)
        {
            throw new NotImplementedException();
        }
    }
}
