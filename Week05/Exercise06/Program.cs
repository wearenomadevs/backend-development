using System;

namespace Exercise06
{
    class Program
    {
        static void Main(string[] args)
        {
            // constant declaration
            const int maximum_tries = 7;
            const string secret = "nomadevs";

            // variables declaration
            int tries = 0;

            while (tries < maximum_tries)
            {
                // New try
                tries += 1;
                // Get user's input
                Console.Write("Make a guess: ");
                string guess = Console.ReadLine();
                // Check if guess is correct or not
                if (guess != secret)
                {
                    Console.WriteLine($"Wrong guess! Tries remaining: {maximum_tries - tries}");
                }
                else
                {
                    Console.WriteLine($"That's correct! You win!");
                    break;
                }
            }
            // Check if we exited while-loop because we lost
            if (tries == maximum_tries)
            {
                Console.WriteLine("Sorry, you lost!");
            }
        }
    }
}
