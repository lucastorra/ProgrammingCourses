using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Ceo : Employee
    {
        public Ceo(string cpf) : base(5000, cpf)
        {
            Console.WriteLine("Criando DIRETOR");
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
