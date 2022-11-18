using System;
using System.Collections.Generic;
using System.Linq;

namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Guess the secret number: ");
            string userGuess = Console.ReadLine();
            int parsedGuess = int.Parse(userGuess);
            Console.WriteLine(userGuess);

        }
    }
}
