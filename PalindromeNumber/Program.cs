using System;
using System.Collections.Generic;

namespace PalindromeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(IsPalindrome(1410110141));
        }
        public static bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;

            List<int> data = IntToArray(x);

            for (int i = 0; i < data.Count / 2; i++)
            {
                if (data[i] != data[data.Count - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
        public static List<int> IntToArray(int parameter)
        {
            List<int> result = new();
            int getDigits = 10;
            while (parameter >= 1)
            {
                result.Add(parameter % getDigits);
                parameter /= getDigits;
            }

            return result;
        }
    }
}
