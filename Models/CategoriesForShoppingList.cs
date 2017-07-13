/*
 * This class represents the overall shopping list.
 * It contains an IList of ShoppingListObjects instantiated as an Observable Collection
 * by the constructor.
 * Contains 1 method which accesses the data layer to obtain an IList of string arrays each
 * of which is used to instantiate and add a ShoppingListObject.
 */
using System.Collections.Generic;
using System.Collections.ObjectModel;

using ShoppingList.DataLayer;
using ShoppingList.DefaultLists;

namespace ShoppingList.Models
{
    class CategoriesForShoppingList
    {
        public IList<ShoppingListObject> categories { get; set; }

        private readonly string CATEGORIESPATH = (string)App.Current.FindResource("CATEGORIESPATH");

        public CategoriesForShoppingList()
        {
            categories = new ObservableCollection<ShoppingListObject>();
            GetList();
        }

        private void GetList()
        {
            GetListFromFile get = new GetListFromFile(CATEGORIESPATH);
            IList<string[]> cats = null;

            if (get.ListFromFile.Count > 0)
            {
                cats = get.ListFromFile;
            }
            else
            {
                DefaultCategories defaultCategories = new DefaultCategories();
                cats = defaultCategories.DefaultCategoryList;
                WriteListToFile set = new WriteListToFile(cats, CATEGORIESPATH);
            }
            
            foreach(string[] cat in cats)
            {
                categories.Add(new ShoppingListObject(cat[0]));
            }
        }
    }
}
