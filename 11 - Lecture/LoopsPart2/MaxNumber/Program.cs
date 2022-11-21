using System;

namespace MaxNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value = Int32.MinValue;
            int number = int.Parse(Console.ReadLine());
            int cycles = 0;
            int valueAdd = 0;


            while ( number > cycles)
            {
                valueAdd = int.Parse(Console.ReadLine());

                if (value < valueAdd)
                { 
                value = valueAdd;
                }

                cycles++;
            }

            if (number == cycles)
            {
                Console.WriteLine(value);
            }
        }
    }
}
