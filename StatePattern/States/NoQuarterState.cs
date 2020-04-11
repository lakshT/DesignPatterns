using StatePattern.Interfaces;
using StatePattern.Machine;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.States
{
    public class NoQuarterState : IState
    {
        GumballMachine machine;

        public NoQuarterState(GumballMachine machine)
        {
            this.machine = machine;
        }

        public void Dispense()
        {
            Console.WriteLine("Cannot dispense in this state, insert quarter...");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Cannot eject, no quarter inserted.");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Quarter inserted.");
            machine.SetState(machine.GetHasQuarterState());
        }

        public void TurnCrank()
        {
            Console.WriteLine("Cannot turn crank, no quarter inserted.");
        }
    }
}
