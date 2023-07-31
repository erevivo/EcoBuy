using BE;
using EcoBuy.BE;
using EcoBuy.Models;
using PL.ConnectToGoogleDrive;
using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;

namespace EcoBuy.ConnectToGoogleDrive
{
    public class DecodeGenerateProduct
    {
        private GoogleDriveApi downloadQr;
        public ObservableCollection<PurchasedProduct> TempPurchasedProducts { get; set; }
        public DecodeGenerateProduct()
        {
            downloadQr = new GoogleDriveApi();
            downloadQr.Connect(); // add check condintion if new files download
            TempPurchasedProducts = new ObservableCollection<PurchasedProduct>();
        }
        public ObservableCollection<PurchasedProduct> GenerateProduct()
        {
            QRCodeHandler DecodeQrImage = new QRCodeHandler();
            string productText;
            var cultureInfo = new CultureInfo("de-DE");
            string folderPath = @"C:\Users\Evyatar\Documents\GitHub\EcoBuy\EcoBuy\Images\QrScans\";
            foreach (string file in Directory.EnumerateFiles(folderPath, "*.png"))
            {
                productText = DecodeQrImage.DecodeData(folderPath + Path.GetFileName(file));
                var a = productText.Contains("Error");
                var b = !CheckExists(Convert.ToInt32(new System.IO.FileInfo(file).Length));

                if (productText.Contains("Error") || !CheckExists(Convert.ToInt32(new System.IO.FileInfo(file).Length)))
                {
                    continue;
                }
                else
                {
                    DocumentProduct(Convert.ToInt32(new System.IO.FileInfo(file).Length));
                    var datePurchased = Path.GetFileName(file).Substring(0, Path.GetFileName(file).IndexOf("at"));
                    DateTime p_date = DateTime.Parse(datePurchased, cultureInfo, DateTimeStyles.NoCurrentDateDefault);
                    string[] p = productText.Split(',');
                    PurchasedProduct Temp = new PurchasedProduct(/*new System.IO.FileInfo(file).LastWriteTime.Date*/p_date, Convert.ToDouble(p[0]), Int32.Parse(p[1]), Int32.Parse(p[2]), p[3],
                        p[4], (ProductsCategory)Int32.Parse(p[5]), Int32.Parse(p[6]));
                    TempPurchasedProducts.Add(Temp);
                }
            }
            return TempPurchasedProducts;

        }
        public bool CheckExists(int FileSize)
        {
            FileStream fs = new FileStream(@"C:\Users\Evyatar\Documents\GitHub\EcoBuy\BL\Data\Qrs.txt", FileMode.Open, FileAccess.Read);

            StreamReader reader = new StreamReader(fs);

            string str = reader.ReadToEnd();
            if (str.Contains(FileSize.ToString()))
            {
                reader.Close();
                fs.Close();
                return true;
            }
            else
            {
                reader.Close();
                fs.Close();
                return false;
            }


        }
        public void DocumentProduct(int FileSize)
        {
            FileStream fs = new FileStream(@"C:\Users\Evyatar\Documents\GitHub\EcoBuy\BL\Data\Qrs.txt", FileMode.Append, FileAccess.Write);

            StreamWriter writer = new StreamWriter(fs);

            writer.WriteLine(FileSize);

            writer.Close();
            fs.Close();
        }
    }
}
