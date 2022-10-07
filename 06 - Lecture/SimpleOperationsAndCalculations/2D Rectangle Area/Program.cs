using System;
using System.Reflection.Emit;

namespace _2D_Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double area1;
            double perimeter1;
            double length;
            double width;

            length = Math.Abs(x1 - x2);
            width = Math.Abs(y1 - y2);

            area1 = length * width;
            perimeter1 = 2 * (length + width);


            Console.WriteLine($"{area1:F2}");
            Console.WriteLine($"{ perimeter1:F2}");
        }
    }
}
