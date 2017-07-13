/*
 * This is the base class for all the Command classes.
 * 
 * It implements the ICommand interface with the ICommand's standard 
 * event handler: CanExecuteChanged, and two methods: CanExecute
 * and Execute which are abstract and overridden by each child class. 
 * 
 * The class contains an Enum type which represents the type of list 
 * being manipulated by the child class.
 * 
 * There is one instance variable, an IList of shopping list objects called 
 * _object.
 * 
 * There are three methods which are explained further below.
 */
using System;
using System.Collections.Generic;

using System.Windows.Input;

using ShoppingList.Models;
using ShoppingList.DataLayer;

namespace ShoppingList.Cmds
{
    abstract class CommandBase : ICommand
    {
        protected internal IList<ShoppingListObject> _objects;

        protected internal enum ListType
        {
            ShoppingList = 1,
            ItemsList = 2,
            Categories = 3,
            NewShoppingList
        }

        public CommandBase() { }

        public CommandBase(IList<ShoppingListObject> objects)
        {
            _objects = objects;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public abstract bool CanExecute(object parameter);

        public abstract void Execute(object parameter);

        /*
         * This method is used by various child classes to obtain an IList
         * of ShoppingListElements.
         * The relevant category is iterated to and the correct IList of 
         * elements is returned depending on the enum parameter.
         */
        protected internal IList<ShoppingListElement> GetElements(string category, ListType listType)
        {
            IList<ShoppingListElement> list = null;

            foreach (ShoppingListObject obj in _objects)
            {
                if (string.Equals(obj.CategoryTitle, category))
                {
                    switch (listType)
                    {
                        case ListType.ShoppingList:
                            list = obj.ShoppingList;
                        break;
                        case ListType.ItemsList:
                            list = obj.ShoppingListItems;
                        break;
                    }
                    
                }
            }

            return list;

        }

        /*
         * This method is used by various child classes to persist data
         * to file.
         * A switch statement based on the enum parameter is used to populate
         * a list of string arrays to pass to the data layer. 
         */
        protected internal void SaveToFile(ListType listType)
        {
            string path = null;
            List<string[]> listToSave = new List<string[]>();

            foreach (ShoppingListObject ShoppingList in _objects)
            {
                string[] row = null;
                
                switch (listType)
                {
                    case ListType.ShoppingList:
                        path = (string)App.Current.FindResource("LISTPATH");
   
                        foreach (ShoppingListElement element in ShoppingList.ShoppingList)
                        {
                            row = new string[] { element.Item, element.Category, element.Amount.ToString() };
                            listToSave.Add(row);
                        }

                        break;
                    case ListType.ItemsList:
                        path = (string)App.Current.FindResource("ITEMSPATH");
  
                        foreach (ShoppingListElement element in ShoppingList.ShoppingListItems)
                        {
                            row = new string[] { element.Item, element.Category };
                            listToSave.Add(row);
                        }
                                            
                        break;
                    case ListType.Categories:
                        path = (string)App.Current.FindResource("CATEGORIESPATH");

                        row = new string[] { ShoppingList.CategoryTitle };
                        listToSave.Add(row);

                        break;
                    case ListType.NewShoppingList:
                        path = (string)App.Current.FindResource("LASTLISTPATH");

                        foreach (ShoppingListElement element in ShoppingList.ShoppingList)
                        {
                            row = new string[] { element.Item, element.Category, element.Amount.ToString() };
                            listToSave.Add(row);
                        }

                        break;
                }                
            }

            WriteListToFile save = new WriteListToFile(listToSave, path);
        }

        /*
         * This method is used by various child classes to re-allocate items to
         * the new category if the category name is changed or to Misc if the 
         * category is deleted.  
         */
        protected internal void MoveItemsToNewCategory(object parameter, string category, ListType listType)
        {
            int index = 0;

            foreach (ShoppingListObject listObject in _objects)
            {
                if (string.Equals(listObject.CategoryTitle, category))
                {
                    index = _objects.IndexOf(listObject);
                    break;
                }
            }

            switch (listType)
            {
                case ListType.ShoppingList:
                    foreach (ShoppingListElement listItem in ((ShoppingListObject)parameter).ShoppingList)
                    {
                        listItem.Category = category;
                        _objects[index].ShoppingList.Add(listItem);
                    }
                    break;
                case ListType.ItemsList:
                    foreach (ShoppingListElement listItem in ((ShoppingListObject)parameter).ShoppingListItems)
                    {
                        listItem.Category = category;
                        _objects[index].ShoppingListItems.Add(listItem);
                    }
                    break;
            }
         
        }
    }
}
