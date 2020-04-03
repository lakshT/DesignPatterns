using IteratorPattern.Interfaces;
using IteratorPattern.Iterators;
using IteratorPattern.Menu;
using System;

namespace IteratorPattern.Menus
{
    public class DinerMenu
    {
        private const int maximumItems = 6;
        private int numberOfItems = 0;
        MenuItem[] menuItems;

        public DinerMenu()
        {
            menuItems = new MenuItem[maximumItems];

            AddItem("Vegetarian BLT", "(Fakin’) Bacon with lettuce & tomato on whole wheat", 2.99, true);
            AddItem("BLT", "Bacon with lettuce & tomato on whole wheat", 2.99, false);
            AddItem("Soup of the day", "Soup of the day, with a side of potato salad", 3.29, false);
            AddItem("Hotdog", "A hot dog, with saurkraut, relish, onions, topped with cheese", 3.05, false);
        }

        public void AddItem(string name, string description, double price, bool isVegetarian)
        {
            MenuItem menuItem = new MenuItem()
            {
                Name = name,
                Description = description,
                Price = price,
                IsVegetarian = isVegetarian
            };

            if(numberOfItems >= maximumItems)
            {
                Console.WriteLine("Array full. Cannot add more items.");
            }
            else
            {
                menuItems[numberOfItems] = menuItem;
                numberOfItems = numberOfItems + 1;
            }
        }

        // this is not needed when we have a diner menu iterator
        public MenuItem[] GetMenuItems()
        {
            return menuItems;
        }

        public IIterator CreateIterator()
        {
            return new DinerMenuIterator(menuItems);
        }
    }
}
