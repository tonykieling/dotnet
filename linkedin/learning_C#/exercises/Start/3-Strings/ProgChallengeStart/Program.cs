using System;

namespace ProgChallengeStart
{
    class Program
    {
        static void Main(string[] args)
        {
            // Choose a random number between 0 and 20
            int theNumber = new Random().Next(20);

            // Print the game greeting and instructions
            Console.WriteLine("Let's Play 'Guess the Number'!");
            Console.WriteLine("I'm thinking of a number between 0 and 20.");
            Console.WriteLine("Enter your guess, or -1 to give up.");

            int newNumber;
            int guesses = 0;

            while (1 == 1) {
                Console.WriteLine("\nWhat's your guess?" + theNumber);
                string n = Console.ReadLine();
                bool convertion = int.TryParse(n, out newNumber);

                if (convertion) {
                    guesses++;
                    if (newNumber == theNumber) {
                        Console.WriteLine($"   ---   You got in {guesses} guesses!   \\o/   ---\n\n");
                        break;
                    } else if ( newNumber == -1) {
                        Console.WriteLine($"Alright, see ya. BTW, the guess number was {theNumber}.\n\n");
                        break;
                    } else {
                        Console.WriteLine($"  => Nope, {((newNumber > theNumber) ? "lower" : "higher")} than that.");
                        // continue;
                    }
                } else {
                    Console.WriteLine("  XXX => Nah, it does not look like a number. Try it again!");
                }
            }

    // Console.WriteLine("{0}", guesses > 3 ? "more than 3" : "nevermind");
            
        }
    }
}
