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
    public class SearchEngineUCVM : ViewModelBase
    {
        #region Private Fields

        private string _searchText;
        private ObservableCollection<PurchasedProduct> _originalItems;
        private ObservableCollection<PurchasedProduct> _purchasedProducts;

        #endregion


        #region Properties

        public string SearchText
        {
            get => _searchText;
            set
            {
                _searchText = value;
                FilterItems();
            }
        }

        public ObservableCollection<PurchasedProduct> PurchasedProducts { get; set; }

        public ICommand SearchCommand { get; set; }

        #endregion


        #region Constructor

        public SearchEngineUCVM()
        {
            SearchCommand = new RelayCommand(() => Search());

            Test();
        }

        #endregion


        #region Private Methods

        private void Search()
        {

        }

        private void FilterItems()
        {
            var items = this._originalItems.Where(p => (
                     string.IsNullOrEmpty(this.SearchText) || p.Product.ProductName.ToLower().Contains(this.SearchText.ToLower()))
                     ).ToList();

            PurchasedProducts = new ObservableCollection<PurchasedProduct>(items);
            CollectionViewSource.GetDefaultView(PurchasedProducts).Refresh();
        }

        private void Test()
        {
            Populate();
        }

        private void Populate()
        {
            PurchasedProducts = new ObservableCollection<PurchasedProduct>()
            {
                new PurchasedProduct(new Product(1, 1, "Milk", null, ProductsCategory.Food), new DateTime(2020, 10, 2), 10),
                new PurchasedProduct(new Product(2, 2, "Bread", null, ProductsCategory.Food), new DateTime(2020, 11, 2), 5),
                new PurchasedProduct(new Product(3, 3, "T-Shirt", null, ProductsCategory.Fashion), new DateTime(2020, 12, 2), 20),
                new PurchasedProduct(new Product(4, 4, "Acamol", null, ProductsCategory.Health), new DateTime(2020, 12, 2), 7)
            };

            _originalItems = PurchasedProducts;
        }

        #endregion
    }
}
