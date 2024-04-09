namespace HKR3_Task2
{
    internal class Account
    {
        private double balance;

        public Account()
        {
            Balance = 0;
        }
        public Account(double amount)
        {
            Balance = amount;
        }

        public double Balance
        {
            get 
            { 
                return balance; 
            }
            set 
            {
                if (value >= 0)
                    balance = value;
                else
                    balance = 0;
            }
        }
        public double Deposit(double depositAmount)
        {
            Balance += depositAmount * 1.05;
            return Balance;
        }

        public double Withdraw(double withdrawAmount)
        {
            if (Balance >= withdrawAmount)
            {
                Balance -= withdrawAmount;
            }
            else
            {
                Console.WriteLine("Sorry, you don't have enough money in your account.");
            }
            return Balance;
        }
    }
}
