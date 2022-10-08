using System;

namespace AlcoholMarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double whiskeyPrice = double.Parse(Console.ReadLine());
            double beerQantity = double.Parse(Console.ReadLine());
            double wineQantity = double.Parse(Console.ReadLine());
            double rakiaQantity = double.Parse(Console.ReadLine());
            double whiskeyQantity = double.Parse(Console.ReadLine());

            double rakiaPrice = whiskeyPrice / 2;
            double winePrice = rakiaPrice - (rakiaPrice * 0.40);
            double beerPrice = rakiaPrice - (rakiaPrice * 0.80);

            double totalPrice = (whiskeyPrice * whiskeyQantity) + (beerPrice * beerQantity) + (winePrice * wineQantity) + (rakiaPrice * rakiaQantity) ;


             Console.WriteLine($"{totalPrice:F2}");

        }
    }
}
