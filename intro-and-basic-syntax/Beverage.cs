using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xcrs4
{
    class Program
    {
        static void Main(string[] args)
        {
            var prdName = Console.ReadLine();
            var vol = int.Parse(Console.ReadLine());
            var energy = int.Parse(Console.ReadLine());
            var sugar = int.Parse(Console.ReadLine());
            float s1 = vol * energy / (float)100;
            float s2 = vol * sugar / (float)100;
            Console.WriteLine("{0}ml {1}:", vol, prdName);
            Console.WriteLine("{0}kcal, {1}g sugars", s1, s2);
        }
    }
}
