using System;

namespace Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            double buget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();


            string destination = "";
            string place = "";
            double spendMoney = 0;



            if (buget <= 100)
            {
                if (season == "summer")
                {
                    spendMoney = buget * 0.30;
                    destination = "Bulgaria";
                    place = "Camp";
                }
                else if (season == "winter")
                {
                    spendMoney = buget * 0.70;
                    destination = "Bulgaria";
                    place = "Hotel";
                }
            }
            else if (buget >= 100 && buget <= 1000)
            {
                if(season == "summer")
                {
                    spendMoney = buget * 0.40;
                    destination = "Balkans";
                    place = "Camp";
                }
                else if (season == "winter")
                {
                    spendMoney = buget * 0.80;
                    destination = "Balkans";
                    place = "Hotel";
                }
            }
            else if (buget > 1000)
            {
                spendMoney = buget * 0.90;
                destination = "Europe";
                place = "Hotel";
            }
            


            //Output
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{place} - {spendMoney:f2}");

        }
    }
}
