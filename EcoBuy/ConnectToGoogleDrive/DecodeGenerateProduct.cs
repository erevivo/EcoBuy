using BE;
using EcoBuy.Models;
using PL.ConnectToGoogleDrive;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoBuy.ConnectToGoogleDrive
{
    public class DecodeGenerateProduct
    {
        private GoogleDriveApi downloadQr;
        public DecodeGenerateProduct()
        {
        //    downloadQr = new GoogleDriveApi();
          //  downloadQr.Connect(); // add check condintion if new files download
            QRCodeHandler DecodeQrImage = new QRCodeHandler();
            string productText;
            string folderPath = @"C:\Users\Evyatar\Documents\GitHub\EcoBuy\EcoBuy\Images\QrScans\";
            foreach (string file in Directory.EnumerateFiles(folderPath, "*.png"))
            {
                productText = DecodeQrImage.DecodeData(folderPath + Path.GetFileName(file));
                if (productText.Contains("Error")) 
                {/*show message for user*/
                    var url = productText.Substring(5);
                }
                //PurchasedProduct TextToproduct = new PurchasedProduct(();
            }
        }
    }
}
