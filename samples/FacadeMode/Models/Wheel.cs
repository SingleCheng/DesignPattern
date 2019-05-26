using System;

namespace FacadeMode
{
    public class Wheel
    {
        public void TurnOn()
        {
            Console.WriteLine("Wheel is turned");
        }
        public void Stop()
        {
            Console.WriteLine("Wheel is stopped");
        }
    }
}