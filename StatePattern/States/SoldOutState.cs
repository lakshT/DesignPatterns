using StatePattern.Interfaces;
using StatePattern.Machine;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.States
{
    public class SoldOutState : IState
    {
        GumballMachine machine;

        public SoldOutState(GumballMachine machine)
        {
            this.machine = machine;
        }

        public void Dispense()
        {
            Console.WriteLine("Cannot dispense, machine is out of gum balls.");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Ejecting your quarter, please collect.");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Machine is out of gum balls, cannot accept your quarter");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Cannot turn crank, machine is out of gum balls.");
        }
    }
}
