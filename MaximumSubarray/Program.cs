using System;

namespace MaximumSubarray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Program program = new Program();
            program.MaxSubArray(new int[] { 1 });
        }

        public int MaxSubArray(int[] nums)
        {
            if (nums == null)
                return 0;
            else if (nums.Length == 0)
                return 0;

            int count = nums[0];
            int result = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if (count < 0 && count < nums[i])
                {
                    count = nums[i];
                }
                else
                {
                    count += nums[i];
                }

                result = Math.Max(count, result);
            }

            return result;
        }
    }
}
