using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MetricConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double inputValue = double.Parse(Console.ReadLine());
            string Input = Console.ReadLine();
            string Output = Console.ReadLine();
            double outputValue;


            if (Input == "mm")
            {
                if (Output == "m")
                {
                    outputValue = inputValue / 1000;
                }
                else // cm
                {
                    outputValue = inputValue / 10;
                }

            }
            else if (Input == "m")
            {
                if(Output == "mm")
                {
                    outputValue = inputValue * 1000;
                }
                else //cm
                {
                    outputValue = inputValue * 100;
                }
            }
            else  // cm
            {
                if (Output == "m")
                {
                    outputValue = inputValue / 100;
                }
                else // mm
                {
                    outputValue = inputValue * 10;
                }
            }

            Console.WriteLine($"{outputValue:F3}");


        }
    }
}
