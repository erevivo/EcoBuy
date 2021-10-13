using System;
using System.Windows.Data;

namespace EcoBuy.Converters
{
    public class RemoveNewlinesConverter : IValueConverter
    {
        string news;
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is string text)
            {
                news = value.ToString(); // + "  |  ";
            }
            return news;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
