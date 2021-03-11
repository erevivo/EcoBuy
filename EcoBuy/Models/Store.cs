using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoBuy.BE;

namespace EcoBuy.Models
{
    public class Store
    {
        public int Id { get; set; }

        public int StoreId { get; set; }

        public string Name { get; set; }

        public Store(int id, int storeId, string name)
        {
            Id = id;
            StoreId = storeId;
            Name = name;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
