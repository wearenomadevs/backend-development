using System;

namespace Exercise05
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
            Console.Write("How many numbers will you add? ");
            n = int.Parse(Console.ReadLine());

            // for-loop to read next number and make additions
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Enter next number: ");
                int next = int.Parse(Console.ReadLine());
                sum += next;
            }

            // this discards decimal points
            // int average = sum / n;
            // this transforms ints to doubles before dividing
            double average = (double)sum / (double)n;

            // print result
            Console.WriteLine($"The average of given numbers is {average}");
        }
    }
}
