using FactoryPattern.Interfaces;
using System;

namespace FactoryPattern.Concretes
{
    public class VegPizza : IPizza
    {
        public void Prepare()
        {
            Console.WriteLine("Veg pizza prepared.");
        }

        public void Bake()
        {
            Console.WriteLine("Veg pizza baked.");
        }

        public void Cut()
        {
            Console.WriteLine("Veg pizza cut.");
        }

        public void Box()
        {
            Console.WriteLine("Veg pizza boxed.");
        }
    }
}
