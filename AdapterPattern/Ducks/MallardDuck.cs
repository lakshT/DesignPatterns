using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.Ducks
{
    public class MallardDuck : IDuck
    {
        public void Fly()
        {
            Console.WriteLine("I am flying");
        }

        public void Quack()
        {
            Console.WriteLine("Quack Quack");
        }
    }
}
