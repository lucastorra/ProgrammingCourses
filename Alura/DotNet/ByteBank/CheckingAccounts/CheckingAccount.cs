// using _05_ByteBank;

using System;

namespace ByteBank
{
    /// <summary>
    /// Define uma conta corrente do banco ByteBank.
    /// </summary>
    public class CheckingAccount
    {
        public AccountHolder AccountHolder { get; set; }

        public static int BankCharges { get; set; }

        public static int TotalAccounts { get; private set; }
        
        //Property ReadOnly, only constructor can increment.
        public int BranchNumber { get; }
        public int AccountNumber { get; }

        private double _balance = 100;

        public double Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _balance = value;
            }
        }

        /// <summary>
        /// Cria uma instância de Conta Corrente
        /// </summary>
        /// <param name="branchNumber"> Repreenta o valor da propriedade <see cref="BranchNumber"/> e deve possuir número maior que zero. </param>
        /// <param name="accountNumber"> Repreenta o valor da propriedade <see cref="accountNumber"/> e deve possuir número maior que zero.</param>
        public CheckingAccount(int branchNumber, int accountNumber)
        {
            if (branchNumber <= 0)
            {
                ArgumentException argumentException = new ArgumentException("The argument Branch must be greater than zero.", nameof(branchNumber));
                throw argumentException;
            }

            if(accountNumber <= 0)
            {
                ArgumentException argumentException = new ArgumentException("The argument Account must be greater than zero.", nameof(accountNumber));
                throw argumentException;
            }

            BranchNumber = branchNumber;
            AccountNumber = accountNumber;

            TotalAccounts++;

            BankCharges = 30 / TotalAccounts;
        }


        public bool WithDraw(double amount)
        {
            if (_balance < amount)
            {
                return false;
            }

            _balance -= amount;
            return true;
        }

        public void Deposit(double amount)
        {
            _balance += amount;
        }


        public bool Transfer(double amount, CheckingAccount targetAccount)
        {
            if (_balance < amount)
            {
                return false;
            }

            _balance -= amount;
            targetAccount.Deposit(amount);
            return true;
        }
    }
}
