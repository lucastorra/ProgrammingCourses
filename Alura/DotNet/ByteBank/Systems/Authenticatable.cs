using ByteBank.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Systems
{
    public abstract class Authenticatable : Employee
    {
        public string Password { get; set; }

        public Authenticatable(double salary, string personID) : base(salary, personID)
        {
        }

        public bool Authenticate(string password)
        {
            return Password == password;
        }
    }
}
