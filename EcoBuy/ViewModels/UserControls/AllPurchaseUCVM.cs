using EcoBuy.Models;
using System.Collections.ObjectModel;

namespace EcoBuy.ViewModels.UserControls
{
    public class AllPurchaseUCVM : ViewModelBase
    {
        public ObservableCollection<PurchasedProduct> PurchasedProducts { get; set; }

        public AllPurchaseUCVM()
        {
            Test();
        }
        private void Test()
        {
            PurchasedProducts = new ObservableCollection<PurchasedProduct>(DataSource.PurchasedProducts);

        }
    }
}
