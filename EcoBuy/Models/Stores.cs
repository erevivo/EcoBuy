using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoBuy.BE;

namespace EcoBuy.Models
{
    public class Stores
    {
        public int Id { get; set; }

        public int StoreId { get; set; }

        public string Name { get; set; }

        public ProductsCategory Category { get; set; }

        public Stores(int id, int storeId, string name, ProductsCategory category)
        {
            Id = id;
            StoreId = storeId;
            Name = name;
            Category = category;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
