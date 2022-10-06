using System;

namespace YardGreening
{
    internal class Program
    {
        static void Main(string[] args)
        {
          double area = double.Parse(Console.ReadLine());
          double normalPrice = 7.61;
          double discount = 0.18;
          double discountPrice;
          double finalPrice;

            discountPrice = (normalPrice * area) * discount;
            finalPrice = (normalPrice * area) - discountPrice;

            Console.WriteLine($"The final price is: {finalPrice:F2} lv.");
            Console.WriteLine($"The discount is: {discountPrice:F2} lv.");
        }
    }
}
