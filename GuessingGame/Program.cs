using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a Number");

            string guessedNumber = Console.ReadLine();

            bool userGuessedCorrect = guessedNumber.Equals("7");

            if (userGuessedCorrect)
            {
                Console.WriteLine("You Won");
            }
            else
            {
                Console.WriteLine("You Lost");
            }



        
        }
    }
}
