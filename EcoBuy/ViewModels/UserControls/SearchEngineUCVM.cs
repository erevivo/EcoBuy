﻿using EcoBuy.BE;
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

        #endregion


        #region Constructor

        public SearchEngineUCVM()
        {
            Test();
        }

        #endregion


        #region Private Methods

        private void FilterItems()
        {
            var items = this._originalItems.Where(p => (
                     string.IsNullOrEmpty(this.SearchText) || p.ProductName.ToLower().Contains(this.SearchText.ToLower()))
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
                new PurchasedProduct(new DateTime(2020, 10, 2), 10, 1, 1, "פתיתים אפויים 500 גר' אסם", "C:\\Users\\Evyatar\\Desktop\\2.jpg", ProductsCategory.Food),
                new PurchasedProduct(new DateTime(2020, 11, 2), 5, 2, 2, "לחם אחיד פרוס אנג'ל", "C:\\Users\\Evyatar\\Desktop\\1.jpg", ProductsCategory.Food),
                new PurchasedProduct(new DateTime(2020, 12, 2), 20, 3, 3, "חלב 3% שומן תנובה", "C:\\Users\\Evyatar\\Desktop\\3.jpg", ProductsCategory.Food),
                new PurchasedProduct(new DateTime(2020, 12, 2), 7, 4, 4, "Acamol", null, ProductsCategory.Health)
            };

            _originalItems = PurchasedProducts;
        }

        #endregion
    }
}
