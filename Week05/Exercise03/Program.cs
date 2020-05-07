using System;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables declaration
            int n;
            int sum = 0;

            // read user input and convert it to int
            // this can produce Errors if user input cannot be converted
            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());

            // for-loop to make additions
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }

            // print result
            Console.WriteLine($"Sum of [1-{n}] is {sum}.");
        }
    }
}
