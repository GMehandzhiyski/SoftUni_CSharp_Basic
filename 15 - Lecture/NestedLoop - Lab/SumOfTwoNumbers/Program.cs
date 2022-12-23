using System;

namespace SumOfTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int combinationCounter = 0;

            for (int i = firstNumber; i <= secondNumber; i++)
            {


                for (int j = firstNumber; j <= secondNumber; j++)
                {
                     combinationCounter ++;

                    if (i + j == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{combinationCounter} ({i} + {j} = {i+j})");
                        return;
                    }

                }
            }
            Console.WriteLine($"{combinationCounter} combinations - neither equals {magicNumber}");
        }
    }
}
