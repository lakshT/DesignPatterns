using System;
using FactoryPattern.Factories;
using FactoryPattern.Interfaces;

namespace FactoryPattern
{
    public class PizzaStore
    {
        SimplePizzaFactory simplePizzaFactory;
        public PizzaStore(SimplePizzaFactory simplePizzaFactory)
        {
            this.simplePizzaFactory = simplePizzaFactory;
        }

        public void completePizzaOrder(string pizzaType)
        {
            Console.WriteLine("\n\n");
            Console.WriteLine(pizzaType + " pizza ordered.");
            IPizza pizza = simplePizzaFactory.CreatePizza(pizzaType);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
        }
    }
}
