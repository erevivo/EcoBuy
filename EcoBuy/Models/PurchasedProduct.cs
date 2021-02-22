using System;

namespace EcoBuy.Models
{
    public class PurchasedProduct
    {
        public Product Product { get; set; }

        public DateTime PurchaseDate { get; set; }

        public double Price { get; set; }

        public PurchasedProduct(Product product, DateTime purchaseDate, double price)
        {
            this.Product = product;
            this.PurchaseDate = purchaseDate;
            this.Price = price;
        }
    }
}
