using System;

namespace LengthOfLastWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program program = new Program();
            program.LengthOfLastWord(null);
            Console.WriteLine(program.LengthOfLastWord("Today is a nice day"));
            Console.WriteLine(program.LengthOfLastWord(" "));
            Console.WriteLine(program.LengthOfLastWord("a"));
        }
        public int LengthOfLastWord(string s)
        {
            int result = 0;

            if (string.IsNullOrEmpty(s) || s.Length==0)
                return result;

            int count = s.Length-1;

            while (count >= 0)
            {
                if (s[count] == ' ')
                {
                    if (result > 0)
                        return result;
                }
                else
                {
                    result++;
                }
                count--;
            }

            return result;
        }
    }
}
