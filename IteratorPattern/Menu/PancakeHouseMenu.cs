using IteratorPattern.Interfaces;
using IteratorPattern.Iterators;
using IteratorPattern.Menu;
using System.Collections.Generic;

namespace IteratorPattern.Menus
{
    public class PancakeHouseMenu
    {
        public List<MenuItem> menuItems;

        public PancakeHouseMenu()
        {
            menuItems = new List<MenuItem>();

            AddItem("K & B’s Pancake Breakfast", 
                "Pancakes with scrambled eggs, and toast", 
                2.99, true);

            AddItem("Regular Pancake Breakfast",
                "Pancakes with fried eggs, sausage",
                2.99, false);

            AddItem("Blueberry Pancakes",
            "Pancakes made with fresh blueberries",
            3.49, true);

            AddItem("Waffles",
            "Waffles, with your choice of blueberries or strawberries",
            3.59, true);
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

            menuItems.Add(menuItem);
        }

        // We do not need this when using PancakeHouseIterator
        public List<MenuItem> GetMenuItems()
        {
            return menuItems;
        }

        public IIterator CreateIterator()
        {
            return new PancakeHouseMenuIterator(menuItems);
        }
    }
}
