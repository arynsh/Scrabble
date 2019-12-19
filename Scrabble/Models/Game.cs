using System;
using System.Collections.Generic;

namespace Game.Models
{
    public static class Score
    {
        static Dictionary<char, int> myDictionary = new Dictionary<char, int>() { {'A', 1}, {'B', 3}, {'C', 3}, {'D', 2}, {'E', 1}, {'F', 4}, {'G', 2}, {'H', 4}, {'I', 1}, {'J', 8}, {'K', 5}, {'L', 1}, {'M', 3}, {'N', 1}, {'O', 1}, {'P', 3}, {'Q', 10}, {'R', 1}, {'S', 1}, {'T', 1}, {'U', 1}, {'V', 4}, {'W', 4}, {'X', 8}, {'Y', 4}, {'Z', 10} };

        public static int ScoreCalculator(string userInput)
        {
            int count = 0;
            try
            {
                char[] arr = userInput.ToUpper().ToCharArray();
                foreach (char element in arr)
            {
                 count += myDictionary[element]; 
            }

            }
            catch (Exception ex)
            {
              Console.WriteLine("Message = {0}", ex.Message);  
              return -1;
            }
            return count;
        }
    }
}