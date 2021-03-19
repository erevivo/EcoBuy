using BE;
using EcoBuy.BE;
using EcoBuy.Models;
using PL.ConnectToGoogleDrive;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoBuy.ConnectToGoogleDrive
{
    public class DecodeGenerateProduct
    {
        //private GoogleDriveApi downloadQr;
        public ObservableCollection<PurchasedProduct> TempPurchasedProducts { get; set; }
        public DecodeGenerateProduct()
        {
            //downloadQr = new GoogleDriveApi();
            //downloadQr.Connect(); // add check condintion if new files download
            TempPurchasedProducts = new ObservableCollection<PurchasedProduct>();
        }
        public ObservableCollection<PurchasedProduct> GenerateProduct()
        {
            QRCodeHandler DecodeQrImage = new QRCodeHandler();
            string productText;
            /*FileStream fs = new FileStream(@"C:\Users\Evyatar\Documents\GitHub\EcoBuy\BL\Data\Qrs.txt", FileMode.Append, FileAccess.Write);
            StreamReader reader = new StreamReader(fs);
            string str = reader.ReadLine();
             || str.Contains(Path.GetFileName(file))
            */
            var cultureInfo = new CultureInfo("de-DE");
            string folderPath = @"C:\Users\Evyatar\Documents\GitHub\EcoBuy\EcoBuy\Images\QrScans\";
            foreach (string file in Directory.EnumerateFiles(folderPath, "*.png"))
            {
                productText = DecodeQrImage.DecodeData(folderPath + Path.GetFileName(file));
                if (productText.Contains("Error"))
                {
                    continue;
                    /*show message for user
                    var url = productText.Substring(5);*/
                }
                else
                {
                    var datePurchased = Path.GetFileName(file).Substring(0, Path.GetFileName(file).IndexOf("at"));
                    DateTime p_date = DateTime.Parse(datePurchased, cultureInfo, DateTimeStyles.NoCurrentDateDefault);
                    string[] p = productText.Split(',');
                    PurchasedProduct Temp = new PurchasedProduct(p_date, Convert.ToDouble(p[1]), Int32.Parse(p[2]), Int32.Parse(p[3]), p[4], p[5], (ProductsCategory)Int32.Parse(p[6]), Int32.Parse(p[7]));
                    //todo if file exist
                    TempPurchasedProducts.Add(Temp);
                }
            }
            return TempPurchasedProducts;

        }
    }
}
