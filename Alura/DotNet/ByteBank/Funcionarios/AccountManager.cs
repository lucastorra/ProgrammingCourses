using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class AccountManager : Employee
    {
        public AccountManager(string cpf) : base(4000, cpf)
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
