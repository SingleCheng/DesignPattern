using System;
using StrategyMode.Implements;

namespace StrategyMode
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Strategy Mode Demo");

            Console.WriteLine("Please Input Type： Lan、Serial");
            var input = Console.ReadLine();
            var data = new object();
            var ct = new Context();
            if (input != null && input.Equals("Lan"))
            {
                ct.SetStrategy(new Lan());
            }
            else
            {
                ct.SetStrategy(new Serial());
            }

            ct.Send(data);
        }
    }
}