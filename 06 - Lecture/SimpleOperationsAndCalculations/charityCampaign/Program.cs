using System;
using System.Data;

namespace charityCampaign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int sweetShop = int.Parse(Console.ReadLine());
            int cakeNumber = int.Parse(Console.ReadLine());
            int wafflesNumber = int.Parse(Console.ReadLine());
            int pencakeNumber = int.Parse(Console.ReadLine());


            double cakePricePerDay = 45 * cakeNumber;
            double wafflesPricePerDay = 5.80 * wafflesNumber;
            double pancakePricePerDay = 3.20 * pencakeNumber;

            double totalDaysPrice = ((cakePricePerDay + wafflesPricePerDay + pancakePricePerDay) * sweetShop) * days;

            double priceAfterCost = totalDaysPrice - (totalDaysPrice * 0.125);


            Console.WriteLine($"{priceAfterCost:F2}");







        }
    }
}
