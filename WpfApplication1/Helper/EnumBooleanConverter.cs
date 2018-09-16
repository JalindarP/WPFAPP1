using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApplication1.Helper;

using System.Windows.Data;

namespace WpfApplication1.Helper
{
    public class EnumBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (System.Convert.ToString(parameter) == null)
                return DependencyProperty.UnsetValue;

            if(Enum.IsDefined(value.GetType(), value)==false)
                return DependencyProperty.UnsetValue;

            object paramValue = Enum.Parse(value.GetType(), System.Convert.ToString(parameter));
            return paramValue.Equals(value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (System.Convert.ToString(parameter) == null)
                return DependencyProperty.UnsetValue;

            return Enum.Parse(targetType, System.Convert.ToString(parameter));
        }
    }
}
