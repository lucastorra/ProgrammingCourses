﻿using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class BonusManager
    {
        private double _totalBonificacao;

        public void Registrar(Employee funcionario)
        {
            _totalBonificacao += funcionario.GetBonificacao();
        }
        
        public double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }

    }
}