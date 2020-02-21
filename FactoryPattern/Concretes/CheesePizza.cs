using FactoryPattern.Interfaces;
using System;

namespace FactoryPattern.Concretes
{
    public class CheesePizza : IPizza
    {
        public void Prepare()
        {
            Console.WriteLine("Cheese pizza prepared.");
        }
        
        public void Bake()
        {
            Console.WriteLine("Cheese pizza baked.");
        }

        public void Cut()
        {
            Console.WriteLine("Cheese pizza cut.");
        }

        public void Box()
        {
            Console.WriteLine("Cheese pizza boxed.");
        }
    }
}
