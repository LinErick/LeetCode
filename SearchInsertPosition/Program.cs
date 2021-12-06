using System;

namespace SearchInsertPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();//引用stopwatch物件

            sw.Reset();//碼表歸零

            sw.Start();//碼表開始計時

            Console.WriteLine(SearchInsert(new int[] { 1 }, 5));
            Console.WriteLine(SearchInsert(new int[] { 1 }, 0));
            Console.WriteLine(SearchInsert(new int[] { 1, 3 }, 2));
            Console.WriteLine(SearchInsert(new int[] { 1, 3 }, 3));
            Console.WriteLine(SearchInsert(new int[] { 1, 3, 5, 7, 9, 11 }, 5));

            sw.Stop();//碼錶停止

            Console.WriteLine(sw.Elapsed.TotalMilliseconds.ToString());
        }
        public static int SearchInsert(int[] nums, int target)
        {
            /*Fastest Runtime*/
            //int i = 0;
            //while (i < nums.Length)
            //{

            //    if (nums[i] == target) return i;

            //    if (nums[i] > target) return i;

            //    else ++i;
            //}
            //return nums.Length;

            if (nums == null)
                return 0;

            int startrange = 0;
            int endrange = nums.Length - 1;

            if (target < nums[startrange])
                return startrange;
            if (target > nums[endrange])
                return endrange + 1;

            while (startrange != endrange && endrange - startrange != 1)
            {
                int middle = GetMiddle(startrange, endrange);

                if (target >= nums[middle])
                    startrange = middle;
                else 
                    endrange = middle;
            };

            return target > nums[startrange] ? endrange : startrange;
        }

        public static int GetMiddle(int startrange, int endrange)
        {
            int result = startrange - endrange;
            if (result <= 3)
                return startrange + 1;
            else
                return startrange + result / 2;
        }
    }
}
