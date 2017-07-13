using ShoppingList.Models;

namespace ShoppingList.Cmds
{
    internal class IncreaseAmountCommand : CommandBase
    {
        public override bool CanExecute(object parameter) => (parameter as ShoppingListElement) != null;

        public override void Execute(object parameter)
        {
            ((ShoppingListElement)parameter).Amount++;
        }
    }
}
