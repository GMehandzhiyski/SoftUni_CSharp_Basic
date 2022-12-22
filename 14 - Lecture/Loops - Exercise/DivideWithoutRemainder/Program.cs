using System;
using System.Security.Cryptography;
using System.Transactions;

namespace DivideWithoutRemainder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
           

            for (int i = 1; i <= numbers; i++)
            {
                double num = double.Parse(Console.ReadLine());
               
                if (num % 2 == 0)
                {
                    p1++;
                }
                if (num % 3 == 0)
                {
                    p2++;
                }
                if (num % 4 == 0)
                { 
                    p3++;
                }
                if (i == numbers)
                {
                    Console.WriteLine($"{(p1 / numbers * 100):f2}%");
                    Console.WriteLine($"{(p2 / numbers * 100):f2}%");
                    Console.WriteLine($"{(p3 / numbers * 100):f2}%");
                }
            }

           
            
        }
    }
}
