//CONFIRMED from victoriakaramanova
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
            //the user's entries will be assigned to a list
            List<int> input = new List<int>();
            while (count < 4)
            {
                input.Add(int.Parse(Console.ReadLine()));
                count++;
            }
            string health = new String('|', input[0]);
            //here the maxHealth is calculated as a difference
            //bw the second and the first entry, not standalone
            string maxHealth = new String('.', input[1] - input[0]);
            string energy = new String('|', input[2]);
            //again, the maxEnergy is calculated as a difference
            //bw the fourth and the third entry, not standalone
            string maxEnergy = new String('.', input[3] - input[2]);

            //The result is printed on the console
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Health: |{0}{1}|", health, maxHealth);
            Console.WriteLine("Health: |{0}{1}|", energy, maxEnergy);
        }
    }
}
