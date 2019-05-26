using System;

namespace DecoratorMode.Models
{
    public class CcsDecorator : Car
    {
        private readonly Car _car;

        public CcsDecorator(Car car)
        {
            _car = car;
        }

        public override void Description()
        {
            _car.Description();
            Console.WriteLine("Add CCS");
        }
    }
}