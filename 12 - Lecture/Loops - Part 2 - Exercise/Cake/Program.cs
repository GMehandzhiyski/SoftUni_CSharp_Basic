using System;

namespace Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            string inputInform = string.Empty;
            int inputInformNumber = 0;
            int allCake = 0;
            int allPc = 0;
            int eatingCakes = 0;

            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            allCake = length * width;
            allPc = allCake / 1;


            while (((inputInform = Console.ReadLine()) != "STOP") )
            {
                inputInformNumber = Math.Abs(int.Parse(inputInform));

                eatingCakes += inputInformNumber;
                allPc -= inputInformNumber;

                if (allPc < 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(allCake - eatingCakes)} pieces more.");
                    break;
                }
            }

            if (inputInform == "STOP")
            {
                Console.WriteLine($"{allCake - eatingCakes} pieces are left.");
            }
           
        }
    }
}
