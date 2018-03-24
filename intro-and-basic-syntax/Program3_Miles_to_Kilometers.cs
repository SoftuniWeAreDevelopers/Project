//CONFIRMED from victoriakaramanova
using System;
using System.Linq;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //The user inputs the miles to convert to kilometers
            string entry = Console.ReadLine();
            //The result is printed
            Console.WriteLine("{0:f2}",(decimal.Parse(entry) * 1.60934m));
        }
    }
}
