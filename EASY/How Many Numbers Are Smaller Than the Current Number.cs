using System;
using System.Collections.Generic;
using System.Linq;

namespace ProblemSolving_LeetCode
{
    internal class Program
    {
        public static int[] SmallerNumbersThanCurrent_Approach1(int[] nums)
        {
            return nums.Select((num, index) => nums.Where((x, ind) => x < num && index != ind).Count()).ToArray();
        }

        public static int[] SmallerNumbersThanCurrent_Approach2(int[] nums)
        {
            int[] counters = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                        counters[i]++;

                }
            }

            return counters;
        }

        public static int[] SmallerNumbersThanCurrent_Approach3(int[] nums)
        {
            int[] sortedNums = new int[nums.Length];

            for (int i = 0; i < sortedNums.Length; i++)
            {
                sortedNums[i] = nums[i];
            }

            Array.Sort(sortedNums);

            int[] counters = new int[nums.Length];

            for (int i = 0; i < sortedNums.Length; i++)
            {
                counters[i] = Array.IndexOf(sortedNums, nums[i]);
            }

            return counters;
        }

        static void Main(string[] args)
        {
            int[] nums = new int[] { 6, 5, 4, 8 };

            int[] results = SmallerNumbersThanCurrent_Approach3(nums);

            Console.WriteLine($"[{string.Join(",", results)}]");

            Console.ReadKey();
        }
    }
}
