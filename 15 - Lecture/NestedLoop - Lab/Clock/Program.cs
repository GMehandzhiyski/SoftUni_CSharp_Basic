using System;

namespace Clock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 24; i++)
            {
                for (int ii = 0; ii < 60; ii++)
                {
                    Console.WriteLine($"{i}:{ii}");
                }
            }
        }
    }
}
