using System;
using BridgeMode.Implements;
using BridgeMode.Models;

namespace BridgeMode
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Bridge Mode Demo");

            var limousine = new Limousine(new GasEngine());
            var bus = new Bus(new DieselEngine());
            
            limousine.Start();
            limousine.Stop();
            
            bus.Start();
            bus.Stop();
        }
    }
}