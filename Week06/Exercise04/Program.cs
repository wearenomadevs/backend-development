using System;

namespace Exercise04
{
    class Account
    {
        // float, double, decimal
        private decimal balance;

        // extra information
        private string Id;
        
        public decimal GetBalance()
        {
            return balance;
        }

        public bool Deposit(decimal amount)
        {
            // Kapoia stigmi tha antikatastathei me Exception
            if (amount <= 0)
            {
                return false;
            }
            balance = balance + amount;
            return true;
        }

        public bool Withdraw(decimal amount)
        {
            if (amount > balance)
            {
                return false;
            }
            balance = balance - amount;
            return true;
        }

        public bool Transfer(Account other, decimal amount)
        {
            // Check for NullReference Exception
            if (other == null)
            {
                return false;
            }
            if (amount > balance)
            {
                return false;
            }
            balance = balance - amount;
            other.balance = other.balance + amount;
            return true;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Account c1 = new Account();
            Account c2 = new Account();

            Console.WriteLine($"c1 balance is {c1.GetBalance()}");
            c1.Deposit(150);
            Console.WriteLine($"c1 balance is {c1.GetBalance()}");

            if (c1.Deposit(-100))
            {
                Console.WriteLine("Deposit was successful!");
            }
            else
            {
                Console.WriteLine("Deposit was unsuccessful!");
            }

            c1.Withdraw(50);
            Console.WriteLine($"c1 balance is {c1.GetBalance()}");

            c1.Transfer(c2, 20);
            Console.WriteLine($"c1 balance is {c1.GetBalance()}");
            Console.WriteLine($"c2 balance is {c2.GetBalance()}");
        }
    }
}
