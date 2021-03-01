using EcoBuy.BE;
using EcoBuy.Models;
using EcoBuy.UserControls;
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
        AddItemUC View;

        public AddItemUCVM(AddItemUC view)
        {
             View = view;
             view.CategoryComboBox.ItemsSource = Enum.GetValues(typeof(ProductsCategory)).Cast<ProductsCategory>();
            _Stores = new ObservableCollection<string>();
            _Stores.Add(new Stores(1, 200, "Shfersal", ProductsCategory.Food).Name + "#" + new Stores(1, 200, "sshfersal", ProductsCategory.Food).StoreId);
            _Stores.Add(new Stores(1, 166, "YenotBitan", ProductsCategory.Food).Name + "#" + new Stores(1, 166, "YenotBitan", ProductsCategory.Food).StoreId);
            _Stores.Add(new Stores(1, 133, "Osher-Ad", ProductsCategory.Food).Name + "#" + new Stores(1, 133, "Osher-Ad", ProductsCategory.Food).StoreId);
            _Stores.Add(new Stores(1, 69, "Maayan-2000", ProductsCategory.Food).Name + "#" + new Stores(1, 69, "Maayan-2000", ProductsCategory.Food).StoreId);
            _Stores.Add(new Stores(1, 106, "Rami-Levi", ProductsCategory.Food).Name + "#" + new Stores(1, 106, "Rami-Levi", ProductsCategory.Food).StoreId);
            _Stores.Add(new Stores(1, 201, "Mahsani-lahav", ProductsCategory.Food).Name + "#" + new Stores(1, 201, "Mahsani-lahav", ProductsCategory.Food).StoreId);


        }
    };


}