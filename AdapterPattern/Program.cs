using AdapterPattern.Adapters;
using AdapterPattern.Ducks;
using AdapterPattern.Turkeys;
using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var wildTurkey = new WildTurkey();
            var turkeyAdapter = new TurkeyAdapter(wildTurkey);
            turkeyAdapter.Quack();
            turkeyAdapter.Fly();
        }
    }
}
