using EcoBuy.Models;
using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Windows.Data;

namespace EcoBuy.Converters
{
    class StoreIdToStoreName : IValueConverter
    {
        public ObservableCollection<Store> Stores { get; private set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //if (value == null) return DependencyProperty.UnsetValue;
            return toName((int)value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
        public string toName(int id)
        {
            Stores = new ObservableCollection<Store>(DataSource.Stores);
            Store currStore = Stores.Where(st => st.StoreId == id).FirstOrDefault();
            if (currStore == null)
                return "חנות לא זמינה";
            else
                return currStore.Name;
        }
    }
}
