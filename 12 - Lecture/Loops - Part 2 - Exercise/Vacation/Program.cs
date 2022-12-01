using System;
using System.Diagnostics;

namespace Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vacantionMoney = int.Parse(Console.ReadLine());
            double availableMoney = int.Parse(Console.ReadLine());
            int spendConuter = 0;
            int saveCounter = 0;
            int daysCounter = 0;

            string operation = string.Empty;  
            double inputMoney = 0;



            while (spendConuter < 5 && availableMoney < vacantionMoney)
            {
                operation = Console.ReadLine();
                inputMoney = int.Parse(Console.ReadLine());
             

                if (operation == "spend")
                {
                    availableMoney = availableMoney - inputMoney;
                    if (availableMoney < 0)
                    {
                        availableMoney = 0;
                    }
                    spendConuter++;
                    daysCounter++;
                }

                if (operation == "save")
                {
                    saveCounter++;
                    availableMoney = availableMoney + inputMoney;
                    spendConuter = 0;
                    daysCounter ++;
                }

               
            }
                if (availableMoney >= vacantionMoney)
                {
                Console.WriteLine($"You saved the money for {daysCounter} days.");
                }

                if (spendConuter >= 5)
                {
                Console.WriteLine($"You can't save the money.");
                Console.WriteLine($"{spendConuter}");
                }

           

        }
    }
}
