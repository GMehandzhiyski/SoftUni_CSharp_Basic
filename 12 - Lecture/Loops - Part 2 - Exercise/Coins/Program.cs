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

            while (inputSum > 0)
            {
                if (inputSum >= 2)
                {
                    inputSum = inputSum - 2;
                    if (inputSum < 0.01)
                    {
                        inputSum = 0;
                    }
                    twoLvCoins++;
                }
                
                if (inputSum >= 1 && inputSum < 2)
                {
                    inputSum = inputSum - 1;
                    if (inputSum < 0.01)
                    {
                        inputSum = 0;
                    }
                    oneLvCoins++;
                }
                
                if (inputSum >= 0.50 && inputSum < 1 )
                {
                    inputSum = inputSum - 0.50;
                    if (inputSum < 0.01)
                    {
                        inputSum = 0;
                    }
                    coins050++;
                }
                if (inputSum >= 0.20 && inputSum < 0.5)
                {
                    inputSum = inputSum - 0.20;
                    if (inputSum < 0.01)
                    {
                        inputSum = 0;
                    }
                    coins020++;
                }
                if (inputSum >= 0.10 && inputSum < 0.20)
                {
                    inputSum = inputSum - 0.10;
                    if (inputSum < 0.01)
                    {
                        inputSum = 0;
                    }
                    coins010++;
                }
                if (inputSum >= 0.05 && inputSum < 0.10)
                {
                    inputSum = inputSum - 0.05;
                    if (inputSum < 0.01)
                    {
                        inputSum = 0;
                    }
                    coins005++;
                }
                if (inputSum >= 0.02 && inputSum < 0.05)
                {
                    inputSum = inputSum - 0.02;
                    if (inputSum < 0.01)
                    {
                        inputSum = 0;
                    }
                    coins002++;
                }
                if (inputSum >= 0.01 && inputSum < 0.02)
                {
                    inputSum = inputSum - 0.01;
                    if (inputSum < 0.01)
                    {
                        inputSum = 0;
                    }
                    coins001++;
                }

                outputSum = twoLvCoins + oneLvCoins + coins050 + coins020 + coins010 + coins005 + coins002 + coins001 ;


            }
            Console.WriteLine(outputSum);
            
           


        }
    }
}
