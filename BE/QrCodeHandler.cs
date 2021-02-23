using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using ZXing;

namespace BE
{
    public class QRCodeHandler
    {
        private const string BAR_CODE_IMAGES_PATH = @"C:\Users\Evyatar\Documents\GitHub\EcoBuy\EcoBuy\Images\QrScans";
        public string DecodeData(string url)
        {
            var qrcodebitmap = (Bitmap)Bitmap.FromFile(url);
            var qrCodeReader = new BarcodeReader();
            var qrCodeResult = qrCodeReader.Decode(qrcodebitmap);
            if (qrCodeResult != null)
                return qrCodeResult.Text;
            else
                return "Error! can not read file"+ url;
        }
    }
}
