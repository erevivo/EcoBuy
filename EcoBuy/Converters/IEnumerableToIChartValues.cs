using LiveCharts;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace EcoBuy.Converters
{
    public class IEnumerableToIChartValues : ValueConverterBase<IEnumerableToIChartValues>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return new ChartValues<double>((IEnumerable<double>)value);
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
