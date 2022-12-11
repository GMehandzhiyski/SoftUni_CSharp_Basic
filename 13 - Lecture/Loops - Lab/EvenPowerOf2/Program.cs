using System;

namespace Numbers1_NWhitStep3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int num = 1;

            for (int i = 0; i <= number; i += 2)
            {
                Console.WriteLine(num);
                num *= 4;
            }
        }
    }
}
