using EcoBuy.ConnectToGoogleDrive;
using EcoBuy.Models;
using System.Collections.ObjectModel;
using System.IO;

namespace EcoBuy.ViewModels
{
    public class PurchaseConfirmUCVM : ViewModelBase
    {
        #region Properties
        public ObservableCollection<PurchasedProduct> PurchasedProductsTemp { get; set; }
        public DecodeGenerateProduct ProductsFromQr { get; set; }
        #endregion
        public PurchaseConfirmUCVM()
        {

            PurchasedProductsTemp = new ObservableCollection<PurchasedProduct>();
            ProductsFromQr = new DecodeGenerateProduct();
            PurchasedProductsTemp = ProductsFromQr.GenerateProduct();
            RecommendPurchase(PurchasedProductsTemp);
            //todo 
        }




        public void RecommendPurchase(ObservableCollection<PurchasedProduct> pList)
        {
            FileStream fs = new FileStream(@"C:\Users\Evyatar\Documents\GitHub\EcoBuy\BL\Data\PurchasedProducts.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fs);
            foreach (PurchasedProduct p1 in pList)
            {
                foreach (PurchasedProduct p2 in pList)
                {
                    if (p1.ProductId != p2.ProductId)
                    {
                        writer.WriteLine(p1.ProductId + "\t" + p2.ProductId);
                    }
                }
            }
            writer.Close();
            fs.Close();
        }
    }
}
