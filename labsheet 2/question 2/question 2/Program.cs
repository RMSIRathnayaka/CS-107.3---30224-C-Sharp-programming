using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_2
{
    class BankAccount
    {
        public int AccountNumber;
        public double Balance;

        public void Deposit(double amount)
        {
            Balance = Balance + amount;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an object
            BankAccount account = new BankAccount();

            Console.Write("Enter the account number: ");
            account.AccountNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter the deposite amount: ");
            double amount = double.Parse(Console.ReadLine());

            account.Deposit(amount);

            Console.WriteLine("Account number: " + account.AccountNumber);
            Console.WriteLine("Update Balance: $" + account.Balance);

            Console.ReadLine();
        }
    }

}
