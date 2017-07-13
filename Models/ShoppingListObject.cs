/*
 * This class represents a section of the shopping list.
 * It contains 3 main properties, a string and two ILists representing the category,
 * the currently selected list for this category, and the current items library for
 * this category.
 * The class implements INotifyPropertyChanged so has the appropriate event, method 
 * and setter in the category title property. 
 * It also implements IEquatable and compares based on the string value of the category 
 * title property.
 * The two ILists are instantiated as Observable Collections.
 * The class contains 2 methods which access the data layer to populate both Ilists.
 * They each obtain an IList of string arrays each of which is used to instantiate and 
 * add a ShoppingListElement to the collection.
 */
using System.Collections.Generic;
using System;
using System.Collections.ObjectModel;

using ShoppingList.DefaultLists;
using ShoppingList.DataLayer;
using System.ComponentModel;

namespace ShoppingList.Models
{
    class ShoppingListObject : INotifyPropertyChanged, IEquatable<ShoppingListObject>
    {

        private string categoryTitle;
        public string CategoryTitle
        {
            get { return categoryTitle; }
            set
            {
                if (value == categoryTitle) return;
                categoryTitle = value;
                OnPropertyChanged(nameof(CategoryTitle));
            }
        }
        public IList<ShoppingListElement> ShoppingList { get; set; }
        public IList<ShoppingListElement> ShoppingListItems { get; set; }

        private string LISTPATH = (string)App.Current.FindResource("LISTPATH");
        private string ITEMSPATH = (string)App.Current.FindResource("ITEMSPATH");

        public event PropertyChangedEventHandler PropertyChanged;

        public ShoppingListObject(string category) 
        {
            ShoppingList = new ObservableCollection<ShoppingListElement>();
            ShoppingListItems = new ObservableCollection<ShoppingListElement>();
            CategoryTitle = category;
            GetList();
            GetItems();
        }

        private void GetList()
        {
            GetListFromFile get = new GetListFromFile(LISTPATH);
            IList<string[]> shoppingList = get.ListFromFile;

            foreach (string[] row in shoppingList)
            {
                if (string.Equals(CategoryTitle, row[1]))
                {
                    if(row.Length == 3)
                    {
                        int amount =  int.Parse(row[2]);
                        ShoppingList.Add(new ShoppingListElement(row[0], row[1], amount));
                    }
                    else
                    {
                        ShoppingList.Add(new ShoppingListElement(row[0], row[1]));
                    }
                }
            }
        }

        private void GetItems()
        {
            GetListFromFile get = new GetListFromFile(ITEMSPATH);
            IList<string[]> ItemsList = null;

            if(get.ListFromFile.Count > 0)
            {
                ItemsList = get.ListFromFile;
            }
            else
            {
                DefaultItemsLibrary defaultItems = new DefaultItemsLibrary();
                ItemsList = defaultItems.DefaultItemsList;
                WriteListToFile set = new WriteListToFile(ItemsList, ITEMSPATH);
            }

            foreach(string[] row in ItemsList)
            {
                if(string.Equals(CategoryTitle, row[1]))
                {
                    ShoppingListItems.Add(new ShoppingListElement(row[0], row[1]));
                }
            }
        }

        public bool Equals(ShoppingListObject other)
        {
            if (string.Equals(this.CategoryTitle, other.CategoryTitle)) return true;
            else return false;
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
