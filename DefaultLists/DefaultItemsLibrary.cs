using System.Collections.Generic;

namespace ShoppingList.DefaultLists
{
    class DefaultItemsLibrary
    {
        public IList<string[]> DefaultItemsList { get; }


        public DefaultItemsLibrary()
        {
            DefaultItemsList = new List<string[]>();
            PopulateList();
        }

        private void PopulateList()
        {
            DefaultItemsList.Add(new string[] { "Apple", "Fruit" });
            DefaultItemsList.Add(new string[] { "Avocado", "Fruit" });
            DefaultItemsList.Add(new string[] { "Banana", "Fruit" });
            DefaultItemsList.Add(new string[] { "Blueberries", "Fruit" });
            DefaultItemsList.Add(new string[] { "Grapefruit", "Fruit" });
            DefaultItemsList.Add(new string[] { "Grapes", "Fruit" });
            DefaultItemsList.Add(new string[] { "Kiwifruit", "Fruit" });
            DefaultItemsList.Add(new string[] { "Lemon", "Fruit" });
            DefaultItemsList.Add(new string[] { "Lime", "Fruit" });
            DefaultItemsList.Add(new string[] { "Mandarin", "Fruit" });
            DefaultItemsList.Add(new string[] { "Mango", "Fruit" });
            DefaultItemsList.Add(new string[] { "Melon", "Fruit" });
            DefaultItemsList.Add(new string[] { "Orange", "Fruit" });
            DefaultItemsList.Add(new string[] { "Pear", "Fruit" });
            DefaultItemsList.Add(new string[] { "Pineapple", "Fruit" });
            DefaultItemsList.Add(new string[] { "Raspberries", "Fruit" });
            DefaultItemsList.Add(new string[] { "Strawberries", "Fruit" });

            DefaultItemsList.Add(new string[] { "Bok Choy", "Veg" });
            DefaultItemsList.Add(new string[] { "Broccoli", "Veg" });
            DefaultItemsList.Add(new string[] { "Cabbage", "Veg" });
            DefaultItemsList.Add(new string[] { "Capsicum", "Veg" });
            DefaultItemsList.Add(new string[] { "Cauliflower", "Veg" });
            DefaultItemsList.Add(new string[] { "Celery", "Veg" });
            DefaultItemsList.Add(new string[] { "Coleslaw", "Veg" });
            DefaultItemsList.Add(new string[] { "Courgette", "Veg" });
            DefaultItemsList.Add(new string[] { "Cucumber", "Veg" });
            DefaultItemsList.Add(new string[] { "Garlic", "Veg" });
            DefaultItemsList.Add(new string[] { "Green Beans", "Veg" });
            DefaultItemsList.Add(new string[] { "Leek", "Veg" });
            DefaultItemsList.Add(new string[] { "Lettuce", "Veg" });
            DefaultItemsList.Add(new string[] { "Onion", "Veg" });
            DefaultItemsList.Add(new string[] { "Potato", "Veg" });
            DefaultItemsList.Add(new string[] { "Shallots", "Veg" });
            DefaultItemsList.Add(new string[] { "Spinach", "Veg" });           
            DefaultItemsList.Add(new string[] { "Spring Onion", "Veg" });
            DefaultItemsList.Add(new string[] { "Sweet Potato", "Veg" });
            DefaultItemsList.Add(new string[] { "Tomato", "Veg" });

            DefaultItemsList.Add(new string[] { "Beef Mince", "Meat" });
            DefaultItemsList.Add(new string[] { "Butter", "Pantry" });
            DefaultItemsList.Add(new string[] { "Bathroom Cleaner", "Cleaning" });
            DefaultItemsList.Add(new string[] { "Toothpaste", "Health & Beauty" });
            DefaultItemsList.Add(new string[] { "Plastic Boxes", "Homewares" });
            DefaultItemsList.Add(new string[] { "Nappies", "Kids" });
            DefaultItemsList.Add(new string[] { "Batteries", "Office" });
        }
    }
}
