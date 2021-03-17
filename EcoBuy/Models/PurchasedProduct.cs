using EcoBuy.BE;
using System;
using System.Collections.Generic;

namespace EcoBuy.Models
{
    public class PurchasedProduct : Product
    {
        // var lessons = db.Lessons.Where(me => me.SynagogueId == (db.Synagogues.Where(m => m.ManagerId == Manager.Current.Id).FirstOrDefault().Id))
        public DateTime PurchaseDate { get; set; }
        public int StoreId { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }
        public PurchasedProduct(DateTime purchaseDate, double price, 
                                int id, int productId, string productName, 
                                string ImageUrl, ProductsCategory category, int storeId , int amount=1) : 
            base(id, productId, productName, ImageUrl, category)
        {
            PurchaseDate = purchaseDate;
            Price = price;
            StoreId = storeId;
            Amount = amount;
        }

        internal static IEnumerable<object> GroupBy(Func<object, object> p)
        {
            throw new NotImplementedException();
        }
    }
}
