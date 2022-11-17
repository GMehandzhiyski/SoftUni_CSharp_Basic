using System;

namespace AccountBalance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int transactionNumber = int.Parse(Console.ReadLine());
            double moneySum;
            int whileCout = 0;
            double totalSum = 0;

            if (transactionNumber > 0)
            {
                while (whileCout < transactionNumber)
                {
                    moneySum = int.Parse(Console.ReadLine());
                    /*
                    Console.WriteLine($"Increase:{moneySum}");
                    */
                    totalSum = totalSum + moneySum;
                    
                    whileCout = whileCout + 1;
                }

                if (whileCout >= transactionNumber)
                {
                    Console.WriteLine($"Total:{totalSum}");
                }
            }
            else
            {
                Console.WriteLine("Invalid operation!");
            }

        }
    }
}
