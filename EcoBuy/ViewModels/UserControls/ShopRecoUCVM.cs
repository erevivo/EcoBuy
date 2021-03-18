using BL;
using EcoBuy.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoBuy.ViewModels
{

    public class ShopRecoUCVM : ViewModelBase
    {
        public LastPurchaseUCVM lastPurchaseUCVM { get; set; }
        public ObservableCollection<PurchasedProduct> LastPurchasedProducts { get; set; }
        public IEnumerable<(int, float)> ProductList { get; set; }
        public ShopRecoUCVM()
        {
            LastPurchasedProducts = new ObservableCollection<PurchasedProduct>(DataSource.PurchasedProducts);
            LastPurchaseUCVM lastPurchaseUCVM = new LastPurchaseUCVM();
            LastPurchasedProducts = lastPurchaseUCVM.LastPurchase(LastPurchasedProducts);

            foreach(var p in LastPurchasedProducts)
            {
                //var d = Recommender.GetTopNPredictions((uint)p.ProductId, 2);
            }
            
        }

    }
}
