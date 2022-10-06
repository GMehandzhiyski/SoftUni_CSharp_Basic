using System;
using System.Data;

namespace FishTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Length = double.Parse(Console.ReadLine());    
            double Width = double.Parse(Console.ReadLine());
            double Height = double.Parse(Console.ReadLine());
            double Percent = double.Parse(Console.ReadLine());
            double finalWater;
            double volume;

            volume = (Length * Width * Height) * 0.001;
            finalWater = volume * (1 - (Percent * 0.01));

            Console.WriteLine($"{finalWater:F3}");
        }
    }
}
