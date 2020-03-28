using System;
using System.Collections.Generic;
using System.Text;
using TemplateMethodPattern.Abstracts;

namespace TemplateMethodPattern.Concretes
{
    public class Tea : CaffeineBeverage
    {
        public override void AddCondiments()
        {
            Console.WriteLine("Lemon added.");
        }

        public override void Brew()
        {
            Console.WriteLine("Tea Soaked.");
        }
    }
}
