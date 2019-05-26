using System;
using BridgeMode.Interfaces;

namespace BridgeMode.Implements
{
    public class GasEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Gas Engine Start");
        }

        public void Stop()
        {
            Console.WriteLine("Gas Engine Stop");
        }
    }
}