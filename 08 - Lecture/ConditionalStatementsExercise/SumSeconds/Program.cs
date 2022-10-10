using System;

namespace SumSeconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int firstTime = int.Parse(Console.ReadLine());
           int secondTime = int.Parse(Console.ReadLine());
           int thirdTime = int.Parse(Console.ReadLine());

           int TotalTime = firstTime + secondTime + thirdTime;
            int minute = TotalTime / 60;
            int second = TotalTime % 60;
           // Console.WriteLine($"{minute}: {second}"); only test

            if (second < 10)
            {
                Console.WriteLine($"{minute}:0{second}");
            }
            else
            {
                Console.WriteLine($"{minute}:{second}");
            }
        }
    }
} 
