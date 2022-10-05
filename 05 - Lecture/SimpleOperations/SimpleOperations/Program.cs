using System;

namespace SimpleOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            double inch = number * 2.54;

            Console.WriteLine(inch);
        }
    }
}
