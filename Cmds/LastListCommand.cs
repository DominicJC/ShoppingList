/*
 * Restore last shopping list command. 
 * Retrieves last list from the data layer.
 * Iterates back through the categories, deleting each shopping list
 * and re-populating from the last list. 
 * As each list item is added, it is removed from the retrieved list 
 * so the entire list is not iterated through each time.  
 */
using System.Collections.Generic;
using System.Linq;

using ShoppingList.Models;
using ShoppingList.DataLayer;

namespace ShoppingList.Cmds
{
    class LastListCommand : CommandBase
    {
        private string LASTLISTPATH = (string)App.Current.FindResource("LASTLISTPATH");

        public LastListCommand(IList<ShoppingListObject> objects) : base(objects) { }

        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter)
        {
            GetLastList();
        }

        private void GetLastList()
        {
            GetListFromFile getList = new GetListFromFile(LASTLISTPATH);
            IList<string[]> LastList = getList.ListFromFile;

            
            for(int i = _objects.Count - 1; i >= 0; i--)
            {
                _objects[i].ShoppingList.Clear();

                for(int j = LastList.Count() - 1; j >= 0; j--)
                {
                    if(Equals(LastList[j][1], _objects[i].CategoryTitle))
                    {
                        _objects[i].ShoppingList.Add(new ShoppingListElement(LastList[j][0], LastList[j][1], int.Parse(LastList[j][2])));
                        LastList.RemoveAt(j);
                    }
                }
            }

            /*
            foreach(ShoppingListObject obj in _objects)
            {
                obj.ShoppingList.Clear();
                foreach(string[] listItem in LastList)
                {
                    if(Equals(listItem[1], obj.CategoryTitle))
                    {
                        obj.ShoppingList.Add(new ShoppingListElement(listItem[0], listItem[1], int.Parse(listItem[2])));
                    }
                }
            }
            */
            SaveToFile(ListType.ShoppingList);

        }
    }
}
