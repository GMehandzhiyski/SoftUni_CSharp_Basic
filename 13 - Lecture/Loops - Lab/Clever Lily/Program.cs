using System;

namespace Clever_Lily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double ageLily = double.Parse(Console.ReadLine());
            double washingMachine = double.Parse(Console.ReadLine());
            double toyPricePerPieces = double.Parse(Console.ReadLine());
            double toyNumber = 0;
            double money = 0;
            double toyPrice = 0;
            double savedMoney = 0;
            int moneyCounter = 0;

            for (int i = 1; i <= ageLily; i++)
            {
                if (i % 2 == 0)
                {
                    money += (10);
                    savedMoney += money; 
                    moneyCounter++;

                }
                else
                {
                    toyNumber++;
                }

            }

            toyPrice = toyNumber * toyPricePerPieces;
            savedMoney += (toyPrice - moneyCounter);

            if (savedMoney >= washingMachine)
            {
                Console.WriteLine($"Yes! {(savedMoney - washingMachine):F2}");
            }
            if(savedMoney < washingMachine)
            {
                Console.WriteLine($"No! {Math.Abs(washingMachine - savedMoney):F2}");
            }


        }
    }
}
