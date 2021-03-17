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
        public int Amount { get; set; }
        
        public PurchasedProduct(DateTime purchaseDate, Store store, double price, int amount,
                                int id, int productId, string productName, 
                                string ImageUrl, ProductsCategory category) : 
            base(id, productId, productName, ImageUrl, category)
        {
            PurchaseDate = purchaseDate;
            Store = store;
            Price = price;
            Amount = amount;
        }

        internal static IEnumerable<object> GroupBy(Func<object, object> p)
        {
            throw new NotImplementedException();
        }
    }
}
