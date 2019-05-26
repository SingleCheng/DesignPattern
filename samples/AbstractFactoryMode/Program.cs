using System;
using AbstractFactoryMode.Implements;
using AbstractFactoryMode.Models;

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
            carFactory = new BmwFactory();
            carFactory.CreateWindows();
            carFactory.CreateWheels();
        }
    }
}