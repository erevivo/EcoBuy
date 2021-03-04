using EcoBuy.BE;
using System;
using System.Collections.Generic;

namespace EcoBuy.Models
{
    public class PurchasedProduct : Product
    {
        public DateTime PurchaseDate { get; set; }

        public double Price { get; set; }

        public PurchasedProduct(DateTime purchaseDate, double price, 
                                int id, int productId, string productName, 
                                string ImageUrl, ProductsCategory category) : 
            base(id, productId, productName, ImageUrl, category)
        {
            PurchaseDate = purchaseDate;
            Price = price;
        }

        internal static IEnumerable<object> GroupBy(Func<object, object> p)
        {
            throw new NotImplementedException();
        }
    }
}
