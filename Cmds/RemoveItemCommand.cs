using System.Collections.Generic;

using ShoppingList.Models;

namespace ShoppingList.Cmds
{
    internal class RemoveItemCommand : CommandBase
    {

        public RemoveItemCommand(IList<ShoppingListObject> objects) : base(objects) { }


        public override bool CanExecute(object parameter) =>
            (parameter as ShoppingListElement) != null && _objects != null && _objects.Count != 0;

        public override void Execute(object parameter)
        {
            string category = ((ShoppingListElement)parameter).Category;
            ListType list = ListType.ShoppingList;

            IList<ShoppingListElement> _elements = GetElements(category, list);

            _elements.Remove((ShoppingListElement)parameter);

            SaveToFile(ListType.ShoppingList);
        }
    }
}
