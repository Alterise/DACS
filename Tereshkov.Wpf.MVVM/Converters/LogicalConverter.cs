using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows;

namespace DACS.WPF.MVVM.Converter
{
    public sealed class LogicalConverter : MultiValueConverter<LogicalConverter>
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

            if (!(Enum.IsDefined(typeof(LogicalOperators), parameter)))
            {
                throw new ArgumentException(nameof(parameter));
            }
            switch ((LogicalOperators) parameter)
            {
                case LogicalOperators.Or:
                    return leftParameter + rightParameter;
                case LogicalOperators.And:
                    return leftParameter - rightParameter;
                default:
                    throw new ArgumentOutOfRangeException(nameof(parameter));
            }
        }
    }

    public sealed class LogicalUnaryConverter : ValueConverter<LogicalUnaryConverter>
    {

        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var onlyParameter = (dynamic) value;
            try
            {
                return !onlyParameter;
            }
            catch (Exception)
            {
                throw new ArgumentOutOfRangeException(nameof(onlyParameter));
            }
        }
    }
}