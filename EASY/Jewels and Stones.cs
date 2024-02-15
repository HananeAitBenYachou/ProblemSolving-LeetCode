using System;
using System.Collections.Generic;
using System.Linq;

namespace ProblemSolving_LeetCode
{
    internal class Program
    {
        public static int NumJewelsInStones_Approach1(string jewels, string stones)
        {
            int counter = 0;

            foreach (char stone in stones)
            {
                if (jewels.Contains(stones))
                    counter++;
            }

            return counter;
        }

        public static int NumJewelsInStones_Approach2(string jewels, string stones)
        {
            return stones.Where(c => jewels.Contains(c)).Count();
        }

        public static int NumJewelsInStones_Approach3(string jewels, string stones)
        {
            Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();
            int counter = 0;

            foreach (char stone in stones)
            {
                if (keyValuePairs.ContainsKey(stone))
                    keyValuePairs[stone]++;

                else
                    keyValuePairs.Add(stone, 1);
            }

            foreach (var pair in keyValuePairs)
            {
                if (jewels.Contains(pair.Key))
                {
                    counter += pair.Value;
                }
            }

            return counter;
        }


        static void Main(string[] args)
        {
            string jewels = "aA", stones = "aAAbbbb";

            Console.Write(NumJewelsInStones_Approach2(jewels, stones));

            Console.ReadKey();
        }
    }
}
