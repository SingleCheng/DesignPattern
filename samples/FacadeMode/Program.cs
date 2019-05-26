using System;

namespace FacadeMode
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Demo Facade Mode");

            var facade = new Facade();

            facade.MethodA();
            facade.MethodB();
        }
    }
}