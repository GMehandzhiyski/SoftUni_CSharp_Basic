using System;
using System.Data;
using System.Drawing;

namespace AreaOfFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double area;



            if (figure == "square")
            {
                double a = double.Parse(Console.ReadLine());
                area = a * a;
            }
            else if (figure == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                area = a * b;
            }
            else if (figure == "circle")
            {
                double a = double.Parse(Console.ReadLine());
                area = Math.PI * (a * a);
            }
            else
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                area = (a * b) / 2;

            }


            Console.WriteLine($"{area:F3}");
        }
    }
}
