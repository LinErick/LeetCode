using System;
using System.Collections.Generic;

namespace Longest_Palindromic_Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Program program = new();
            //Console.WriteLine(program.LongestPalindrome("d123321abc"));
            //Console.WriteLine(program.LongestPalindrome("aa"));
            //Console.WriteLine(program.LongestPalindrome("b"));
            //Console.WriteLine(program.LongestPalindrome("bc"));
            //Console.WriteLine(program.LongestPalindrome("aacabdkacaa"));
            Console.WriteLine(program.LongestPalindrome("bacabab"));
            //b1234554321bbaaddd
        }
        public string LongestPalindrome(string s)
        {
            int resultStart = 0, resultLength = 1;

            for (int leftStart = 0; leftStart < s.Length; leftStart++)
            {
                for (int rightEnd = s.Length - 1; leftStart < rightEnd; rightEnd--)
                {
                    int left = leftStart;
                    int right = rightEnd;
                    int stringLength = right - left + 1;

                    if (resultLength >= stringLength)
                    {
                        break;
                    }

                    while (s[left] == s[right])
                    {
                        if (left >= right)
                        {
                            resultStart = leftStart;
                            resultLength = stringLength;
                            break;
                        }
                        left++;
                        right--;
                    }
                }
            }

            return s.Substring(resultStart, resultLength);
        }
    }
}
