﻿using System;

namespace CharacterSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                char charAt = input[i];
                Console.WriteLine(charAt);  
            }

            
        }
    }
}
