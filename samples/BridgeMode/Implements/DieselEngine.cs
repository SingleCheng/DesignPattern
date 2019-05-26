using System;
using BridgeMode.Interfaces;

namespace BridgeMode.Implements
{
    public class DieselEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Diesel Engine Start");
        }

        public void Stop()
        {
            Console.WriteLine("Diesel Engine Stop");
        }
    }
}