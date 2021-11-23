using System;

namespace ImplementStrsStr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            StrStr("mississippi", "issip");
            StrStr("hello", "ll");
            StrStr("aaa", "aaaa");
        }
        public static int StrStr(string haystack, string needle)
        {
            if (needle == string.Empty)
                return 0;

            int success = 0;

            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] == needle[success])
                {
                    success++;

                    if (needle.Length == success)
                        return i - success + 1;
                }
                else
                {
                    i -= success;
                    success = 0;
                }
            }

            return -1;
        }
    }
}
