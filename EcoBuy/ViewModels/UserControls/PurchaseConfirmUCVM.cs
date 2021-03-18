using EcoBuy.ConnectToGoogleDrive;
using EcoBuy.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoBuy.ViewModels
{
    public class PurchaseConfirmUCVM : ViewModelBase
    {
        #region Properties
        public ObservableCollection<PurchasedProduct> PurchasedProductsTemp { get; set; }
        public DecodeGenerateProduct Productim { get; set; }
        #endregion
        public PurchaseConfirmUCVM()
        {
            PurchasedProductsTemp = new ObservableCollection<PurchasedProduct>();
            Productim = new DecodeGenerateProduct();
            PurchasedProductsTemp = Productim.GenerateProduct();
            //todo פה להוסיף את הרשימה אחרי לחיצה על שלח לתוך מסד הנתונים
        }

    }
}
