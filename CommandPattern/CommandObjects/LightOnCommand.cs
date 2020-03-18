using CommandPattern.Interfaces;
using CommandPattern.Receiver;

namespace CommandPattern.CommandObjects
{
    public class LightOnCommand : ICommand
    {
        Light light;
        public LightOnCommand(Light light)
        {
            this.light = light;
        }

        public void execute()
        {
            light.On();
        }
    }
}
