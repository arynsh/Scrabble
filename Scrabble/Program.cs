using System;
using System.Collections.Generic;
using Game.Models;

namespace Game
{
    public class ScrabbleGame
    {
        public static void Main()
        {
            Console.WriteLine("Please enter a word: ");
            string userInput = Console.ReadLine();
            Console.WriteLine(Score.ScoreCalculator(userInput));

        }
    }
}