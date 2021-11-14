using System;

namespace LongestCommonPrefix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LongestCommonPrefix(new string[] { "dog", "racecar", "car" });
        }
        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs == null)
                return "";

            string result = "";

            for (int i = 0; i < strs[0].Length; i++)
            {
                foreach (string word in strs)
                {
                    if (i < word.Length)
                    {
                        if (word[i] != strs[0][i])
                        {
                            return result;
                        }
                    }
                    else
                        return result;
                }

                result += strs[0][i];
            }

            return result;
        }
    }
}
