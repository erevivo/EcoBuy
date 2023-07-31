﻿using System;
using System.Drawing;
using System.IO;
using System.Windows.Media.Imaging;
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
                return qrCodeResult.Text.ToString();
            else
                return "Error" + url;
        }
        public string GetDate(FileInfo f)
        {
            using (FileStream fs = new FileStream(f.FullName, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                BitmapSource img = BitmapFrame.Create(fs);
                BitmapMetadata md = (BitmapMetadata)img.Metadata;
                string date = md.DateTaken;
                Console.WriteLine(date);
                return date;
            }
        }
    }
}
