using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class QRData
    {
        private string _id;
        private int _productId;
        private float _amount;
        private float _Price;
        private int _storeId;
        private DateTime? _scanDate;
        private string _name;

        public QRData(int productId, string id, float amount, float price, int storeId, DateTime? scanDate, string name)
        {
            _id = id;
            _productId = productId;
            _amount = amount;
            _Price = price;
            _storeId = storeId;
            _scanDate = scanDate;
            _name = name;
        }
    }
}