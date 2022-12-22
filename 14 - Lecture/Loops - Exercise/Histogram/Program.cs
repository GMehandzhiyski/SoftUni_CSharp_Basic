using System;

namespace Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numbers = int.Parse(Console.ReadLine());
            double num = 0;
            double p1 = 0;
            double p2 = 0;
            double p3 = 0; 
            double p4 = 0;
            double p5 = 0;
         


            for (int i = 1; i <= numbers; i++)
            {
                num = int.Parse(Console.ReadLine());
                if (num < 200)
                {
                    p1++;
                }
                else if (200 <= num && num <= 399)
                {
                    p2++;  
                }
                else if (400 <= num && num <= 599)
                {
                    p3++;
                }
                else if (600 <= num && num <= 799)
                {
                    p4++;
                }
                else if (800 <= num)
                { 
                    p5++;
                }

               if (i == numbers)
                {
                    Console.WriteLine($"{(p1 / numbers) * 100:F2}%");
                    Console.WriteLine($"{(p2 / numbers) * 100:f2}%");
                    Console.WriteLine($"{(p3 / numbers) * 100:f2}%");
                    Console.WriteLine($"{(p4 / numbers) * 100:f2}%");
                    Console.WriteLine($"{(p5 / numbers) * 100:f2}%");
                }
               


            }
        }
    }
}
