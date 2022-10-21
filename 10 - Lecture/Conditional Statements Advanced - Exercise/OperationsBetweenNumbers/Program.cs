using System;
using System.Security.Cryptography;

namespace OperationsBetweenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            double number1 = int.Parse(Console.ReadLine());
            double number2 = int.Parse(Console.ReadLine());
            string operatorr = Console.ReadLine();

            //values
            double result = 0;
            double typeValue = 0;
            string typeNumber = "";
            int operation = 0;


            if (operatorr == "/")
            {
                if (number2 == 0)
                {
                    Console.WriteLine($"Cannot divide {number1} by zero");
                }
                else if (number2 != 0)
                {
                    result = number1 / number2;
                    operation = 2;
                }
            }
            else if (operatorr == "%")
            {
                if (number2 == 0)
                {
                    Console.WriteLine($"Cannot divide {number1} by zero");
                }
                else if (number2 != 0)
                {
                    result = number1 % number2;
                    operation = 3;
                }
            }
            else if (operatorr == "+")
            {
                result = number1 + number2;
                typeValue = number1 % number2;
                operation = 1;

                if (typeValue == 0)
                {
                    typeNumber = "odd";
                }
                else if (typeValue != 0)
                {
                    typeNumber = "even";
                }
            }
            else if (operatorr == "-")
            {
                result = number1 - number2;
                typeValue = number1 % number2;
                operation = 1;

                if (typeValue == 0)
                {
                    typeNumber = "odd";
                }
                else if (typeValue != 0)
                {
                    typeNumber = "even";
                }
            }
            else if (operatorr == "*")
            {
                result = number1 * number2;
                typeValue = number1 % number2;
                operation = 1;

                if (typeValue == 0)
                {
                    typeNumber = "even";
                }
                else if (typeValue != 0)
                {
                    typeNumber = "odd";
                }
            }



            //Output
            if (operation == 1)
            {
                Console.WriteLine($"{number1} {operatorr} {number2} = {result} - {typeNumber}");
            }
            else if (operation == 2)
            {
                Console.WriteLine($"{number1} / {number2} = {result:f2}");
            }
            else if (operation == 3)
            {
                Console.WriteLine($"{number1} % {number2} = {result}");
            }


        }
    }
}
