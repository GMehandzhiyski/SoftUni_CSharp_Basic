using System;

namespace WordSwimmingRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double recordTime = double.Parse(Console.ReadLine());
            double range = double.Parse(Console.ReadLine());
            double timePer1km = double.Parse(Console.ReadLine());

            double delayTime = (Math.Floor(range / 15) * 12.5);//time in second
            double timeIvan = (range * timePer1km) + delayTime;//total time Ivan

            if (recordTime > timeIvan)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {timeIvan:F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {timeIvan - recordTime:F2} seconds slower.");
            }
               
            
        }
    }
}
