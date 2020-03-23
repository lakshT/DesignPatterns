using FacadePattern.Components;
using FacadePattern.Facade;
using System;

namespace FacadePattern
{
    class Program
    {
        // This is the client for the basic home theatre.
        static void Main(string[] args)
        {
            var projector = new Projector();
            var soundBar = new SoundBar();
            var popcornMaker = new PopcornMaker();

            var basicHomeTheatreFacade = new BasicHomeTheatreFacade(projector, soundBar, popcornMaker);
            basicHomeTheatreFacade.WatchMovie();

            Console.WriteLine("\n");

            basicHomeTheatreFacade.EndMovie();

            Console.ReadLine();
        }
    }
}
