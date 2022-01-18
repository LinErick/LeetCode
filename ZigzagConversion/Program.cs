using System;
using System.Collections.Generic;
using System.Text;

namespace ZigzagConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program program = new();
            Console.WriteLine(program.Convert("PAYPALISHIRING", 3));
            Console.WriteLine(program.Convert("PAYPALISHIRING", 4));
        }

        public string Convert(string s, int numRows)
        {
            if (numRows == 1)
                return s;

            string result = "";

            List<char>[] data = new List<char>[numRows];

            for (int i = 0; i < numRows; i++)
            {
                data[i] = new List<char>();
            }

            int target = 0;
            bool isAdd = true;

            for (int index = 0; index < s.Length; index++)
            {
                data[target].Add(s[index]);
                if (isAdd)
                    target++;
                else
                    target--;

                if (target % (numRows-1) == 0)
                    isAdd = !isAdd;
            }

            for (int row=0; row< numRows; row++)
            {
                result += String.Join("", data[row].ToArray());
            }
            return result;
        }
    }
}
