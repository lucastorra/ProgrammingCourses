namespace ByteBank.Employees
{
    public class Developer : Employee
    {
        public Developer(string personID) : base(3000, personID)
        {
        }

        public override void IncreaseSalary()
        {
            Salary *= 0.15;
        }

        public override double GetBonus()
        {
            return Salary * 0.1;
        }
    }
}
