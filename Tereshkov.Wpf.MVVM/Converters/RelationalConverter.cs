using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows;

namespace DACS.WPF.MVVM.Converter
{
    public sealed class RelationalConverter : MultiValueConverter<RelationalConverter>
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

            if (!(Enum.IsDefined(typeof(RelationalOperators), parameter)))
            {
                throw new ArgumentException(nameof(parameter));
            }
            switch ((RelationalOperators) parameter)
            {
                case RelationalOperators.Greater:
                    return leftParameter > rightParameter;
                case RelationalOperators.Less:
                    return leftParameter < rightParameter;
                case RelationalOperators.LessOrEqual:
                    return leftParameter <= rightParameter;
                case RelationalOperators.GreaterOrEqual:
                    return leftParameter >= rightParameter;
                default:
                    throw new ArgumentOutOfRangeException(nameof(parameter));
            }
        }
        
    }

}