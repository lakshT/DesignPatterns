using DecoratorPattern.Abstract;
using DecoratorPattern.Concretes;
using DecoratorPattern.Concretes.Condiments;
using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage houseBlend = new HouseBlend();
            CondimentsDecorator mochaHouseBlend = new Mocha(houseBlend);
            CondimentsDecorator whipMochaHouseBlend = new Whip(mochaHouseBlend);

            Console.WriteLine("Coffee description: " + whipMochaHouseBlend.GetDescription());
            Console.WriteLine("Coffee cost: CAD " + whipMochaHouseBlend.Cost());
            Console.ReadKey();
        }
    }
}
