using System;

namespace Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double inputSum = double.Parse(Console.ReadLine());
            double outputSum = 0;
            double twoLvCoins = 0;
            double oneLvCoins = 0;
           double coins050 = 0;
            double coins020 = 0;
            double coins010 = 0;
            double coins005 = 0;
            double coins002 = 0;
            double coins001 = 0;

            while (inputSum >= outputSum)
            {
                if (inputSum >= 2)
                {
                    inputSum = inputSum - 2;
                    twoLvCoins++;
                }
                
                if (inputSum >= 1 && inputSum < 2)
                {
                    inputSum = inputSum - 1;
                    oneLvCoins++;
                }
                outputSum = twoLvCoins + oneLvCoins;
                
                if (inputSum >= 0.50 && inputSum < 1 )
                {
                    inputSum = inputSum - 0.50;
                    coins050++;
                }
                if (inputSum >= 0.20 && inputSum < 0.5)
                {
                    inputSum = inputSum - 0.20;
                    coins020++;
                }
                if (inputSum >= 0.10 && inputSum < 0.20)
                {
                    inputSum = inputSum - 0.10;
                    coins010++;
                }
                if (inputSum >= 0.05 && inputSum < 0.10)
                {
                    inputSum = inputSum - 0.05;
                    coins005++;
                }
                if (inputSum >= 0.02 && inputSum < 0.05)
                {
                    inputSum = inputSum - 0.02;
                    coins002++;
                }
                if (inputSum >= 0.01 && inputSum < 0.02)
                {
                    inputSum = inputSum - 0.01;
                    coins001++;
                }
               
               
              
            }
            Console.WriteLine(outputSum);
            
           


        }
    }
}
