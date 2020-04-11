using StatePattern.Interfaces;
using StatePattern.Machine;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.States
{
    public class HasQuarterState : IState
    {
        GumballMachine machine;

        public HasQuarterState(GumballMachine machine)
        {
            this.machine = machine;
        }

        public void Dispense()
        {
            Console.WriteLine("Cannot dispense in this state, turn crank to dispense.");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Quarter returned.");
            machine.SetState(machine.GetNoQuarterState());
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Already has quarter, cannot insert another quarter.");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Crank turned...");
            machine.SetState(machine.GetSoldState());
        }
    }
}
