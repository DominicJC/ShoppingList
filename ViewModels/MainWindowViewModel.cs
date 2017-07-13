/*
 * View Model for main window. 
 * Contains a property for the CategoriesForShoppingList class which is instantiated on launch.
 * Also contains all the commands for the view.
 */
using System.Windows.Input;

using ShoppingList.Models;
using ShoppingList.Cmds;


namespace ShoppingList.ViewModels
{
    class MainWindowViewModel
    {
        public CategoriesForShoppingList shoppingListCategories { get; set; }


        private ICommand increaseAmountCommand = null;
        public ICommand IncreaseAmountCmd => increaseAmountCommand ?? (increaseAmountCommand = new IncreaseAmountCommand());

        private ICommand decreaseAmountCommand = null;
        public ICommand DecreaseAmountCmd => decreaseAmountCommand ?? (decreaseAmountCommand = new DecreaseAmountCommand());

        private ICommand addItemCommand = null;
        public ICommand AddItemCmd => addItemCommand ?? (addItemCommand = new AddItemCommand(shoppingListCategories.categories));

        private ICommand removeItemCommand = null;
        public ICommand RemoveItemCmd => removeItemCommand ?? (removeItemCommand = new RemoveItemCommand(shoppingListCategories.categories));

        private ICommand exitAppCommand = null;
        public ICommand ExitAppCmd => exitAppCommand ?? (exitAppCommand = new ExitAppCommand());

        private ICommand newListCommand = null;
        public ICommand NewListCmd => newListCommand ?? (newListCommand = new NewListCommand(shoppingListCategories.categories));

        private ICommand addItemToLibraryCommand = null;
        public ICommand AddItemToLibraryCmd => addItemToLibraryCommand ?? (addItemToLibraryCommand = new AddItemToLibraryCommand(shoppingListCategories.categories));

        private ICommand removeItemFromLibraryCommand = null;
        public ICommand RemoveItemFromLibraryCmd => removeItemFromLibraryCommand ?? (removeItemFromLibraryCommand = new RemoveItemFromLibraryCommand(shoppingListCategories.categories));

        private ICommand addCategoryCommand = null;
        public ICommand AddCategoryCmd => addCategoryCommand ?? (addCategoryCommand = new AddCategoryCommand(shoppingListCategories.categories));

        private ICommand removeCategoryCommand = null;
        public ICommand RemoveCategoryCmd => removeCategoryCommand ?? (removeCategoryCommand = new RemoveCategoryCommand(shoppingListCategories.categories));

        private ICommand editCategoryCommand = null;
        public ICommand EditCategoryCmd => editCategoryCommand ?? (editCategoryCommand = new EditCategoryCommand(shoppingListCategories.categories));

        private ICommand restoreDefaultsCommand = null;
        public ICommand RestoreDefaultsCmd => restoreDefaultsCommand ?? (restoreDefaultsCommand = new RestoreDefaultsCommand(shoppingListCategories.categories));

        private ICommand lastListCommand = null;
        public ICommand LastListCmd => lastListCommand ?? (lastListCommand = new LastListCommand(shoppingListCategories.categories));


        public MainWindowViewModel()
        {
            shoppingListCategories = new CategoriesForShoppingList();
        }

    }
}
