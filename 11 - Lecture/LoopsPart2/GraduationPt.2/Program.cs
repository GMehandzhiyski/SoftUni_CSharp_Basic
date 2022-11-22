using System;

namespace GraduationPt._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int cycleWhile = 12;
            int cycleCount = 0;
            double grade = 0.0;
            double finalGrade = 0;
            int faulty = 0;

            


            while ((cycleWhile > cycleCount) && faulty < 2)
            {
                grade = double.Parse(Console.ReadLine());

                finalGrade = (finalGrade + grade);
                if (grade < 4.00)
                {
                    faulty++;
                }
                cycleCount++;

                

            }

            if (cycleWhile == cycleCount && faulty != 2)
            {
                if ((finalGrade / 12) >= 4.00)
                {
                    Console.WriteLine($"{name} graduated. Average grade: {finalGrade / 12:f2}");
                }
            }

            if (faulty >= 2)
            {
                
                Console.WriteLine($"{name} has been excluded at {cycleCount - 1} grade");
            }
        }
    }
}
