using System;
namespace oopPractice
{
	public class BankAccount
	{
		//Fields go here

		private Guid accountNumber;

        private string accountHolder;

        private int accountBalance; // NEVER USE DOUBLE etc. FOR MONEY

        //Methods go here

        public int getAccountNumber() { return accountBalance; }

		public string getAccountHolder() { return accountHolder; }

		public int getAccountBalance() { return accountBalance; }

		public void deposit(int amount) {
			accountBalance += amount;
		}

		public bool withdraw(int amount) {
			if(accountBalance-amount >= 0)
			{
				accountBalance -= amount;
				return true;
			}
			else
			{
				return false; // Could not withdraw amount
			}
		}

        //Constructor
        public BankAccount(string accountHolder, int initialBalance)
		{

                this.accountNumber = Guid.NewGuid();
				this.accountHolder = accountHolder;
                this.accountBalance = initialBalance;

        }
    }
}

