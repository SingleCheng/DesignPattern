using System;

namespace TemplateMethodMode
{
    public class Ceo : Employee
    {
        protected override void GetBasicSalary()
        {
            Console.WriteLine("Get CEO Basic Salary");
        }

        protected override void AddBonus()
        {
            Console.WriteLine("Add CEO Bonus");
        }
    }
}