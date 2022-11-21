﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int secretNum = r.Next(1, 101);

            Console.WriteLine("Guess the secret number: ");
            bool foundNum = false;
            int userTriesRemaining = 4;

            while ((foundNum != true) && (userTriesRemaining != 0))
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

                    userTriesRemaining--;
                    Console.WriteLine("Nah that ain't it, you have " + $"{userTriesRemaining}" + " tries left");
                }

            }
        }
    }
}
