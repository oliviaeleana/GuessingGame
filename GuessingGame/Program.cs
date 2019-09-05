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
            bool userGuessedZero = guessedNumber.Equals("0");

            if (userGuessedCorrect)
            {
                Console.WriteLine("You Won");
            }
            else if (userGuessedZero)
            {
                Console.WriteLine("Please guess a number between 1-10 until you have won");

            }
            else
            {
                Console.WriteLine("You Lost");
            }



        
        }
    }
}
