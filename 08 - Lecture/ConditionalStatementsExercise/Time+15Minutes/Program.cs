using System;

namespace Time_15Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hoursIn = int.Parse(Console.ReadLine());
            int minutesIn = int.Parse(Console.ReadLine());
            int minutesMeddleValue = 0;
            int minutesMeddleValue1 = 0;
            int hoursOut = 0;
            int minutesOut = 0;


            minutesMeddleValue = minutesIn + 15;

            if (minutesMeddleValue > 59)
            {
                //minutesMeddleValue1 = minutesMeddleValue - 15;
                if (hoursIn == 23 )
                {
                    hoursOut = 0;
                    minutesOut = minutesMeddleValue - minutesIn;
                }
                else
                    hoursOut = hoursIn + 1;
                    minutesOut = minutesMeddleValue - 60;
            
            }
            else
            {
                //minutesMeddleValue1 = minutesMeddleValue - 15;
                if (hoursIn == 23)
                {
                    hoursOut = 0;
                    minutesOut = minutesMeddleValue;
                }
                else
                {
                    hoursOut = hoursIn;
                    minutesOut = minutesMeddleValue;
                }
                    
            }

            if (minutesOut < 10)
            { 
                Console.WriteLine($"{hoursOut}:0{minutesOut}"); 
            }
            else
            {
                Console.WriteLine($"{hoursOut}:{minutesOut}");
            }
               

        }
    }
}
