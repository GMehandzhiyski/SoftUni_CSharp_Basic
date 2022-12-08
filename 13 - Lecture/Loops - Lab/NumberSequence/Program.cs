using System;

namespace NumberSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberMax = Int32.MaxValue;
            int numberMin = Int32.MinValue;
            int quantityNumbers = int.Parse(Console.ReadLine());
            int number = 0;
            int cyclesfor = 0;

            for (int i = 0; i < quantityNumbers; i++)
            {
                number = int.Parse(Console.ReadLine());
                
                if (numberMin < number)
                {
                    numberMin = number;
                }
                if (numberMax > number)
                { 
                    numberMax = number;
                }

                cyclesfor++;
            }

            if (quantityNumbers == cyclesfor)
            {
                Console.WriteLine($"Max number: {numberMin}");
                Console.WriteLine($"Min number: {numberMax}");
            }
           
        }
    }
}
