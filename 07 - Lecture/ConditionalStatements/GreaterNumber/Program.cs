﻿using System;

namespace GreaterNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberA = int.Parse(Console.ReadLine());
            int numberB = int.Parse(Console.ReadLine());

            if (numberA >= numberB)
            {
                Console.WriteLine(numberA);
            }
            else
            {
                Console.WriteLine(numberB);
            }
        }
    }
}
