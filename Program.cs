using System;
using System.Globalization;
using Course;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria account;

            Console.Write("Enter account number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Enter account holder: ");
            string holder = Console.ReadLine();

            Console.Write("Will there be an initial deposit (y/n)? ");
            char answer = char.Parse(Console.ReadLine());

            if (answer == 'y' || answer == 'Y')
            {
                Console.Write("Enter initial deposit value: ");
                double initialDeposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account = new ContaBancaria(number, holder, initialDeposit);
            }
            else
            {
                account = new ContaBancaria(number, holder);
            }

            Console.WriteLine();
            Console.WriteLine("Account data:");
            Console.WriteLine(account);

            Console.WriteLine();
            Console.Write("Enter a deposit amount: ");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            account.Deposito(amount);

            Console.WriteLine();
            Console.WriteLine("Updated account data:");
            Console.WriteLine(account);

            Console.WriteLine();
            Console.Write("Enter a withdraw amount: ");
            double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            account.Saque(withdraw);

            Console.WriteLine();
            Console.WriteLine("Final account data:");
            Console.WriteLine(account);
        }
    }
}
