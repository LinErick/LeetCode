using System;

namespace ValidParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static bool IsValid(string s)
        {
            bool result = true;

            for (int i = 0, j = 1; i < s.Length;)
            {
                string data = s[i].ToString() + s[j].ToString();

                if ("(),{},[]".IndexOf(data) > -1)
                {
                    if()
                }
            }

            return result;
        }
    }
}
