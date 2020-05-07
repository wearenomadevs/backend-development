using System;

namespace Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables declaration
            int n;
            int factorial = 1;

            // read user input and convert it to int
            // this can produce Errors if user input cannot be converted
            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());

            // for-loop to make multiplications
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            // print result
            Console.WriteLine($"Factorial of {n} is {factorial}.");
        }
    }
}
