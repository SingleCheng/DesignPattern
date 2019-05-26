using System;
using AbstractFactoryMode.Abstract;

namespace AbstractFactoryMode.Implements
{
    public class BenzFactory : CarFactory
    {
        public override void CreateWindows()
        {
            Console.WriteLine("Create Benz Windows");
        }

        public override void CreateWheels()
        {
            Console.WriteLine("Create Benz Wheels");
        }
    }
}