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
        private int Id { get; set; }

        private int StoreId { get; set; }

        private string Name { get; set; }

        private ProductsCategory Category { get; set; }

        private Stores(int id, int storeId, string name, ProductsCategory category)
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
