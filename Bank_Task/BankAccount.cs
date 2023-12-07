using System;
namespace Bank_Task
{
	public class BankAccount : IBanking
	{
        
		public BankAccount(decimal balance)
		{
            this.Balance = balance;
		}

        public decimal Balance { get; set; }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public decimal GetBalance()
         => Balance;

        public void Wndraw(decimal amount)
        {
            if (amount > Balance)
            {
                throw new OperationCanceledException("You dont have enough balance in the bank account");
            }

            else
            {
                Balance -= amount;
            }
        }
    }
}

