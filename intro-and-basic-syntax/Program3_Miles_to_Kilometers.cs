using System;
using System.Linq;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine("{0:f2}",(decimal.Parse(input) * 1.60934m));

        }
    }
}
