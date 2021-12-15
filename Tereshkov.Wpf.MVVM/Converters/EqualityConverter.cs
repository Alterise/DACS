using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows;

namespace DACS.WPF.MVVM.Converter
{
    public sealed class EqualityConverter : MultiValueConverter<EqualityConverter>
    {
        public override object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values.Length != 2)
            {
                throw new ArgumentOutOfRangeException(nameof(values));
            }

            if (values[0] == DependencyProperty.UnsetValue ||
                values[1] == DependencyProperty.UnsetValue)
            {
                return DependencyProperty.UnsetValue;
            }

            var leftParameter = (dynamic)values[0];
            var rightParameter = (dynamic)values[1];

            if (!(Enum.IsDefined(typeof(EqualityOperators), parameter)))
            {
                throw new ArgumentException(nameof(parameter));
            }
            switch ((EqualityOperators) parameter)
            {
                case EqualityOperators.Equal:
                    return leftParameter == rightParameter;
                case EqualityOperators.NotEqual:
                    return leftParameter != rightParameter;
                default:
                    throw new ArgumentOutOfRangeException(nameof(parameter));
            }
        }
        
    }

}