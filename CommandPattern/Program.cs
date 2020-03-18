using CommandPattern.CommandObjects;
using CommandPattern.Helpers;
using System;

namespace CommandPattern
{
    /// <summary>
    /// In this project we are demonstrating command pattern by implementing
    /// a remote control.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Turn on the light
            var lightOnCommand = new LightOnCommand(RemoteLoader.GetLightInstance());
            lightOnCommand.execute();

            // Turn off the light
            var lightOffCommand = new LightOffCommand(RemoteLoader.GetLightInstance());
            lightOffCommand.execute();

            Console.ReadKey();
        }
    }
}
