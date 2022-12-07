using System;

namespace SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantityNumbers = int.Parse(Console.ReadLine());
            int number = 0;
            int numberResult = 0;
            int forCounter = 0;


            for (int i = 0; i < quantityNumbers; i++)
            {
                number = int.Parse(Console.ReadLine());
                numberResult = numberResult + number;
                forCounter++;
            }

            if (forCounter == quantityNumbers)
            {
                Console.WriteLine(numberResult);
            }
        }
    }
}
