using BL;
using EcoBuy.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EcoBuy.ViewModels
{

    public class ShopRecoUCVM : ViewModelBase
    {
        public LastPurchaseUCVM lastPurchaseUCVM { get; set; }
        public ObservableCollection<PurchasedProduct> LastPurchasedProducts { get; set; }
        public ObservableCollection<PurchasedProduct> AllProducts { get; set; }
        public ObservableCollection<PurchasedProduct> RecoProduct { get; set; }
        public IEnumerable<(int, float)> ProductList { get; set; }
        public ShopRecoUCVM()
        {
            LastPurchasedProducts = new ObservableCollection<PurchasedProduct>(DataSource.PurchasedProducts);
            AllProducts = new ObservableCollection<PurchasedProduct>(DataSource.PurchasedProducts);
            RecoProduct = new ObservableCollection<PurchasedProduct>();
            LastPurchaseUCVM lastPurchaseUCVM = new LastPurchaseUCVM();
            LastPurchasedProducts = lastPurchaseUCVM.LastPurchase(LastPurchasedProducts);
            List<int> LastPurchasedList = new List<int>();
            List<int> RecoProductList = new List<int>();

            if (LastPurchasedProducts.Count != 0)
            {
                foreach (var p in LastPurchasedProducts)
                {
                    LastPurchasedList.Add(p.ProductId);
                    IEnumerable<(int, float)> topProduct = Recommender.GetTopNPredictions((uint)p.ProductId, 2);
                    //RecoProductList.Add(topProduct.FirstOrDefault());
                    RecoProductList.AddRange(topProduct.Select(x => x.Item1).ToList());
                }
            }
            RecoProductList = RecoProductList.Distinct().ToList();
            RecoProductList = RecoProductList.Except(LastPurchasedList).ToList();
            foreach (var p in AllProducts)
            {
                //if (p.ProductId == RecoProductList[0])
                if (RecoProductList.Contains(p.ProductId) && !RecoProduct.Any(x => x.ProductId==p.ProductId))
                {
                    RecoProduct.Add(p);
                    //RecoProductList.RemoveAt(0);
                }

            }
        }

    }

}
