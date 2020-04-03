using IteratorPattern.Interfaces;
using IteratorPattern.Menu;
using IteratorPattern.Menus;
using System;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            DinerMenu dinerMenu = new DinerMenu();
            PancakeHouseMenu pancakeHouseMenu = new PancakeHouseMenu();

            IIterator dinerMenuIterator = dinerMenu.CreateIterator();
            IIterator pancakeHouseMenuIterator = pancakeHouseMenu.CreateIterator();

            while (dinerMenuIterator.HasNext())
            {
                var menuItem = (MenuItem)dinerMenuIterator.Next();
                Console.WriteLine("Name: " + menuItem.Name);
                Console.WriteLine("Description: " + menuItem.Description);
                Console.WriteLine("Price: " + menuItem.Price);
                Console.WriteLine("Vegetarian: " + menuItem.IsVegetarian);
                Console.WriteLine();
            }

            while (pancakeHouseMenuIterator.HasNext())
            {
                var menuItem = (MenuItem)pancakeHouseMenuIterator.Next();
                Console.WriteLine("Name: " + menuItem.Name);
                Console.WriteLine("Description: " + menuItem.Description);
                Console.WriteLine("Price: " + menuItem.Price);
                Console.WriteLine("Vegetarian: " + menuItem.IsVegetarian);
                Console.WriteLine();
            }
        }
    }
}
