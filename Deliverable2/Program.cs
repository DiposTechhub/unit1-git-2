// See https://aka.ms/new-console-template for more information

using System;

class CoinFlipChallenge
{
    static void Main()
    {
        Console.WriteLine("Welcome our Esteem User!");
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();

        Console.Write("Do you want to participate in the coin flip challenge? (yes/no): ");
        string response = Console.ReadLine().ToLower();

        if (response != "yes")
        {
            Console.WriteLine($"{userName}, you are a coward!");
            return;
        }

        int totalCorrectGuesses = 0;
        Random random = new Random();

        for (int i = 0; i < 5; i++)
        {
            int coinFlip = random.Next(0, 2); // 0 for heads, 1 for tails
            Console.Write("Guess the coin flip (heads/tails): ");
            string userGuess = Console.ReadLine().ToLower();

            if ((coinFlip == 0 && userGuess == "heads") || (coinFlip == 1 && userGuess == "tails"))
            {
                totalCorrectGuesses++;
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Wrong guess!");
            }
        }

        Console.WriteLine($"Thank you for playing, {userName}! You got {totalCorrectGuesses} out of 5 correct.");
    }
}
