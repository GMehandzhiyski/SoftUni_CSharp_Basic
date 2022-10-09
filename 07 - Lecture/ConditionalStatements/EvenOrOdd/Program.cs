using System;

namespace EvenOrOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value = int.Parse(Console.ReadLine());
            int valueResult;
            valueResult = value % 2;


            if (valueResult ==  0)
            {
                Console.WriteLine("even");//result is 0
            }
            else
            {
                Console.WriteLine("odd");//result is 1
            }

        }
    }
}
