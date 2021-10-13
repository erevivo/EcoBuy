using EcoBuy.Models;
using System.Collections.ObjectModel;

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
