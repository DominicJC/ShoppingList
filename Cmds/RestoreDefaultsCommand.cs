using System.Collections.Generic;

using ShoppingList.DefaultLists;
using ShoppingList.DataLayer;
using ShoppingList.Models;

namespace ShoppingList.Cmds
{
    class RestoreDefaultsCommand : CommandBase
    {
        private readonly string ITEMSPATH = (string)App.Current.FindResource("ITEMSPATH");
        private readonly string CATEGORIESPATH = (string)App.Current.FindResource("CATEGORIESPATH");

        public RestoreDefaultsCommand(IList<ShoppingListObject> objects) : base(objects) { }

        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter)
        {
            
            RestoreDefaultCategories();
        }

        private void RestoreDefaultCategories()
        {
            DeleteFile.Delete(ITEMSPATH);

            for (int i = _objects.Count - 1; i >= 0; i--)
            {
                _objects.RemoveAt(i);
            }

            DefaultCategories defaultCategories = new DefaultCategories();
            IList<string[]> defaultCats = defaultCategories.DefaultCategoryList;
            WriteListToFile set = new WriteListToFile(defaultCats, CATEGORIESPATH);

            foreach (string[] category in defaultCats)
            {
                _objects.Add(new ShoppingListObject(category[0]));
            }         
        }    
    }
}
