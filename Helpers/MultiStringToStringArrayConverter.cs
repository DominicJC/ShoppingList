/*
 * Class implements IMultiValueConverter to convert strings from two separate controls
 * into a single binding object, in this case a string array.
 * The convert method carries out a null check and puts the values in a string array 
 * which is returned.
 * The ConvertBack method is not used.
 */
using System;
using System.Globalization;
using System.Windows.Data;

namespace ShoppingList.Helpers
{
    class MultiStringToStringArrayConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if(values[0] != null && values[1] != null)
            {
                return new string[] { values[0].ToString(), values[1].ToString() };
            }
            return values;   
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
