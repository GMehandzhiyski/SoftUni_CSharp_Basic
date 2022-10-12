using System;

namespace Scholarship
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double rating = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());
            double scholarshipSocial = 0;
            double scholarshipExcellent = 0;


            


            if (rating > 4.50 && income < minSalary)
            {
                scholarshipSocial = minSalary * 0.35;
                scholarshipExcellent = (rating * 25);

                if (scholarshipSocial > 0 && scholarshipExcellent == 0)//Social scholarship
                {
                    Console.WriteLine($"You get a Social scholarship {scholarshipSocial} BGN");
                }

                if (scholarshipSocial == 0 && scholarshipExcellent > 0)//Excellent scholarship
                {

                    Console.WriteLine($"You get a scholarship for excellent results {scholarshipExcellent} BGN");
                }

                if (scholarshipSocial > 0 && scholarshipExcellent > 0)//Social  or Excellent scholarship
                {
                    if (scholarshipSocial > scholarshipExcellent)
                    {
                        
                        Console.WriteLine($"You get a Social scholarship {scholarshipSocial} BGN");
                    }
                    else
                    {
                        Console.WriteLine($"You get a scholarship for excellent results {scholarshipExcellent} BGN");
                    }
                }

            }
            else
            {
                Console.WriteLine($"You cannot get a scholarship!");
            }
        }
    }
}
