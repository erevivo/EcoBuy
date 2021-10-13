using EcoBuy.Commands;
using EcoBuy.Models;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Controls;

namespace EcoBuy.ViewModels
{
    public class LastPurchaseUCVM : ViewModelBase
    {

        #region Properties
        public ObservableCollection<PurchasedProduct> PurchasedProducts { get; set; }
        public PrintCommand PrintCmd { get; set; }
        public string LpLable { get; set; }
        public ObservableCollection<PurchasedProduct> LastPurchasedList { get; set; }
        public DataGrid DataGridPurchasedList { get; set; }
        #endregion


        #region Constractor
        public LastPurchaseUCVM()
        {
            PurchasedProducts = new ObservableCollection<PurchasedProduct>(DataSource.PurchasedProducts);
            LastPurchasedList = LastPurchase(PurchasedProducts);
            PrintCmd = new PrintCommand(this);
            LpLable = "(" + PurchasedProducts.Max(p => p.PurchaseDate).Date.ToString("dd/MM/yyyy") + ")";
            DataGridPurchasedList = new DataGrid();
            DataGridPurchasedList.ItemsSource = PurchasedProducts;
        }
        #endregion

        public ObservableCollection<PurchasedProduct> LastPurchase(ObservableCollection<PurchasedProduct> AllPurchase)
        {
            DateTime? lastDate = PurchasedProducts.Max(p => p.PurchaseDate).Date;
            return new ObservableCollection<PurchasedProduct>(PurchasedProducts.Where(p => p.PurchaseDate == lastDate));
        }
    }
}
