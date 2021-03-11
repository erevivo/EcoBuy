using EcoBuy.BE;
using EcoBuy.Models;
using EcoBuy.UserControls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using EcoBuy.Commands;
namespace EcoBuy.ViewModels
{
    public class AddItemUCVM : ViewModelBase
    {
        public int ProductId { get; set; }
        public AddImageCommand addImage { get; set; }
        public string ProductName { get; set; }
        public string ImageUrl { get; set; }
        public ProductsCategory Category { get; set; }
        public ObservableCollection<Store> Sotres { get; set; }
        public ObservableCollection<string> _Stores { get; set; }

        AddItemUC View;

        public AddItemUCVM(AddItemUC view)
        { 
             View = view;
             view.CategoryComboBox.ItemsSource = Enum.GetValues(typeof(ProductsCategory)).Cast<ProductsCategory>();
            _Stores = new ObservableCollection<string>();
             Sotres = new ObservableCollection<Store>(DataSource.Stores);
             foreach (Store s in Sotres)
             {
                _Stores.Add(s.Name);
             }
             addImage = new AddImageCommand(this);

        }
        public void LoadImages()
        {
            var d = new DirectoryInfo("assets/images");
            var images = d.GetFiles();
            MyImages = images.Select(x => new MyImageModel(x.Name, new BitmapImage(new Uri(x.FullName))));
        }

        public IEnumerable<MyImageModel> MyImages { get; set; }
    };


}