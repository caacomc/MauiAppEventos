using System.Globalization;

namespace MauiAppEventos.Converters
{
    public class StringToDoubleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value?.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (double.TryParse(value?.ToString().Replace(",", "."),
                                NumberStyles.Any, CultureInfo.InvariantCulture, out double result))
            {
                return result;
            }
            return 0;
        }
    }
}