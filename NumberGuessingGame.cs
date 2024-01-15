using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isCorrectGuess = false;
            Random random = new Random();

            int randomNumber = random.Next(1, 101);

            Console.WriteLine("Welcome to the guess game!");
            Console.WriteLine("Guess a number between 1 - 100.");
            Console.WriteLine("If you guess the correct number, you win!");


            while (!isCorrectGuess)
            {
                Console.WriteLine("Please enter your guess: ");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess > 100)
                {
                    Console.WriteLine("Please enter a number between 1 - 100");
                }
                else if (guess < randomNumber)
                {
                    Console.WriteLine("Your guess is too low");
                }
                else if (guess > randomNumber)
                {
                    Console.WriteLine("Your guess is to high");
                }
                else
                {
                    Console.WriteLine("Your guess is correct!");
                    isCorrectGuess = true;
                }
            }

            Console.WriteLine("Congrats! You won!");

        }
    }
}
