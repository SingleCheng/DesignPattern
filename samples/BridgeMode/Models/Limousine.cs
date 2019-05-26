using System;
using BridgeMode.Interfaces;

namespace BridgeMode.Models
{
    public class Limousine : Car
    {
        public Limousine(IEngine engine) : base(engine)
        {
        }

        public override void Start()
        {
            base.Start();
            Console.WriteLine("Limousine Start");
        }

        public override void Stop()
        {
            base.Stop();
            Console.WriteLine("Limousine Stop");
        }
    }
}