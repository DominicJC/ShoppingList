
namespace ShoppingList.Cmds
{
    class ExitAppCommand : CommandBase
    {

        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter)
        {
            App.Current.Shutdown();
        }

    }
}
