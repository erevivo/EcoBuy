using EcoBuy.BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoBuy.Models
{
    public class Product
    {
        private int Id { get; set; }

        private int ProductId { get; set; }

        private string ProductName { get; set; }

        private string ImageUrl { get; set; }

        private ProductsCategory Category { get; set; }

        private Product(int id, int productId, string productName, string ImageUrl, ProductsCategory category)
        {
            Id = id;
            ProductId = productId;
            ProductName = productName;
            this.ImageUrl = ImageUrl;
            Category = category;
        }
        
        public override string ToString()
        {
            return base.ToString();
        }
    }


}
