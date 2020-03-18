namespace Lab5.TablePerInheritance
{
    public abstract class Employee : Entity
    {
        public string Name { get; set; }
    }

    public class HourlyEmployee : Employee
    {
        public decimal Wage { get; set; }
    }

    public class FullTimeEmployee : Employee
    {
        public decimal Salary { get; set; }
    }
}