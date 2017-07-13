using System.Collections.Generic;

namespace ShoppingList.DefaultLists
{
    class DefaultCategories
    {
        public IList<string[]> DefaultCategoryList { get; }


        public DefaultCategories()
        {
            DefaultCategoryList = new List<string[]>();
            PopulateList();
        }

        private void PopulateList()
        {
            DefaultCategoryList.Add(new string[] { "Fruit" });
            DefaultCategoryList.Add(new string[] { "Veg" });
            DefaultCategoryList.Add(new string[] { "Meat" });
            DefaultCategoryList.Add(new string[] { "Pantry" });
            DefaultCategoryList.Add(new string[] { "Cleaning" });
            DefaultCategoryList.Add(new string[] { "Health & Beauty" });
            DefaultCategoryList.Add(new string[] { "Homewares" });
            DefaultCategoryList.Add(new string[] { "Kids" });
            DefaultCategoryList.Add(new string[] { "Office" });
            DefaultCategoryList.Add(new string[] { "Misc" });
        }
    }
}
