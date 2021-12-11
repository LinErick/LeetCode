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
            Console.WriteLine(program.LongestPalindrome("d123321abc"));
            Console.WriteLine(program.LongestPalindrome("aa"));
            Console.WriteLine(program.LongestPalindrome("b"));
            Console.WriteLine(program.LongestPalindrome("bc"));
            Console.WriteLine(program.LongestPalindrome("aacabdkacaa"));
            //b1234554321bbaaddd
        }
        public string LongestPalindrome(string s)
        {
            string result = s[0].ToString();

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = s.Length - 1; j > i; j--)
                {
                    int left = i;
                    int right = j;
                    while (s[left] == s[right])
                    {
                        if (left >= right)
                        {
                            if(result.Length < j - i + 1)
                            {
                                result = s.Substring(i, j - i + 1);
                                break;
                            }
                                

                        }
                        left++;
                        right--;
                    }
                }
            }

            return result;
        }
    }
}
