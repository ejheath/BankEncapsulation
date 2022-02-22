using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            Console.WriteLine("How much do you want to deposit?");
            var deposit = double.Parse(Console.ReadLine());

            account.Deposit(deposit);

            Console.WriteLine($"Your balance is ${account.GetBalance()}");
        }
    }
}
