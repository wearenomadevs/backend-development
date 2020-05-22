using System;

namespace Account_Example
{
    // Otan ftiaxnw ena account, xerw idi ton owner (den mporw na ftiaxw account xwris owner)
    // Otan ftiaxtei to account pairnei automata enan arithmo -> auxitikoi
    // An o proigoumenos logariasmos pou ftiaxtike itan o 4, o epomenos tha einai o 5.

    class Account
    {
        private static int NextNumber { get; set; }

        private decimal balance;
        
        public string Owner { get; private set; }
        public int Number { get; private set; }

        static Account()
        {
            NextNumber = 1;
        }

        private Account()
        {

        }

        public Account(string owner)
        {
            Owner = owner;
            Number = NextNumber;
            NextNumber += 1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account("John");
            Console.WriteLine($"Number: {a1.Number}, Owner: {a1.Owner}");

            Account a2 = new Account("Jim");
            Console.WriteLine($"Number: {a2.Number}, Owner: {a2.Owner}");

            Account a3 = new Account("George");
            Console.WriteLine($"Number: {a3.Number}, Owner: {a3.Owner}");
        }
    }
}
