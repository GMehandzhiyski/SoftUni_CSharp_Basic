using System;
using System.Data;

namespace BonusScore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double bonus = 0;
            double secBonus = 0;
            double firstBonus = 0;

            if (number <= 100)
            {

                firstBonus = number + 5;
                if ((number % 2) == 0)
                {
                    secBonus = firstBonus + 1;
                }
                else if (number % 10 == 5)
                {
                    secBonus = firstBonus + 2;
                }
                else 
                {
                    secBonus = firstBonus;
                }

            }
            else if (number > 100 && number <= 1000)
            {
                firstBonus = (number * 0.20) + number ;
                if ((number % 2) == 0)
                {
                    secBonus = firstBonus + 1;
                }
                if (number % 10 == 5)
                {
                    secBonus = firstBonus + 2;
                }
            }
            else
                firstBonus = (number * 0.10) + number;
                if ((number % 2) == 0)
                 {
                secBonus = firstBonus + 1;
                }
                if (number % 10 == 5)
                {
                secBonus = firstBonus + 2;
                }

            
            bonus = secBonus - number;
            
            Console.WriteLine($"{bonus}");
            Console.WriteLine($"{secBonus}");
        }
    }
}
