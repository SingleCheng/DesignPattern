using System;
using AbstractFactoryMode.Abstract;

namespace AbstractFactoryMode.Implements
{
    public class BMWFactory : CarFactory
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