using System;

namespace Traveling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double bugget = 0;
            string destination = string.Empty;
            double sumTotal = 0;

           while ((destination = Console.ReadLine()) != "End")
           {
              bugget = double.Parse(Console.ReadLine());

              while (bugget > sumTotal)
              {                     
               sumTotal += double.Parse(Console.ReadLine());
              }
              Console.WriteLine($"Going to {destination}!");
              sumTotal = 0;

           }

        }
    }
}

