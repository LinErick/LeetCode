using System;
using System.Collections.Generic;

namespace RemoveDuplicatesFromSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program program = new Program();
            program.RemoveDuplicates(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 });
            program.RemoveDuplicates(new int[] { 1, 1, 2 });
        }

        public int RemoveDuplicates(int[] nums)
        {
            if (nums == null)
                return 0;

            if (nums.Length == 0)
                return 0;

            int result = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[result] != nums[i])
                {
                    nums[++result] = nums[i];
                }
            }

            return result++;
        }
    }
}
