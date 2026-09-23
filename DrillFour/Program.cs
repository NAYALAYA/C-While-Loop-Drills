using System;

class Program
{
    static void Main()
    {
        int secret = 7;
        int attemptsLeft = 3;
        bool guessedCorrectly = false;

        Console.Write("Guess the secret number: ");

        // TODO: Set up a while loop that runs while attemptsLeft > 0 AND guessedCorrectly is false
        // 1. Prompt user for guess
        // 2. If correct, set guessedCorrectly to true
        // 3. If wrong, decrement attemptsLeft and print remaining attempts

        while (attemptsLeft > 0 && guessedCorrectly = false)
        {
            Console.Write("Guess the secret number: ");
            attemptsLeft --;
        }

        if (guessedCorrectly = true)
            Console.WriteLine("You Win!");
        else
            Console.WriteLine("Out of attempts! You lose.");
    }
}