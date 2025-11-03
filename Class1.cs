using System;
using System.Globalization;

namespace Course
{
    internal class BankAccount
    {
        public int AccountNumber { get; private set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }

        public BankAccount(int accountNumber, string holder)
        {
            AccountNumber = accountNumber;
            Holder = holder;
        }

        public BankAccount(int accountNumber, string holder, double initialDeposit)
            : this(accountNumber, holder)
        {
            Deposit(initialDeposit);
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            Balance -= amount + 5.00; // withdrawal fee
        }

        public override string ToString()
        {
            return $"Account {AccountNumber}, Holder: {Holder}, Balance: ${Balance.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
