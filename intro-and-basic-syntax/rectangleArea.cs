using System;

namespace RectangleArea
{
    class Problem2_Rectangle_Area
    {
        static void Main(string[] args)
        {
            /* we take the input parameters from the console */
            double width  = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            
            /* the resulting area is calculated */
            double area = width * height;
            
            /* the result is formated to the second digit after the dot */
            Console.WriteLine($"{area:F2}");
        }
    }
}
