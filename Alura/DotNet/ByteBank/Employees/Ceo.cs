using System;

namespace ByteBank.Employees
{
    public class Ceo : Employee
    {
        public Ceo(string personID) : base(5000, personID)
        {
            Console.WriteLine("Create DIRETOR");
        }

        public override void IncreaseSalary()
        {
            Salary *= 1.15;
        }

        public override double GetBonus()
        {
            return Salary * 0.5;
        }
    }
}
