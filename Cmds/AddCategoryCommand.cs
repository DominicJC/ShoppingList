using System.Collections.Generic;

using ShoppingList.Models;

namespace ShoppingList.Cmds
{
    class AddCategoryCommand : CommandBase
    {
        public AddCategoryCommand(IList<ShoppingListObject> objects) : base(objects) { }

        public override bool CanExecute(object parameter) => (parameter as string) != null
            && !string.IsNullOrEmpty(((string)parameter))
            && !string.IsNullOrWhiteSpace(((string)parameter));

        public override void Execute(object parameter)
        {
            ShoppingListObject newObject = new ShoppingListObject((string)parameter);
            if (!_objects.Contains(newObject))
            {
                _objects.Add(newObject);
            }

            SaveToFile(ListType.Categories);
        }
    }
}
