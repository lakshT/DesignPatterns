using System;
using FactoryPattern.Factories;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var pizzaStore = new PizzaStore(new SimplePizzaFactory());
            pizzaStore.completePizzaOrder("Cheese");
            pizzaStore.completePizzaOrder("Veg");

            Console.ReadKey();
        }
    }
}
