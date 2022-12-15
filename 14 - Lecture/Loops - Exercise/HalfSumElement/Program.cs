using System;

namespace HalfSumElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 0;
            int sum = 0; 
            int max = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                num = int.Parse(Console.ReadLine());
                sum += num;

                if (num > max)
                {
                    max = num;
                }

            }
            int sumWitoutMaxNumber = sum - max;
            if (max == sumWitoutMaxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + max);
            }
            else
            {
                int diff = Math.Abs(max - sumWitoutMaxNumber);
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + diff);
            
            
            }

        }
    }
}
