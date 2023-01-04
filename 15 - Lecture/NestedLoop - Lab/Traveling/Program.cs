using System;

namespace Traveling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstWhile = 0;
            int bugget = 0;
            string destination = string.Empty;
            string country = string.Empty;
            int sumTotal = 0;        
           

            while (true)
            {
                while (firstWhile == 0)
                {
                    destination = Console.ReadLine();
                    if (destination == "End")
                    {
                        return;
                    }
                    bugget = int.Parse(Console.ReadLine());
                    firstWhile++;
                    country = destination;
                }
                int sum = int.Parse(Console.ReadLine());
                
                sumTotal += sum;
                if (bugget <= sumTotal)
                {
                        Console.WriteLine($"Going to {country}!");
                        destination = String.Empty;
                        sumTotal = 0;
                        firstWhile = 0;
                }
               

            }
           
        }
    }
}

