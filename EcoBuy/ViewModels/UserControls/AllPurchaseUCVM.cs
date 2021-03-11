using EcoBuy.BE;
using EcoBuy.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
