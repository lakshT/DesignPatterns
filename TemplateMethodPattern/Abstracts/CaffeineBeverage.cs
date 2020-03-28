using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern.Abstracts
{
    public abstract class CaffeineBeverage
    {
        public void Prepare()
        {
            Boil();
            Brew();
            Pour();
            AddCondiments();
        }

        public void Boil()
        {
            Console.WriteLine("Water boiled.");
        }

        public abstract void Brew();

        public void Pour()
        {
            Console.WriteLine("Poured in a Mug.");
        }

        public abstract void AddCondiments();
    }
}
