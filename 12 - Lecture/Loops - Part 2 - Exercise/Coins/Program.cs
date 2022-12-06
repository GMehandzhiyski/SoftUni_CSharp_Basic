using System;

namespace Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal inputSum = decimal.Parse(Console.ReadLine());
            int sumOfCoins = 0;

            

            while (inputSum > 0)
            {
                 
                if (inputSum >= 2)
                {
                    sumOfCoins++;
                    inputSum -= 2;
                }
                else if (inputSum >= 1)
                {
                    sumOfCoins++;
                    inputSum -= 1;
                }
                else if (inputSum >= 0.50m)
                {
                    sumOfCoins++;
                    inputSum -= 0.50m;
                }
                else if (inputSum >= 0.20m)
                {
                    sumOfCoins++;
                    inputSum -= 0.20m;
                }
                else if (inputSum >= 0.10m)
                {
                    sumOfCoins++;
                    inputSum -= 0.10m;
                }
                else if (inputSum >= 0.05m)
                {
                    sumOfCoins++;
                    inputSum -= 0.05m;
                }
                else if (inputSum >= 0.02m)
                {
                    sumOfCoins++;
                    inputSum -= 0.02m;
                }
                else if (inputSum <= 0.01m)
                {
                    sumOfCoins++;
                    inputSum -= 0.01m;
                }
               
            }
            Console.WriteLine(sumOfCoins);
            
           


        }
    }
}
            
          