using System;

namespace LongestSubstringWithoutRepeatingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LengthOfLongestSubstring("aabaab!bb");
        }

        public static int LengthOfLongestSubstring(string s)
        {
            //if (s == null || s == String.Empty)
            //    return 0;

            //HashSet<char> set = new HashSet<char>();
            //int currentMax = 0,
            //    i = 0,
            //    j = 0;

            //while (j < s.Length)
            //    if (!set.Contains(s[j]))
            //    {
            //        set.Add(s[j++]);
            //        currentMax = Math.Max(currentMax, j - i);
            //    }
            //    else
            //        set.Remove(s[i++]);

            //return currentMax;
            string result1 = "";
            string result2 = "";

            foreach(char data in s)
            {
                int Index = result1.IndexOf(data);
                if (Index == -1)
                    result1 += data;
                else
                {
                    if (result1.Length > result2.Length)
                        result2 = result1;

                    if (Index == result1.Length - 1)
                        result1 = data.ToString();
                    else
                        result1 = result1.Substring(Index + 1, result1.Length - Index - 1) + data.ToString();
                }
            }

            return result1.Length > result2.Length? result1.Length: result2.Length;
        }
    }
}
