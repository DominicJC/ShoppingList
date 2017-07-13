using System.Collections.Generic;

using ShoppingList.Models;

namespace ShoppingList.Cmds
{
    internal class AddItemCommand : CommandBase
    {
        public AddItemCommand(IList<ShoppingListObject> objects) : base(objects) { }

        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter)
        {
            string item = ((ShoppingListElement)parameter).Item;
            string category = ((ShoppingListElement)parameter).Category;
            ListType list = ListType.ShoppingList;

            IList<ShoppingListElement> _elements = GetElements(category, list);

            if (!_elements.Contains((ShoppingListElement)parameter))
            {
                _elements?.Add(new ShoppingListElement (item,category));
            }

            SaveToFile(ListType.ShoppingList);
        }

    }
}
