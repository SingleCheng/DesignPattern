using System;

namespace DecoratorMode.Models
{
    public class EspDecorator : Car
    {
        private readonly Car _car;

        public EspDecorator(Car car)
        {
            _car = car;
        }

        public override void Description()
        {
            _car.Description();
            Console.WriteLine("Add ESP");
        }
    }
}