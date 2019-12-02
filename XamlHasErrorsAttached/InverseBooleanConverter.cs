using System;
using System.Globalization;
using System.Windows.Data;

namespace XamlHasErrorsAttached
{
    [ValueConversion(typeof(bool), typeof(bool))]
    public class InverseBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return InverseBoolean(value, targetType);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return InverseBoolean(value, targetType);
        }

        private static object InverseBoolean(object value, Type targetType)
        {
            if (targetType != typeof(bool))
                throw new InvalidOperationException("The target must be a boolean");

            return !(bool)value;
        }
    }
}
