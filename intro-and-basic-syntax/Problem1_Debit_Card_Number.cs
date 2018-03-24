//confirmed from victoriakaramanova
using System;
using System.Linq;
using System.Collections.Generic;

namespace homework
{
    class Problem1_Debit_Card_Number
    {
        static void Main(string[] args)
        {
            //A list for storage of the user entries is declared
            List<string> input = new List<string>();
            for (int i = 0; i < 4; i++)
            {
                //The user enters 4 times sequence of digits
                var text = Console.ReadLine();
                input.Add(text);
            }
            for (int i = 0; i < input.Count; i++)
            {
                while (input[i].Length < 4)
                {
                    /*each digit sequence is furnished with
                    leading zeros*/
                    input[i] = string.Concat("0", input[i]);
                }
            }
            foreach (var item in input)
            {
                //The result is printed on the console
                Console.Write(item + " ");
            }
        }
    }
}