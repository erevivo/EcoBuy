
using LiveCharts;
using System;
using System.Globalization;

namespace EcoBuy.Converters
{
    public class IntToChartValueConverter : ValueConverterBase<IntToChartValueConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return new ChartValues<double>() { (int)value };
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
