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
                    moneySum = double.Parse(Console.ReadLine());
                    if (moneySum < 0)
                    {
                        Console.WriteLine("Invalid operation!");
                        Console.WriteLine($"Total: {totalSum:f2}");
                        break;
                    }
                    totalSum = totalSum + moneySum;
                    Console.WriteLine($"Increase: {moneySum:f2}");
                    whileCout = whileCout + 1;
                   
                }

                
                

                if (whileCout >= transactionNumber)
                {
                    Console.WriteLine($"Total: {totalSum:f2}");
                }
            }
            else
            {
                Console.WriteLine("Invalid operation!");
            }
            
                   
                    
        }
    }
}
