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
                minutesMeddleValue1 = minutesMeddleValue - 15;
                if (hoursIn == 24 )
                {
                    hoursOut = 0;
                }
                else
                    hoursOut = hoursIn + 1;

            }
            else
            { 
            
            }


        }
    }
}
