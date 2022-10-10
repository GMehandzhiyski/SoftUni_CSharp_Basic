using System;

namespace SpeedInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double speed = double.Parse(Console.ReadLine());

            if (speed <= 10)
            {
                Console.WriteLine("slow");
            }
        }
    }
}
