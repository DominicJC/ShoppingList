using System.Collections.Generic;

using ShoppingList.Models;

namespace ShoppingList.Cmds
{
    class RemoveCategoryCommand : CommandBase
    {

        private readonly string DEFAULTCATEGORY = (string)App.Current.FindResource("DEFAULTCATEGORY");
        public RemoveCategoryCommand(IList<ShoppingListObject> objects) : base(objects) { }

        public override bool CanExecute(object parameter) => (parameter as ShoppingListObject) != null
            && ((ShoppingListObject)parameter).CategoryTitle != DEFAULTCATEGORY
            && _objects != null 
            && _objects.Count != 0;

        public override void Execute(object parameter)
        {
            MoveItemsToNewCategory(parameter, DEFAULTCATEGORY, ListType.ShoppingList);
            MoveItemsToNewCategory(parameter, DEFAULTCATEGORY, ListType.ItemsList);

            _objects.Remove((ShoppingListObject)parameter);

            SaveToFile(ListType.Categories);
            SaveToFile(ListType.ItemsList);
        }

    }
}
