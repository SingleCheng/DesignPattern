using System;

namespace DecoratorMode.Utilities
{
    public class SunRoofDecorator : Car
    {
        private readonly Car _car;

        public SunRoofDecorator(Car car)
        {
            _car = car;
        }

        public override void Description()
        {
            _car.Description();
            Console.WriteLine("Add SunRoof");
        }
    }
}