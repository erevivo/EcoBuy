using EcoBuy.BE;
using EcoBuy.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;

namespace EcoBuy.ViewModels
{
    public class AddItemUCVM : ViewModelBase
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ImageUrl { get; set; }
        public string Store { get; set; }
        public ProductsCategory Category { get; set; }
        public ObservableCollection<string> _Stores { get; set; }

        public AddItemUCVM()
        {

            _Stores = new ObservableCollection<string>();
            _Stores.Add(new Stores(1, 200, "Shfersal", ProductsCategory.Food).Name + "#" + new Stores(1, 200, "shfersal", ProductsCategory.Food).StoreId);
            _Stores.Add(new Stores(1, 166, "YenotBitan", ProductsCategory.Food).Name + "#" + new Stores(1, 166, "YenotBitan", ProductsCategory.Food).StoreId);
            _Stores.Add(new Stores(1, 133, "Osher-Ad", ProductsCategory.Food).Name + "#" + new Stores(1, 133, "Osher-Ad", ProductsCategory.Food).StoreId);
            _Stores.Add(new Stores(1, 69, "Maayan-2000", ProductsCategory.Food).Name + "#" + new Stores(1, 69, "Maayan-2000", ProductsCategory.Food).StoreId);
            _Stores.Add(new Stores(1, 106, "Rami-Levi", ProductsCategory.Food).Name + "#" + new Stores(1, 106, "Rami-Levi", ProductsCategory.Food).StoreId);
            _Stores.Add(new Stores(1, 201, "Mahsani-lahav", ProductsCategory.Food).Name + "#" + new Stores(1, 201, "Mahsani-lahav", ProductsCategory.Food).StoreId);


        }
    };


}
