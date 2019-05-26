using System;
using AbstractFactoryMode.Abstract;
using AbstractFactoryMode.Implements;

namespace AbstractFactoryMode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstract Factory Mode");

            CarFactory carFactory = new BenzFactory();
            carFactory.CreateWindows();
            carFactory.CreateWheels();

            Console.WriteLine("Change Factory To BMWFactory");
            carFactory = new BMWFactory();
            carFactory.CreateWindows();
            carFactory.CreateWheels();
        }
    }
}