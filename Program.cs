﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {

            int secretNum = 42;

            Console.WriteLine("Guess the secret number: ");
            bool foundNum = false;
            int userTries = 0;

            while ((foundNum != true) && (userTries < 4))
            {
                string userGuess = Console.ReadLine();
                int parsedGuess = int.Parse(userGuess);
                if (parsedGuess == secretNum)
                {
                    Console.WriteLine("Yep, that's the number");
                    foundNum = true;

                }
                else
                {
                    Console.WriteLine("Nah that ain't it.");
                    userTries++;
                }

            }
        }
    }
}
