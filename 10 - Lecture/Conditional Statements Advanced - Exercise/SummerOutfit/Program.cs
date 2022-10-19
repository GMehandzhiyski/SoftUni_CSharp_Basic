using System;
using System.Text.Unicode;

namespace SummerOutfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string timeOfday = Console.ReadLine();
            string outfit = "";
            string shoes = "";


            if (10 <= degrees && degrees <= 18)
            {
                if (timeOfday == "Morning")
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";

                }
                else if (timeOfday == "Afternoon")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (timeOfday == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }

            }
            else if (18 < degrees && degrees <= 24)
            {
                if (timeOfday == "Morning")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (timeOfday == "Afternoon")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (timeOfday == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }


            }
            else if (degrees >= 25)
            {
                if (timeOfday == "Morning")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (timeOfday == "Afternoon")
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
                else if (timeOfday == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
        }
    }
}
