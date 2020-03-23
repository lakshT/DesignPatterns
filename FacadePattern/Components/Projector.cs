using System;

namespace FacadePattern.Components
{
    public class Projector
    {
        public void TurnOn()
        {
            Console.WriteLine("Projector turned on.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Projector turned off.");
        }
    }
}
