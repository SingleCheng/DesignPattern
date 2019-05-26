using System;
using DecoratorMode.Models;

namespace DecoratorMode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Decorator Mode Demo");

            Car car = new EspDecorator(new CcsDecorator(new SunRoofDecorator(new Car())));
            car.Description();
        }
    }
}