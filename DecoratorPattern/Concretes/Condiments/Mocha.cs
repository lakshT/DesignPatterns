using DecoratorPattern.Abstract;

namespace DecoratorPattern.Concretes.Condiments
{
    public class Mocha : CondimentsDecorator
    {
        Beverage beverage;
        
        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Mocha";
        }

        public override double Cost()
        {
            return beverage.Cost() + 0.49;
        }
    }
}
