namespace DecoratorPattern.Abstract
{
    public abstract class Beverage
    {
        public string description = "Unknown beverage";

        public string GetDescription()
        {
            return description;
        }

        public abstract double Cost();
    }
}
