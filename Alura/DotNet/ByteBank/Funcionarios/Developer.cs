using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Developer : Employee
    {
        public Developer(string cpf) : base(3000, cpf)
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
