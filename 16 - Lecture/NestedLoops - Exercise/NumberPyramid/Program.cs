using System;

namespace NumberPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int secondFor = 0;

            for (int rows = 1; rows <= number; rows++)
            {
                for (int cols = 1; cols <= rows; cols++)
                {
                    secondFor++;   
                    Console.Write(secondFor + " ");
                    if (secondFor >= number)
                    { 
                     break;
                    }
                }
                Console.WriteLine();
                if (secondFor >= number)
                {
                    break;
                }
            }
        }
    }
}
