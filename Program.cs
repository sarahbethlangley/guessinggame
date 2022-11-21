using System;
using System.Collections.Generic;
using System.Linq;

namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {

            int secretNum = 42;
            int guessAttempts = 0;


            while (guessAttempts < 4)
            {
                Console.WriteLine("Guess the secret number: ");
                string userGuess = Console.ReadLine();
                int parsedGuess = int.Parse(userGuess);
                if (parsedGuess == secretNum)
                {
                    Console.WriteLine("Yep, that's the number");

                }
                else
                {
                    Console.WriteLine("Nah that ain't it.");
                }


                Console.WriteLine(userGuess);

            }
        }
    }
}
