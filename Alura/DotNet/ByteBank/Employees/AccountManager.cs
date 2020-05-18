using ByteBank.Systems;

namespace ByteBank.Employees
{
    public class AccountManager : AuthenticableEmployee
    {
        public AccountManager(string personID) : base(4000, personID)
        {
        }

        public override void IncreaseSalary()
        {
            Salary *= 1.05;
        }

        public override double GetBonus()
        {
            return Salary * 0.25;
        }
                
    }
}
