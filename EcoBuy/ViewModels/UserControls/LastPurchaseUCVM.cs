using EcoBuy.BE;
using EcoBuy.Commands;
using EcoBuy.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace EcoBuy.ViewModels
{
    public class LastPurchaseUCVM : ViewModelBase
    {

        #region Properties
        public ObservableCollection<PurchasedProduct> PurchasedProducts { get; set; }
        public PrintCommand PrintCmd { get; set; }
        public string LpLable;
        public ObservableCollection<PurchasedProduct> LastPurchasedList { get; set; }
        public DataGrid DataGridPurchasedList { get; set; }
        #endregion


        #region Constractor
        public LastPurchaseUCVM()
        {
            Test();
            LastPurchase();
            PrintCmd = new PrintCommand(this);
            LpLable = PurchasedProducts.Max(p => p.PurchaseDate).Date.ToString();
            DataGridPurchasedList = new DataGrid();
            DataGridPurchasedList.ItemsSource = PurchasedProducts;
        }
        #endregion

        public void Test()
        {
            PurchasedProducts = new ObservableCollection<PurchasedProduct>(DataSource.PurchasedProducts);
        }

        public void LastPurchase()
        {
            DateTime? lastDate = PurchasedProducts.Max(p => p.PurchaseDate).Date;
            PurchasedProducts = new ObservableCollection<PurchasedProduct>(PurchasedProducts.Where(p => p.PurchaseDate == lastDate));
        }
    }
}
