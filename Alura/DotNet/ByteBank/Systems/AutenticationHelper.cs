using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Systems
{
    internal class AutenticationHelper
    {
        public bool ComparePassword(string password, string trialPassword)
        {
            return password == trialPassword;
        }
    }
}
