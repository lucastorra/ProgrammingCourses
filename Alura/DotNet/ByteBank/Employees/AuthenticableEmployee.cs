using ByteBank.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Employees
{
    public abstract class AuthenticableEmployee : Employee, IAuthenticatable
    {
        public string Password { get; set; }

        private AutenticationHelper _autenticationHelper = new AutenticationHelper();

        public AuthenticableEmployee(double salary, string personID) : base(salary, personID)
        {
        }

        public bool Authenticate(string password)
        {
            return _autenticationHelper.ComparePassword(Password, password);
        }
    }
}
