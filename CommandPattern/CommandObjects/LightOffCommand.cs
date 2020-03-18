using CommandPattern.Interfaces;
using CommandPattern.Receiver;

namespace CommandPattern.CommandObjects
{
    public class LightOffCommand : ICommand
    {
        Light light; 
        public LightOffCommand(Light light)
        {
            this.light = light;
        }
        public void execute()
        {
            light.Off();
        }
    }
}
