using System;
using System.Collections.Generic;

namespace RomanToInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int RomanToInt(string s)
        {
            int result = 0;
            string[] Romans = {"I", "V", "X", "L", "C", "D", "M"};
            string[] ExceptionString = { "IV","IX", "XL", "XC", "CD", "CM" };

            foreach (string exception in ExceptionString)
            {
                int Count = s.Split(exception).Length - 1;
                if (Count > 0)
                {
                    result += Count * GetRomanValue(exception.Substring(1, 1)) - GetRomanValue(exception.Substring(0, 1));
                    s = s.Replace(exception, string.Empty);
                }
            }
            
            foreach(string Symbol in Romans)
            {
                int Count = s.Split(Symbol).Length - 1;
                if (Count > 0)
                {
                    result += Count * GetRomanValue(Symbol);
                }
            }

            return result;
        }

        static int GetRomanValue(string data)
        {
            return data switch
            {
                "I" => 1,
                "V" => 5,
                "X" => 10,
                "L" => 50,
                "C" => 100,
                "D" => 500,
                "M" => 1000,
                _ => 0,
            };
        }
    }
    
}
