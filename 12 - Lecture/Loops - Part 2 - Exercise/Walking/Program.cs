using System;

namespace Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double totalSteps = 0;

            string input  = String.Empty;

            while ((input = Console.ReadLine()) != "Going home")
            { 
            double steps = double.Parse(input);

            totalSteps = totalSteps + steps;


                if (totalSteps >= 10000)
                {
                    Console.WriteLine($"Goal reached! Good job!");

                }
            }

            if (input == "Going home")
            {
                input = Console.ReadLine();
                double steps = double.Parse(input);
                totalSteps = totalSteps + steps;
                if (totalSteps > 10000)
                {
                    Console.WriteLine($"Goal reached! Good job!");
                }
                else
                {
                    Console.WriteLine($"{Math.Abs(10000 - totalSteps)} more steps to reach goal.");
                }

            }



        }
    }
}
