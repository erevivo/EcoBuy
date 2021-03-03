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
           // Populate();
        }

        private void Populate()
        {
            PurchasedProducts = new ObservableCollection<PurchasedProduct>()
            {
                new PurchasedProduct(new DateTime(2020, 10, 2), 10, 1, 1, "פתיתים", "C:\\Users\\Evyatar\\Desktop\\2.jpg", ProductsCategory.Food),
                new PurchasedProduct(new DateTime(2020, 11, 2), 5, 2, 2, "Bread", null, ProductsCategory.Food),
                new PurchasedProduct(new DateTime(2020, 12, 2), 20, 3, 3, "T-Shirt", null, ProductsCategory.Fashion),
                new PurchasedProduct(new DateTime(2020, 12, 2), 7, 4, 4, "Acamol", null, ProductsCategory.Health)
            };
        }
    }
}
