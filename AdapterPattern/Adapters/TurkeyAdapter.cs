using AdapterPattern.Ducks;
using AdapterPattern.Turkeys;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.Adapters
{
    public class TurkeyAdapter : IDuck
    {
        ITurkey turkey;
        public TurkeyAdapter(ITurkey turkey)
        {
            this.turkey = turkey;
        }

        public void Quack()
        {
            turkey.Gobble();
        }

        public void Fly()
        {
            Console.WriteLine();
            for(int i = 0; i < 5; i++)
            {
                turkey.Fly();
            }
        }
    }
}
