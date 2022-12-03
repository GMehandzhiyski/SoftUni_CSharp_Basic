using System;

namespace Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double inputSum = double.Parse(Console.ReadLine());
            double outputSum = 0;
            int twoLvCoins = 0;

            if (inputSum > 2)
            {
                inputSum = inputSum - 2;
                twoLvCoins++;
            }
            if (inputSum > 1)
            {
                inputSum = inputSum - 1;

            }


        }
    }
}
