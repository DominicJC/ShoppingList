
using ShoppingList.Models;

namespace ShoppingList.Cmds
{
    internal class DecreaseAmountCommand : CommandBase
    {
        public override bool CanExecute(object parameter) => (parameter as ShoppingListElement) != null;

        public override void Execute(object parameter)
        {
            if (((ShoppingListElement)parameter).Amount == 1) return;
            ((ShoppingListElement)parameter).Amount--;
        }
    }
}
