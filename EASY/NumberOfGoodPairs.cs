using System;
using System.Collections.Generic;

namespace ProblemSolving_LeetCode
{
    internal class Program
    {
        //Time Complexity = O(n) , Space Complexity = O(n)
        public static int NumIdenticalPairs_Approach1(int[] nums)
        {
            Dictionary<int, int> uniqueNumbers = new Dictionary<int, int>();
            int goodPairsCounter = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (uniqueNumbers.ContainsKey(nums[i]))
                {
                    uniqueNumbers[nums[i]]++;
                    continue;
                }

                uniqueNumbers.Add(nums[i], 1);
            }

            foreach (var num in uniqueNumbers)
            {
                goodPairsCounter += num.Value * (num.Value - 1) / 2;
            }

            return goodPairsCounter;
        }

        //Time Complexity = O(n) , Space Complexity = O(n)
        public static int NumIdenticalPairs_Approach2(int[] nums)
        {
            Dictionary<int, int> uniqueNumbers = new Dictionary<int, int>();
            int goodPairsCounter = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (uniqueNumbers.ContainsKey(nums[i]))
                {
                    goodPairsCounter += uniqueNumbers[nums[i]]++;
                    continue;
                }

                uniqueNumbers.Add(nums[i], 1);
            }
            return goodPairsCounter;
        }

        //Time Complexity = O(n^2) , Space Complexity = O(n)
        public static int NumIdenticalPairs_Approach3(int[] nums)
        {
            public static int NumIdenticalPairs_Approach3(int[] nums)
            {
                int goodPairsCounter = 0;

                for (int i = 0; i < nums.Length - 1; i++)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[i] == nums[j])
                            goodPairsCounter++;
                    }
                }
                return goodPairsCounter;
            }
        }

        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 1, 1, 2, 3, 3 };

            Console.WriteLine(NumIdenticalPairs_Approach2(nums));

            Console.ReadKey();
        }
    }
}
