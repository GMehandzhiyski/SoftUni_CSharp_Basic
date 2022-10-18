using System;

namespace Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int colums = int.Parse(Console.ReadLine());
            double totalPrice = 0;

            if (type == "Premiere")
            {
                totalPrice = (rows * colums) * 12;
            }
            else if (type == "Normal")
            {
                totalPrice = (rows * colums) * 7.50;
            }
            else if (type == "Discount")
            {
                totalPrice = (rows * colums) * 5;
            }
            Console.WriteLine($"{totalPrice:f2} leva" );
        }
    }
}
