﻿using System;
using System.Windows;

namespace siof.Common.Wpf.Converters
{
    /// <summary>
    /// If value will be of type bool or bool? and has 'true' value then will return Visibility.Visible.
    /// In other case value from parameter (if is Visiblity type) or Visibility.Collapsed will be returned.
    /// </summary>
    /// <returns>Visible if true, parameter/Collapsed otherwise</returns>
    public class BoolToVisibilityConverter : ConverterMarkupExtensionBase<BoolToVisibilityConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is bool && ((bool)value) == true)
                return Visibility.Visible;

            if (value is bool? && ((bool?)value).GetValueOrDefault(false) == true)
                return Visibility.Visible;

            if (parameter != null && parameter is Visibility)
                return parameter;

            return Visibility.Collapsed;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
