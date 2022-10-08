using System;

namespace DanceHall
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double aWidth = double.Parse(Console.ReadLine());

            double wardrobeArea = ((aWidth * 100) * (aWidth * 100));
            double benchArea = (((length * 100) * (width * 100)) / 10);
            double dancerArea = 7040;

            double freeArea = ((length * 100) * (width * 100)) - (wardrobeArea + benchArea);
            double dancers = freeArea / dancerArea;

            Console.WriteLine(Math.Floor(dancers));




        }
    }
}
