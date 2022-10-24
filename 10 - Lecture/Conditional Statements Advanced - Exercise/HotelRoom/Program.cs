using System;

namespace HotelRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double apartamentPrice = 0;
            double studioPrice = 0;

            if (month == "May" || month == "October")
            {
                if (nights > 7 && nights <= 14)
                {
                    studioPrice = (50 * nights) - (50 * nights) * 0.05;
                    apartamentPrice = 65 * nights;
                }
                else if (nights > 14)
                {
                    studioPrice = (50 * nights) - (50 * nights) * 0.30;
                    apartamentPrice = (65 * nights) - (65 * nights) * 0.10;
                }
            }
            else if (month == "June" || month == "September")
            {

                if (nights <= 14)
                {
                    studioPrice = 75.20 * nights;
                    apartamentPrice = 68.70 * nights;
                }
                else if (nights > 14)
                {
                    studioPrice = (75.20 * nights) - (75.20 * nights) * 0.20;
                    apartamentPrice = (68.70 * nights) - (68.70 * nights) * 0.10;
                }

            }
            else if (month == "July" || month == "August")
            {
                if (nights <= 14)
                {
                    studioPrice = 76 * nights;
                    apartamentPrice = 77 * nights;
                }
                else if (nights > 14)
                {
                    studioPrice = 76 * nights;
                    apartamentPrice = (77 * nights) - (77 * nights) * 0.10;
                }
            }
           


            //output
            Console.WriteLine($"Apartament: {apartamentPrice:f2} lv.");
            Console.WriteLine($"Studio: {studioPrice:f2} lv.");
        }
    }
}
