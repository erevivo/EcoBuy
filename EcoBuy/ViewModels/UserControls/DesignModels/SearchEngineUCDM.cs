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
            PurchasedProducts = new ObservableCollection<PurchasedProduct>(DataSource.PurchasedProducts);
        }
    }
}
