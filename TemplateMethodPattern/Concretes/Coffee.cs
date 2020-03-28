using System;
using System.Collections.Generic;
using System.Text;
using TemplateMethodPattern.Abstracts;

namespace TemplateMethodPattern.Concretes
{
    public class Coffee : CaffeineBeverage
    {
        public override void AddCondiments()
        {
            Console.WriteLine("Sugar and Milk added.");
        }

        public override void Brew()
        {
            Console.WriteLine("Coffee dripped through filter.");
        }
    }
}
