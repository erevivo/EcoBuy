using EcoBuy.BE;

namespace EcoBuy.Models
{
    public class Product
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string ImageUrl { get; set; }

        public ProductsCategory Category { get; set; }

        public Product(int id, int productId, string productName, string ImageUrl, ProductsCategory category)
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
