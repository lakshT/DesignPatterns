using StatePattern.Interfaces;
using StatePattern.Machine;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.States
{
    public class SoldState : IState
    {
        GumballMachine machine;

        public SoldState(GumballMachine machine)
        {
            this.machine = machine;
        }

        public void Dispense()
        {
            if(machine.GetGumballCount() > 0)
            {
                machine.ReleaseBall();
                machine.SetState(machine.GetNoQuarterState());
            }
            else
            {
                Console.WriteLine("Machine is out of gum balls. Changing state to sold out.");
                machine.SetState(machine.GetSoldOutState());
            }
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Sorry, you already turned the crank.");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Please wait, we're giving you a gum ball.");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Please wait, we're giving you a gum ball. No need to turn crank again.");
        }
    }
}
