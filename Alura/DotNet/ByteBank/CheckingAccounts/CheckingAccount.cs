// using _05_ByteBank;

namespace ByteBank
{
    public class CheckingAccount
    {
        public AccountHolder AccountHolder { get; set; }

        public static int TotalAccounts { get; private set; }


        private int _branchNumber;
        public int BranchNumber
        {
            get
            {
                return _branchNumber;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }

                
                _branchNumber = value;
            }
        }
        public int AccountNumber { get; set; }

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
            BranchNumber = branchNumber;
            AccountNumber = accountNumber;

            TotalAccounts++;
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
