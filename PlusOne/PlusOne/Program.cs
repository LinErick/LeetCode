using System;
using System.Collections.Generic;

namespace PlusOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program program = new Program();
            program.PlusOne(new int[] { 1, 2, 9 });
            program.PlusOne(new int[] { 9 });
            program.PlusOne(new int[] { 9, 9, 9, 9, 9 });
            program.PlusOne(new int[] { 8, 9, 9, 9, 9 });
        }

        public int[] PlusOne(int[] digits)
        {
            int target = digits.Length - 1;
            bool round = digits[target] == 9;
            digits[target] = digits[target] == 9 ? 0 : digits[target] + 1;

            while (round)
            {
                target--;
                if (target >= 0)
                {
                    round = digits[target] == 9;
                    digits[target] = digits[target] == 9 ? 0 : digits[target] + 1;
                }
                else
                {
                    int[] result = new int[digits.Length + 1];
                    result[0] = 1;
                    Array.Copy(digits, result, 0);
                    return result;
                }
            }

            return digits;
        }
    }
}
