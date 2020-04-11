using StatePattern.Machine;
using System;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            GumballMachine machine = new GumballMachine(2);

            // Get gum ball 1
            machine.InsertQuarter();
            machine.TurnCrank();

            // Get gum ball 2
            machine.InsertQuarter();
            machine.TurnCrank();

            // Machine should be out of gumballs, try getting a gum ball now
            machine.InsertQuarter();
            machine.TurnCrank();

            machine.EjectQuarter();

            // Try again
            machine.InsertQuarter();
            machine.TurnCrank();
        }
    }
}
