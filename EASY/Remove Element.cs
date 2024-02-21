using System;

namespace ProblemSolving_LeetCode
{
    internal class Program
    {
        public static int RemoveElement_Approach1(int[] nums, int val)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                while (left <= right && nums[left] != val)
                    left++;

                while (left <= right && nums[right] == val)
                    right--;

                if (left < right)
                {
                    int temp = nums[left];
                    nums[left] = nums[right];
                    nums[right] = temp;
                }
            }

            return left;
        }

        public static int RemoveElement_Approach2(int[] nums, int val)
        {
            int counter = 0;

            foreach(int num in nums)
            {
                if(num != val)
                {
                    nums[counter] = num;
                    counter++;
                }
            }

            return counter;
        }

        static void Main(string[] args)
        {
            int[] nums = { 0, 1, 2, 2, 3, 0, 4, 2 };           
            int val = 2;
           
            Console.WriteLine("Result = " + RemoveElement_Approach2(nums, val));

            Console.ReadKey();
        }
    }
}
