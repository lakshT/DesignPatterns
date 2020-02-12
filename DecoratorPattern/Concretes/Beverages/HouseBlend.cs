using DecoratorPattern.Abstract;

namespace DecoratorPattern.Concretes
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "House blend";
        }

        public override double Cost()
        {
            return .89;
        }
    }
}
