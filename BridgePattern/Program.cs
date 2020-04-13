using BridgePattern.Devices;
using BridgePattern.Interfaces;
using BridgePattern.Remotes;
using System;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IDevice device = new Radio();
            var remote = new AdvanceRemote(device);

            remote.TogglePower();
            Console.WriteLine("Device Initial volume is: " + remote.GetDeviceVolume());
            remote.VolumeUp(5);
            Console.WriteLine("Increase volume by 5. Volume is: " + remote.GetDeviceVolume());
            remote.Mute();
            Console.WriteLine("Device muted. Volume is: " + remote.GetDeviceVolume());
            remote.UnMute();
            Console.WriteLine("Device unmuted. Volume is: " + remote.GetDeviceVolume());
            remote.VolumeDown(5);
            Console.WriteLine("Decrease volume by 5. Volume is: " + remote.GetDeviceVolume());
            remote.TogglePower();
        }
    }
}
