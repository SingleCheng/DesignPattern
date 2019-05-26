using System;
using BridgeMode.Interfaces;

namespace BridgeMode.Model
{
    public class Bus : Car
    {
        public Bus(IEngine engine)
            : base(engine)
        {
        }

        public override void Start()
        {
            base.Start();
            Console.WriteLine("Bus Start");
        }

        public override void Stop()
        {
            base.Stop();
            Console.WriteLine("Bus Stop");
        }
    }
}