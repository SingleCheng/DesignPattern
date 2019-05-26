namespace TemplateMethodMode.Models
{
    public abstract class Employee
    {
        public void GetSalary()
        {
            GetBasicSalary();
            AddBonus();
        }
        
        protected abstract void GetBasicSalary();
        
        protected abstract void AddBonus();
    }
}