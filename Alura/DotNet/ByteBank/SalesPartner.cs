﻿using ByteBank.Systems;
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

        public bool Authenticate(string password)
        {
            return Password == password;
        }
    }
}
