using System;
using System.ComponentModel;
using System.Globalization;
using System.IO.Pipes;
using System.Windows;

namespace DACS.WPF.MVVM.Converter
{
    public sealed class BoolConverter : ValueConverter<BoolConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var onlyParameter = (dynamic) value;
            try
            {
                return onlyParameter ? "Y" : "N";
            }
            catch (Exception)
            {
                throw new ArgumentOutOfRangeException(nameof(onlyParameter));
            }
        }
    }
}