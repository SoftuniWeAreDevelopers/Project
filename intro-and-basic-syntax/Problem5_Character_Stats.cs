using System;
using System.Collections.Generic;

namespace Problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int count = 0;
            List<int> imput = new List<int>();
            while (count < 4)
            {
                imput.Add(int.Parse(Console.ReadLine()));
                count++;
            }
            string health = new String('|', imput[0]);
            string maxHealth = new String('.', imput[1] - imput[0]);
            string energy = new String('|', imput[2]);
            string maxEnergy = new String('.', imput[3] - imput[2]);

            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Health: |{0}{1}|", health, maxHealth);
            Console.WriteLine("Health: |{0}{1}|", energy, maxEnergy);
        }
    }
}
