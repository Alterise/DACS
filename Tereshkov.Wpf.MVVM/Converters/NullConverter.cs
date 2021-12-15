using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows;

namespace DACS.WPF.MVVM.Converter
{
    public sealed class NullConverter : ValueConverter<NullConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var onlyParameter = (dynamic) value;
            try
            {
                return onlyParameter is null;
            }
            catch (Exception)
            {
                throw new ArgumentOutOfRangeException(nameof(onlyParameter));
            }
        }
    }
}