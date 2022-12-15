using System;

namespace OddEvenPosition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sumEven = 0;
            double sumOdd = 0;
            double minEven = double.MaxValue;
            double maxEven = double.MinValue;
            double minOdd = double.MaxValue;
            double maxOdd = double.MinValue;



            for (int i = 1;  i <= n; i++)
            {
                double number = double.Parse(Console.ReadLine());

                if (number % 2 == 0)//Even
                {
                   sumEven += number;
                    if (number > maxEven) 
                    {
                        maxEven = number;
                    }
                    if (number < minEven)
                    { 
                        minEven = number;
                    }

                    //Console.WriteLine(i);
                }
                else 
                {
                    sumOdd += number;
                    if (number > maxOdd)
                    {
                        maxOdd = number;
                    }
                    if (number < minOdd)
                    {
                        minOdd = number;
                    }
                }
            }
            Console.WriteLine($"OddSum={sumOdd:f2}");
            Console.WriteLine($"OddMin={minOdd:f2}");
            Console.WriteLine($"OddMax={maxOdd:f2}");

            Console.WriteLine($"EvenSum={sumEven:f2}");
            Console.WriteLine($"EvenMin={minEven:f2}");
            Console.WriteLine($"EvenMax={maxEven:f2}");
        }
    }
}
