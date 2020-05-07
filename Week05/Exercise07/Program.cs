using System;

namespace Exercise07
{
    class Program
    {
        static void Main(string[] args)
        {
            // constants declaration
            const int secret = 42;

            //variables declaration
            int tries = 0;

            do
            {
                // new try
                tries += 1;
                // Get user's input and convert it to int
                Console.Write("Guess the number: ");
                int guess = int.Parse(Console.ReadLine());
                // Check if our guess is bigger, smaller or equal to secret
                if (guess > secret)
                {
                    Console.WriteLine("Sorry, your guess is too big.");
                }
                else if (guess < secret)
                {
                    Console.WriteLine("Sorry, your guess is too small.");
                }
                // we found it!
                else
                {
                    Console.WriteLine($"Congrats! You guessed correctly after {tries} tries.");
                    break;
                }
            } while (true);
        }
    }
}
