using System;

namespace FacadeMode
{
    public class Facade
    {
        private readonly SubSystemOne _one;
        private readonly SubSystemTwo _two;
        private readonly SubSystemThree _three;

        public Facade()
        {
            _one = new SubSystemOne();
            _two = new SubSystemTwo();
            _three = new SubSystemThree();
        }

        public void MethodA()
        {
            Console.WriteLine("\nMethodA() ----");
            SubSystemOne.MethodOne();
            SubSystemTwo.MethodTwo();
        }

        public void MethodB()
        {
            Console.WriteLine("\nMethodB() ----");
            SubSystemThree.MethodThree();
        }
    }
}