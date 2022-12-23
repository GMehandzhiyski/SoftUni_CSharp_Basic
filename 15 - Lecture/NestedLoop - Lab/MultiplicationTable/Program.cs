
using System;

namespace MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int ii = 1; ii <= 10; ii++)
                {
                    Console.WriteLine($"{i} * {ii} = {i*ii}");
                }
            }
        }
    }
}
