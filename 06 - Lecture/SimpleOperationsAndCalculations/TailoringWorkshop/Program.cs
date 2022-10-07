using System;

namespace TailoringWorkshop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tableNumber = int.Parse(Console.ReadLine());
            double length =double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double priceUSD;
            double priceBGN;
            double tableclothArea;
            double squareArea;




            tableclothArea = (((length +  0.60) * (width + 0.60)) * tableNumber);
            squareArea = (((length / 2) * (length / 2)) * tableNumber);


            priceUSD = ((tableclothArea * 7) + (squareArea * 9)) ;
            priceBGN = priceUSD * 1.85;




            Console.WriteLine($"{priceUSD:F2} USD");
            Console.WriteLine($"{priceBGN:F2} BGN");
        }
    }
}
