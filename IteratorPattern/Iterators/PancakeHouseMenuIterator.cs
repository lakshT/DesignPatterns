using IteratorPattern.Interfaces;
using IteratorPattern.Menu;
using System;
using System.Collections.Generic;

namespace IteratorPattern.Iterators
{
    public class PancakeHouseMenuIterator : IIterator
    {
        List<MenuItem> menuItems;

        public PancakeHouseMenuIterator(List<MenuItem> menuItems)
        {
            this.menuItems = menuItems;
        }

        public bool HasNext()
        {
            if (menuItems.Count <= 0)
            {
                return false;
            }
            return true;
        }

        public object Next()
        {
            var menuItem = menuItems[0];
            menuItems.Remove(menuItem);
            return menuItem;
        }
    }
}
