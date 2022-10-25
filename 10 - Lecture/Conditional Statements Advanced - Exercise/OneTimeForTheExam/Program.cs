using System;

namespace OneTimeForTheExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            double hourForExam = double.Parse(Console.ReadLine());
            double minuteForExam = double.Parse(Console.ReadLine());  
            double arrivalhour = double.Parse(Console.ReadLine());
            double arrivalminute = double.Parse(Console.ReadLine());

            double examTimeInMin = 0;
            double arrivalTimeInMin = 0;
            double examTimeInMinMinus = 0;
        



            examTimeInMin = (hourForExam * 60) + minuteForExam;
            arrivalTimeInMin = (arrivalhour * 60) + arrivalminute;

            examTimeInMinMinus = Math.Abs(examTimeInMin - arrivalTimeInMin);// time minus 30 

            if (examTimeInMin == arrivalTimeInMin) // the same time
            {
               
                Console.WriteLine($"On Time");
            }
            else if (examTimeInMinMinus >= 1 && examTimeInMinMinus <= 30)// to 30min before
            {
                Console.WriteLine($"On Time");
                Console.WriteLine($"{examTimeInMinMinus} minutes before the start");
            }
            else if (examTimeInMin < arrivalTimeInMin)//late
            {
                Console.WriteLine($"Late");
                if (examTimeInMinMinus < 60)
                {
                    Console.WriteLine($"{examTimeInMinMinus} minutes after the start ");

                }
                else if (examTimeInMinMinus >= 59)
                {
                    if ((examTimeInMinMinus % 60) < 10)
                    {
                        Console.WriteLine($"{Math.Floor(examTimeInMinMinus / 60)}:0{examTimeInMinMinus % 60} hours after the start");
                    }
                    else if ((examTimeInMinMinus % 60) >= 10)
                    {
                        Console.WriteLine($"{Math.Floor(examTimeInMinMinus / 60)}:{examTimeInMinMinus % 60} hours after the start");
                    }
                   
                }
            }
            else if (examTimeInMinMinus > 30)// early
            {
                Console.WriteLine($"Early");
                if (examTimeInMinMinus <= 59)
                {
                    Console.WriteLine($"{examTimeInMinMinus} minutes before the start");
                }
                else if (examTimeInMinMinus >= 60)
                {
                    if ((examTimeInMinMinus % 60) < 10)
                    {
                        Console.WriteLine($"{Math.Floor(examTimeInMinMinus / 60)}:0{examTimeInMinMinus % 60} hours before the start");
                    }
                    else if ((examTimeInMinMinus % 60) >= 10)
                    {
                        Console.WriteLine($"{Math.Floor(examTimeInMinMinus / 60)}:{examTimeInMinMinus % 60} hours before the start");
                    }

                }
                
            }

            



        }
    }
}
