using System.Collections.Generic;
using ShoppingList.Models;

namespace ShoppingList.Cmds
{
    class AddItemToLibraryCommand : CommandBase
    {
        public AddItemToLibraryCommand(IList<ShoppingListObject> objects) : base(objects) { }

        public override bool CanExecute(object parameter) => (parameter as ShoppingListElement) != null 
            && !string.IsNullOrEmpty(((ShoppingListElement)parameter).Item) 
            && !string.IsNullOrWhiteSpace(((ShoppingListElement)parameter).Item);
        

        public override void Execute(object parameter)
        {
            string item = ((ShoppingListElement)parameter).Item.Trim(); 
            string category = ((ShoppingListElement)parameter).Category;
            ListType list = ListType.ItemsList;

            IList<ShoppingListElement> _elements = GetElements(category, list);
            ShoppingListElement newElement = new ShoppingListElement(item, category);

            if (!_elements.Contains(newElement))
            {
                _elements.Add(newElement);
            }

            SaveToFile(ListType.ItemsList);
            
        }

    }
}
