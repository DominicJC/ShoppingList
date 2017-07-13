using System.Collections.Generic;

using ShoppingList.Models;

namespace ShoppingList.Cmds
{
    class NewListCommand : CommandBase
    {
        public NewListCommand(IList<ShoppingListObject> objects) : base(objects) { }

        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter)
        {
            SaveToFile(ListType.NewShoppingList);
            NewList();
        }

        private void NewList()
        {
            foreach(ShoppingListObject obj in _objects)
            {
                obj.ShoppingList.Clear();
            }

            SaveToFile(ListType.ShoppingList);
        }
    }
}
