using System;

namespace NewHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int numberFlower = int.Parse(Console.ReadLine());
            int buget = int.Parse(Console.ReadLine());
            double flowerPrice = 0;
            double residue = 0;



            if (flower == "Roses")
            {
                if (numberFlower > 80)
                {
                    flowerPrice = (numberFlower * 5) - (numberFlower * 5) * 0.10;
                }
                else if (numberFlower <= 80)
                {
                    flowerPrice = (numberFlower * 5);
                }
            }
            else if (flower == "Dahlias")
            {
                if (numberFlower > 90)
                {
                    flowerPrice = (numberFlower * 3.80) - (numberFlower * 3.80) * 0.15;
                }
                else if (numberFlower <= 90)
                {
                    flowerPrice = (numberFlower * 3.80);
                }
            }
            else if (flower == "Tulips")
            {
                if (numberFlower > 80)
                {
                    flowerPrice = (numberFlower * 2.80) - (numberFlower * 2.80) * 0.15;
                }
                else if (numberFlower <= 80)
                {
                    flowerPrice = (numberFlower * 2.80);
                }
            }
            else if (flower == "Narcissus")
            {
                if (numberFlower < 120)
                {
                    flowerPrice = (numberFlower * 3) + (numberFlower * 3) * 0.15;
                }
                else if (numberFlower >= 120)
                {
                    flowerPrice = (numberFlower * 3);
                }
            }
            else if (flower == "Gladiolus")
            {
                if (numberFlower < 80)
                {
                    flowerPrice = (numberFlower * 2.5) + (numberFlower * 2.5) * 0.20;
                }
                else if (numberFlower >= 80)
                {
                    flowerPrice = (numberFlower * 2.5);
                }
            }

            if (buget > flowerPrice)
            {
                residue = buget - flowerPrice;
                Console.WriteLine($"Hey, you have a great garden with {numberFlower} {flower} and {residue:f2} leva left.");
            }
            else if (buget < flowerPrice)
            {
                residue = flowerPrice - buget;
                Console.WriteLine($"Not enough money, you need {residue:f2} leva more.");
            }
        }
    }
}
