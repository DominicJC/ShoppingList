/*
 * This class is the basic element that makes up the shopping list or items library.
 * Each element contains 3 properties, two strings and an integer representing the 
 * item name, category and amount.
 * The class implements INotifyPropertyChanged so has the appropriate event, method 
 * and setters in the properties. 
 * It also implements IEquatable and compares based on the string value of the item 
 * property.
 */
using System;
using System.ComponentModel;

namespace ShoppingList.Models
{
    class ShoppingListElement : INotifyPropertyChanged, IEquatable<ShoppingListElement>
    {
        private string item;
        public string Item
        {
            get { return item; }
            set
            {
                if (value == item) return;
                item = value;
                OnPropertyChanged(nameof(Item));
            }
        }

        private string category;
        public string Category
        {
            get { return category; }
            set
            {
                if (value == category) return;
                category = value;
                OnPropertyChanged(nameof(Category));
            }
        }

        private int amount;
        public int Amount
        {
            get { return amount; }
            set
            {
                if (value == amount) return;
                amount = value;
                OnPropertyChanged(nameof(Amount));
            }
        }

        public ShoppingListElement(string item, string category)
        {
            this.Item = item;
            this.Category = category;
            this.Amount = 1;
        }

        public ShoppingListElement(string item, string category, int amount)
        {
            this.Item = item;
            this.Category = category;
            this.Amount = amount;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public bool Equals(ShoppingListElement other)
        {
            if (string.Equals(this.Item, other.Item)) return true;
            else return false;
        }
    }
}
