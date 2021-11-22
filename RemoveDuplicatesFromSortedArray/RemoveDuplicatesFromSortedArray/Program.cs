using System;
using System.Collections.Generic;

namespace RemoveDuplicatesFromSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");            
        }

        public static int RemoveDuplicates(int[] nums)
        {
            if (nums == null)
                return 0;

            if (nums.Length == 0)
                return 0;

            int result = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    nums[result] = nums[i - 1];
                    result++;
                }
            }

            nums[result] = nums[^1];
            result++;

            return result;
        }
    }
}
