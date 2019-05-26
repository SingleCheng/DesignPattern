using System;
using FacadeMode.Utilities;

namespace FacadeMode
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Demo Facade Mode");

            var car = new CarFacade();
            car.Run();
            car.Brake();
        }
    }
}