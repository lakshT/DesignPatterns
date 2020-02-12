using DecoratorPattern.Abstract;

namespace DecoratorPattern.Concretes.Condiments
{
    public class Whip : CondimentsDecorator
    {
        CondimentsDecorator decorator;

        public Whip(CondimentsDecorator decorator)
        {
            this.decorator = decorator;
        }

        public override string GetDescription()
        {
            return decorator.GetDescription() + ", Whip";
        }

        public override double Cost()
        {
            return decorator.Cost() + 0.10;
        }
    }
}
