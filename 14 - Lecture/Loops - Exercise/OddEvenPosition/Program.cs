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

                if (i % 2 == 0)//Even
                {
                   sumEven += number;
                    if (number > maxEven)//MAX
                    {
                        maxEven = number;
                    }
                    if (number < minEven)//MIN
                    { 
                        minEven = number;
                    }

                    //Console.WriteLine(i);
                }
                else //Odd
                {
                    sumOdd += number;
                    if (number > maxOdd)//MAX
                    {
                        maxOdd = number;
                    }
                    if (number < minOdd)//MIN
                    {
                        minOdd = number;
                    }
                }
            }

            Console.WriteLine($"OddSum={sumOdd:f2},");
            if (n == 0 )
            {
                Console.WriteLine($"OddMin=No,");
                Console.WriteLine($"OddMax=No,");
            }
            else 
            {
                Console.WriteLine($"OddMin={minOdd:f2},");
                Console.WriteLine($"OddMax={maxOdd:f2},");
            }

            Console.WriteLine($"EvenSum={sumEven:f2},");
            if (n == 0 || n == 1)
            {
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No");
            }
            else 
            {
                Console.WriteLine($"EvenMin={minEven:f2},");
                Console.WriteLine($"EvenMax={maxEven:f2}");
            }
            
        }
            
    }
}
