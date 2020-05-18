using ByteBank.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Systems
{
    class InternalSystem
    {
        public bool SignIn(IAuthenticatable authenticatable, string password)
        {
            bool userAuthenticated = authenticatable.Authenticate(password);

            if (userAuthenticated)
            {
                Console.WriteLine("Welcome to System");
                return true;
            }
            else 
            {
                Console.WriteLine("Incorrect Password");
                return false; 
            }
            
        }
    }
}
