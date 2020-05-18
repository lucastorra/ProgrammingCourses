// using _05_ByteBank;

using System;

namespace ByteBank
{
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
