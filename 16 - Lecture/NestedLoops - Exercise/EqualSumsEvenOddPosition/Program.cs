﻿using System;
using System.Numerics;

namespace EqualSumsEvenOddPosition
{
    internal class Program
    {
        static void Main(string[] args)
        {
                int firstNumber = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());
          

                for (int i = firstNumber; i <= secondNumber; i++)
                {
                    string currentNum = i.ToString();
                    int oddSum = 0;
                    int evenSum = 0;

                    for (int j = 0; j < currentNum.Length; j++)
                    {
                        int currentDigit = int.Parse(currentNum[j].ToString());

                        if (j % 2 == 0) // nechetno
                        {
                            evenSum += currentDigit;
                        }
                        else // chetno
                        {
                            oddSum += currentDigit;
                        }
                    }
                    if (oddSum == evenSum)
                    {
                        Console.Write(i + " ");
                    }
                   


                }
        }
    }
}
