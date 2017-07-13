/*
 * Class implements IMultiValueConverter to convert strings from two separate controls
 * into a single binding object, in this case a ShoppingListElement.
 * The ConvertBack method is not used.
 */
using System;
using System.Globalization;

using System.Windows.Data;

using ShoppingList.Models;

namespace ShoppingList.Helpers
{
    class StringToShoppingListElementConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            return new ShoppingListElement (values[0].ToString(), values[1].ToString() );
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
