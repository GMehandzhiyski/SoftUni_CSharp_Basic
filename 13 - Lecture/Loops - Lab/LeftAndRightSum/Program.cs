using System;

namespace LeftAndRightSum
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int quantityNumbers = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;
            int number = 0;

            for (int i = 0; i < quantityNumbers; i++)
            {
                number = int.Parse(Console.ReadLine());
                leftSum += number;
            }

            for (int i = 0; i < quantityNumbers; i++)
            {
                number = int.Parse(Console.ReadLine());
                rightSum += number;
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {rightSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightSum)}");
            }
        }
    }
}