using ByteBank.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Employees
{
    public abstract class AuthenticableEmployee : Employee, Authenticatable
    {
        public string Password { get; set; }

        public AuthenticableEmployee(double salary, string personID) : base(salary, personID)
        {
        }

        public bool Authenticate(string password)
        {
            return Password == password;
        }
    }
}
