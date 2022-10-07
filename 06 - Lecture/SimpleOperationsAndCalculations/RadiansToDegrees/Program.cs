using System;

namespace RadiansToDegrees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double rad = double.Parse(Console.ReadLine());
            double deg;
            deg = (rad * 180) / Math.PI;

            Console.WriteLine(Math.Round(deg));
        }
    }
}
