using System;

namespace DecoratorMode.Models
{
    public class Car
    {
        public virtual void Description()
        {
            Console.WriteLine("Basic Car");
        }
    }
}