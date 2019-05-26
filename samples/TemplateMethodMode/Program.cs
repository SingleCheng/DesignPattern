using System;

namespace TemplateMethodMode
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Template Method Mode Demo");

            var manager = new Manager();
            manager.GetSalary();

            var ceo = new Ceo();
            ceo.GetSalary();
        }
    }
}