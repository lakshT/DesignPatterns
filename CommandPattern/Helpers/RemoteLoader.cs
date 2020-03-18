using CommandPattern.Receiver;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Helpers
{
    public class RemoteLoader
    {
        private static Light light;

        public static Light GetLightInstance()
        {
            if (light == null)
            {
                light = new Light();
            }
            return light;
        }
    }
}
