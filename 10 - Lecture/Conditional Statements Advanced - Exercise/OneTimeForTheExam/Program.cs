using System;

namespace OneTimeForTheExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            int hourForExam = int.Parse(Console.ReadLine());
            int minuteForExam = int.Parse(Console.ReadLine());  
            int arrivalhour = int.Parse(Console.ReadLine());
            int arrivalminute = int.Parse(Console.ReadLine());

            int examTimeInMin = 0;
            int arrivalTimeInMin = 0;
            int examTimeInMinMinus = 0;
            string status = "";



            examTimeInMin = (hourForExam * 60) + minuteForExam;
            arrivalTimeInMin = (arrivalhour * 60) + arrivalminute;

            examTimeInMinMinus = examTimeInMin - arrivalTimeInMin;// time minus 30 


            if (examTimeInMin == arrivalTimeInMin) // the same time
            {
                status = "On time";
            }
            else if (examTimeInMinMinus >= 1 && examTimeInMinMinus <= 30)// to 30min before
            {
                Console.WriteLine($"On Time");
                Console.WriteLine($"{examTimeInMinMinus} minutes before the start");
            }
            else if (examTimeInMin < arrivalTimeInMin)
            {
                status = "Late";
            }
            else if (examTimeInMinMinus > 30)
            {
                Console.WriteLine($"Early");
                Console.WriteLine($"{} hours before the start");
            }




            
        }
    }
}
