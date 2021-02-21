using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoBuy.BE;
//there is a way to optimize this class? maybe inheritance from Product?
namespace EcoBuy.Models
{
    public class Purchases
    {
        private int Id { get; set; }

        public Product Product { get; set; }

        private DateTime PurchaseTime;

        private DateTime ExpTime;

        public Purchases(int id, Product product, DateTime purchaseTime, DateTime expTime)
        {
            Id = id;
            Product = product;
            PurchaseTime = purchaseTime;
            ExpTime = expTime;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
