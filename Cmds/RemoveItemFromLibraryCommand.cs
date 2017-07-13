using System.Collections.Generic;

using ShoppingList.Models;

namespace ShoppingList.Cmds
{
    class RemoveItemFromLibraryCommand : CommandBase
    {
        public RemoveItemFromLibraryCommand(IList<ShoppingListObject> objects) : base(objects) { }

        public override bool CanExecute(object parameter) =>
            (parameter as ShoppingListElement) != null && _objects != null && _objects.Count != 0;

        public override void Execute(object parameter)
        {
            string category = ((ShoppingListElement)parameter).Category;
            ListType list = ListType.ItemsList;

            IList<ShoppingListElement> _elements = GetElements(category, list);

            _elements.Remove((ShoppingListElement)parameter);

            SaveToFile(ListType.ItemsList);
        }
    }
}
