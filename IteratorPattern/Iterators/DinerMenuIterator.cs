using IteratorPattern.Interfaces;
using IteratorPattern.Menu;

namespace IteratorPattern.Iterators
{
    public class DinerMenuIterator : IIterator
    {
        MenuItem[] menuItems;
        int position = 0;

        public DinerMenuIterator(MenuItem[] menuItems)
        {
            this.menuItems = menuItems;
        }

        public bool HasNext()
        {
            if (position >= menuItems.Length || menuItems[position] == null)
            {
                return false;
            }
            return true;
        }

        public object Next()
        {
            var menuItem = menuItems[position];
            position++;
            return menuItem;
        }
    }
}
