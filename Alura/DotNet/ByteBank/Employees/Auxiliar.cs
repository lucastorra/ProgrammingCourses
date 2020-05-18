namespace ByteBank.Employees
{
    public class Auxiliar : Employee
    {
        public Auxiliar(string personID) : base(2000, personID)
        {
        }

        public override void IncreaseSalary()
        {
            Salary *= 1.1;
        }

        public override double GetBonus()
        {
            return Salary * 0.2;
        }
    }
}
