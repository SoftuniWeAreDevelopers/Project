using System;
using System.Linq;
using System.Collections.Generic;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = new List<string>();
            for (int i = 0; i < 4; i++)
            {
                var hello = Console.ReadLine();
                input.Add(hello);
            }
            for (int i = 0; i < input.Count; i++)
            {
                while (input[i].Length < 4)
                {
                    input[i] = string.Concat("0", input[i]);
                }
            }
            foreach (var item in input)
            {
                Console.Write(item + " ");
            }
        }
    }
}
