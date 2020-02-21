using FactoryPattern.Concretes;
using FactoryPattern.Interfaces;

namespace FactoryPattern.Factories
{
    public class SimplePizzaFactory
    {
        public IPizza CreatePizza(string pizzaType)
        {
            IPizza pizza = null;

            if(pizzaType == "Cheese")
            {
                pizza = new CheesePizza();
            }
            if(pizzaType == "Veg")
            {
                pizza = new VegPizza();
            }
            return pizza;
        }
    }
}
