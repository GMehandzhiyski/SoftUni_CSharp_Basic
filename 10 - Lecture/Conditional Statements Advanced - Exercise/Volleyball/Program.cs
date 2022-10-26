using System;
using System.Xml.Schema;

namespace Volleyball
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            string year = Console.ReadLine();
            int holliday = int.Parse(Console.ReadLine());
            int weekend = int.Parse(Console.ReadLine());

            double saturdayGames = 0;
            double hollidayGames = 0;
            double midleGames = 0;
            double totalGames = 0;

            saturdayGames = (48 - weekend) * 0.75;//play voley in Sofia
            hollidayGames = holliday * (0.666666667);//play voley in BornTown

            midleGames = saturdayGames + hollidayGames + weekend;

            if (year == "leap")
            {
                totalGames = midleGames + (midleGames * 0.15);
            }
            else if (year == "normal")
            {
                totalGames = midleGames;
            }

            Console.WriteLine($"{Math.Floor(totalGames)}");

        }
    }
}
