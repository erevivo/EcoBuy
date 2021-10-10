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
        public ObservableCollection<PurchasedProduct> AllProducts { get; set; }
        public ObservableCollection<PurchasedProduct> RecoProduct { get; set; }
        public IEnumerable<(int, float)> ProductList { get; set; }
        public ShopRecoUCVM()
        {
            LastPurchasedProducts = new ObservableCollection<PurchasedProduct>(DataSource.PurchasedProducts);
            AllProducts = new ObservableCollection<PurchasedProduct>(DataSource2.PurchasedProducts);
            RecoProduct = new ObservableCollection<PurchasedProduct>();
            LastPurchaseUCVM lastPurchaseUCVM = new LastPurchaseUCVM();
            LastPurchasedProducts = lastPurchaseUCVM.LastPurchase(LastPurchasedProducts);
            List<int> LastPurchasedList = new List<int>();
            List<int> RecoProductList = new List<int>();

            while (LastPurchasedProducts.Count != 0)
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
                if (p.ProductId == RecoProductList[0])
                {
                    RecoProduct.Add(p);
                    //RecoProductList.RemoveAt(0);
                }
            }

        }

    }
}
