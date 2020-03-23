using System;

namespace FacadePattern.Components
{
    public class PopcornMaker
    {
        public void TurnOn()
        {
            Console.WriteLine("Popcorn maker turned on.");
        }

        public void MakePopcorn()
        {
            Console.WriteLine("Popcorn ready... Enjoy your movie.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Popcorn maker turned off.");
        }
    }
}
