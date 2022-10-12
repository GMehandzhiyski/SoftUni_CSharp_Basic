using System;

namespace SmallShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string product = Console.ReadLine();
            string town = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double totalProductPrice = 0;
   


            if (town == "Sofia")
            {
                if (product == "coffee")
                {
                    totalProductPrice = 0.50 * quantity;
                }
                else if (product == "water")
                {
                    totalProductPrice = 0.80 * quantity;
                }
                if (product == "beer")
                {
                    totalProductPrice = 1.2 * quantity;
                }
                else if (product == "sweets")
                {
                    totalProductPrice = 1.45 * quantity;
                }
                else if (product == "peanuts")
                {
                    totalProductPrice = 1.60 * quantity;
                }

            }
            else if (town == "Plovdiv")
            {
                if (product == "coffee")
                {
                    totalProductPrice = 0.40 * quantity;
                }
                else if (product == "water")
                {
                    totalProductPrice = 0.70 * quantity;
                }
                if (product == "beer")
                {
                    totalProductPrice = 1.15 * quantity;
                }
                else if (product == "sweets")
                {
                    totalProductPrice = 1.30 * quantity;
                }
                else if (product == "peanuts")
                {
                    totalProductPrice = 1.50 * quantity;
                }
            }
            else if (town == "Varna")
            {
                if (product == "coffee")
                {
                    totalProductPrice = 0.45 * quantity;
                }
                else if (product == "water")
                {
                    totalProductPrice = 0.70 * quantity;
                }
                if (product == "beer")
                {
                    totalProductPrice = 1.10 * quantity;
                }
                else if (product == "sweets")
                {
                    totalProductPrice = 1.35 * quantity;
                }
                else if (product == "peanuts")
                {
                    totalProductPrice = 1.55 * quantity;
                }
            }

            Console.WriteLine($"{totalProductPrice}");
        }
    }
}
