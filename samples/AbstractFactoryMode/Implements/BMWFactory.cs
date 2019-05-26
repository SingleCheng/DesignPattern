using System;
using AbstractFactoryMode.Models;

namespace AbstractFactoryMode.Implements
{
    public class BmwFactory : CarFactory
    {
        public override void CreateWindows()
        {
            Console.WriteLine("Create BMW Windows");
        }

        public override void CreateWheels()
        {
            Console.WriteLine("Create BMW Wheels");
        }
    }
}