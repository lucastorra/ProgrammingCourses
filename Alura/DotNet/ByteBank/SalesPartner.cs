using ByteBank.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class SalesPartner : IAuthenticatable
    {
        public string Password { get; set; }

        private AutenticationHelper _autenticationHelper = new AutenticationHelper();
        public bool Authenticate(string password)
        {
            return _autenticationHelper.ComparePassword(Password, password);
        }
    }
}
