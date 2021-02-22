using EcoBuy.BE;
using EcoBuy.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoBuy.ViewModels
{
    public class SearchEngineUCDM : SearchEngineUCVM
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static SearchEngineUCDM Instance => new SearchEngineUCDM();

        #endregion

        public SearchEngineUCDM()
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
        }
    }
}
