using System;

namespace PetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dogs = int.Parse(Console.ReadLine());
            int allAnimals = int.Parse(Console.ReadLine());
            double dogFood = 2.50;
            int allAnimalsFood = 4;
            double priceFood = (dogs * dogFood) + (allAnimals * allAnimalsFood);

            Console.WriteLine($"{priceFood:F2} lv.");
        }
    }
}
