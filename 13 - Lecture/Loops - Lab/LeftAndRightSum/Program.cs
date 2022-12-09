using System;

namespace LeftAndRightSum
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int quantityNumbers = int.Parse(Console.ReadLine());
            int number = 0;
            int cyclesfor = 0;

            for (int i = 0; i < (quantityNumbers*2); i++)
            {
                number = int.Parse(Console.ReadLine());


                cyclesfor++;
            }
        }
    }
}