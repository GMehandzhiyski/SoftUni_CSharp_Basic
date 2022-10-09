using System;
using System.Data;

namespace ToyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tripPrice =  double.Parse(Console.ReadLine());
            int puzzleNumber = int.Parse(Console.ReadLine());
            int dollsNumber = int.Parse(Console.ReadLine());
            int tedybearNumber = int.Parse(Console.ReadLine());
            int minionsNumber = int.Parse(Console.ReadLine());
            int trucksNumber = int.Parse(Console.ReadLine());
            double ToysSumTotal;

            double puzzleSum = puzzleNumber * 2.60;
            double dollsSum = dollsNumber * 3;
            double tedybearSum = tedybearNumber * 4.10;
            double minionsSum = minionsNumber * 8.20;
            double trucksSum = trucksNumber * 2;


            int ToysTotal = puzzleNumber + dollsNumber + tedybearNumber + minionsNumber + trucksNumber;




            if (ToysTotal >= 50)
            {
                double ToysSumMiddle = (puzzleSum + dollsSum + tedybearSum + minionsSum + trucksSum) - ((puzzleSum + dollsSum + tedybearSum + minionsSum + trucksSum) * 0.25);// include 25% for >= 50pcs toys
                ToysSumTotal = ToysSumMiddle - (ToysSumMiddle * 0.10);// include 10% for rent
            }
            else
            {
                ToysSumTotal = (puzzleSum + dollsSum + tedybearSum + minionsSum + trucksSum) - ((puzzleSum + dollsSum + tedybearSum + minionsSum + trucksSum) * 0.10);// include 10% for rent
            }

            if (tripPrice >= ToysSumTotal)
            {
                double leftmoney = tripPrice - ToysSumTotal;
                Console.WriteLine($"Not enough money! {leftmoney:F2} lv needed.");
                
            }
            else
            {

                double leftmoney = ToysSumTotal - tripPrice;
                Console.WriteLine($"Yes! {leftmoney:F2} lv left.");
            }
        }
    }
}
