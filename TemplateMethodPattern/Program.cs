using System;
using TemplateMethodPattern.Concretes;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Tea tea = new Tea();
            tea.Prepare();

            Console.WriteLine();

            Coffee coffee = new Coffee();
            coffee.Prepare();

            Console.ReadLine();
        }
    }
}
