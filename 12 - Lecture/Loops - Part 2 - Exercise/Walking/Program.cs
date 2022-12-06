using System;

namespace Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalSteps = 0;

            string input  = String.Empty;

            while ((input = Console.ReadLine()) != "Going home")
            { 
            int steps = int.Parse(input);

            totalSteps += steps;


                if (totalSteps >= 10000)
                {
                    Console.WriteLine($"Goal reached! Good job!");
                    break;

                }
            }

            if (input == "Going home")
            {
                input = Console.ReadLine();
                int steps = int.Parse(input);
                totalSteps += steps;

                if (totalSteps >= 10000)
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
