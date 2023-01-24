using System;
using System.Linq;

class Hangman
{
    static void Main(string[] args)
    {
        string word = "summer";
        char[] guessed = new char[word.Length];

        for (int i = 0; i < guessed.Length; i++)
        {
            guessed[i] = '_';
        }

        int attempts = 0;
        while (attempts < 6)
        {
            Console.WriteLine("Guess a letter:");
            char input = Console.ReadLine()[0];

            if (word.Contains(input))
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] == input)
                    {
                        guessed[i] = input;
                    }
                }
            }
            else
            {
                attempts++;
                Console.WriteLine("Incorrect. You have " + (6 - attempts) + " attempts left.");
            }

            if (!guessed.Contains('_'))
            {
                Console.WriteLine("You win! The word was " + word);
                return;
            }
        }

        Console.WriteLine("You lose. The word was " + word);
    }
}
