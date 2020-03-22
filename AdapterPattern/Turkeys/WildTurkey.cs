using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.Turkeys
{
    public class WildTurkey : ITurkey
    {
        public void Fly()
        {
            Console.WriteLine("I am flying a short distance");
        }

        public void Gobble()
        {
            Console.Write("Gobble Gobble");
        }
    }
}
