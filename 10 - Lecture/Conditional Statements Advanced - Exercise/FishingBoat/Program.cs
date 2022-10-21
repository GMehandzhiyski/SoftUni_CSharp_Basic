using System;

namespace FishingBoat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int buget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numberFisher = int.Parse(Console.ReadLine());
            double price = 0;
            double totalPrice = 0;


            if (season == "Spring")
            {
                if (numberFisher <= 6)
                {
                    price = (3000 - (3000 * 0.10));
                }
                else if (numberFisher >= 7 && numberFisher <= 11)
                {
                    price = (3000 - (3000 * 0.15));

                }
                else if (numberFisher >= 12)
                {
                    price = (3000 - (3000 * 0.25));
                }

                if (numberFisher % 2 == 0)
                {
                    totalPrice = (price - (price * 0.05));
                }
                else if (numberFisher % 2 != 0)
                {
                    totalPrice = price;
                }

            }
            else if (season == "Summer")
            {
                if (numberFisher <= 6)
                {
                    price = (4200 - (4200 * 0.10));
                }
                else if (numberFisher >= 7 && numberFisher <= 11)
                {
                    price = (4200 - (4200 * 0.15));

                }
                else if (numberFisher >= 12)
                {
                    price = (4200 - (4200 * 0.25));
                }

                if (numberFisher % 2 == 0)
                {
                    totalPrice = (price - (price * 0.05));
                }
                else if (numberFisher % 2 != 0)
                {
                    totalPrice = price;
                }
            }
            else if (season == "Autumn")
            {
                if (numberFisher <= 6)
                {
                    totalPrice = (4200 - (4200 * 0.10));
                }
                else if (numberFisher >= 7 && numberFisher <= 11)
                {
                    totalPrice = (4200 - (4200 * 0.15));

                }
                else if (numberFisher >= 12)
                {
                    totalPrice = (4200 - (4200 * 0.25));
                }
            }
            else if (season == "Winter")
            {
                if (numberFisher <= 6)
                {
                    price = (2600 - (2600 * 0.10));
                }
                else if (numberFisher >= 7 && numberFisher <= 11)
                {
                    price = (2600 - (2600 * 0.15));

                }
                else if (numberFisher >= 12)
                {
                    price = (2600 - (650));
                }

                if (numberFisher % 2 == 0)
                {
                    totalPrice = (price - (price * 0.05));
                }
                else if (numberFisher % 2 != 0)
                {
                    totalPrice = price;
                }

            }



                // Output
                if (buget >= totalPrice)
            {
                Console.WriteLine($"Yes! You have {buget - totalPrice:f2} leva left.");
            }
            else if (buget < totalPrice)
            {
                Console.WriteLine($"Not enough money! You need {totalPrice - buget:f2} leva.");
            }
        }
    }
}
