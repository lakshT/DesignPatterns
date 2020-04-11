using StatePattern.Interfaces;
using StatePattern.States;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.Machine
{
    public class GumballMachine
    {
        IState noQuarterState;
        IState hasQuarterState;
        IState soldState;
        IState soldOutState;

        IState state;
        int gumBallCount = 0;

        public GumballMachine(int gumballs)
        {
            noQuarterState = new NoQuarterState(this);
            hasQuarterState = new HasQuarterState(this);
            soldState = new SoldState(this);
            soldOutState = new SoldOutState(this);

            gumBallCount = gumballs;
            state = gumballs > 0 ? noQuarterState : soldOutState; 
        }

        #region Gum ball machine events/transitions
        public void InsertQuarter()
        {
            state.InsertQuarter();
        }

        public void EjectQuarter()
        {
            state.EjectQuarter();
        }

        public void TurnCrank()
        {
            state.TurnCrank();
            state.Dispense();
        }
        #endregion

        public void SetState(IState state)
        {
            this.state = state;
        }

        public void ReleaseBall()
        {
            Console.WriteLine("Gumball comes out rolling.");
            if (gumBallCount != 0)
            {
                gumBallCount = gumBallCount - 1;
            }
        }

        #region State getters
        public IState GetHasQuarterState()
        {
            return hasQuarterState;
        }
        public IState GetNoQuarterState()
        {
            return noQuarterState;
        }
        public IState GetSoldState()
        {
            return soldState;
        }
        public IState GetSoldOutState()
        {
            return soldOutState;
        }
        #endregion  

        public int GetGumballCount()
        {
            return gumBallCount;
        }
    }
}
