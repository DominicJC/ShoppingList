using System.Collections.Generic;

using ShoppingList.Models;

namespace ShoppingList.Cmds
{
    class EditCategoryCommand : CommandBase
    {
        private readonly string DEFAULTCATEGORY = (string)App.Current.FindResource("DEFAULTCATEGORY");

        public EditCategoryCommand(IList<ShoppingListObject> objects) : base(objects) { }

        public override bool CanExecute(object parameter) => (parameter as string[]) != null
            && ((string[])parameter)[0] != DEFAULTCATEGORY
            && _objects != null
            && _objects.Count != 0;

        public override void Execute(object parameter)
        {
            foreach(ShoppingListObject obj in _objects)
            {
                if(Equals(obj.CategoryTitle, ((string[])parameter)[0]))
                {
                    obj.CategoryTitle = ((string[])parameter)[1];

                    foreach(ShoppingListElement element in obj.ShoppingList)
                    {
                        element.Category = ((string[])parameter)[1];
                    }

                    foreach (ShoppingListElement element in obj.ShoppingListItems)
                    {
                        element.Category = ((string[])parameter)[1];
                    }

                    SaveToFile(ListType.Categories);
                    break;
                }
            }
                     
        }
    }
}
