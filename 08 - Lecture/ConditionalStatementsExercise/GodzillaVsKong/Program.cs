using System;

namespace GodzillaVsKong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bugetStart =  double.Parse(Console.ReadLine());
            int supernumerary = int.Parse(Console.ReadLine());
            double clothesPrice = double.Parse(Console.ReadLine());
            double clothesBuget = 0;
            double cost = 0;
            double residue = 0;

            double decorPrice = bugetStart * 0.10;
            //Console.WriteLine(decorPrice);

            if (supernumerary > 150)
            {
                clothesBuget = (supernumerary * clothesPrice) - ((supernumerary * clothesPrice) * 0.10);
                cost = decorPrice + clothesBuget;
            }
            else
            {
                clothesBuget = (supernumerary * clothesPrice);
                cost = decorPrice + clothesBuget;
            }


            if (bugetStart >= cost)
            {
                residue = bugetStart - cost;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {residue:F2} leva left.");
            }
            else 
            {
                residue = cost - bugetStart;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {residue:F2} leva more.");
            }







        }
    }
}
