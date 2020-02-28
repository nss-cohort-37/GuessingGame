using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int secretNumber = rand.Next(1, 11);

            while (true)
            {
                Console.WriteLine("Guess a number between 1 and 10");
                string userGuess = Console.ReadLine();
                int userGuessInt = int.Parse(userGuess);

                if (userGuessInt == secretNumber)
                {
                    Console.WriteLine($"You guessed it! It was {secretNumber}");
                    break;
                }
                else
                {
                    Console.WriteLine("Nope that wasn't it");
                }
            }

        }
    }
}