using siof.Common.Extensions;
using System;

namespace siof.Common.Wpf.Converters
{
    public class ToLowerCaseConverter : ConverterMarkupExtensionBase<ToLowerCaseConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return value.ToStringSafe().ToLower(culture);
        }

        public override object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return value;
        }
    }
}
