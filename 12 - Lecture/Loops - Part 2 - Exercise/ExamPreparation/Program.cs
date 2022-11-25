using System;

namespace ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int badGrade = int.Parse(Console.ReadLine());
            string nameEx = String.Empty;
            int grade = 0;
            int badGradeCount = 0;
            int whileCount = 0;
            double averageGrade = 0;


            while((nameEx = Console.ReadLine()) != "Enough") 
            {
                grade = int.Parse(Console.ReadLine());
                whileCount++;
                averageGrade = (grade + averageGrade)/whileCount;

                if (grade <= 4.00)
                {
                    badGradeCount++;
                }
                if (badGrade == badGradeCount)
                {
                    Console.WriteLine($"You need a break, {badGrade} poor grades.");
                    break;
                }
            }

            if (nameEx == "Enough")
            {
                Console.WriteLine($"Average score: { averageGrade:f2}");
                Console.WriteLine($"Number of problems: {whileCount}");
                Console.WriteLine($"Last problem: {nameEx}");

            }


            

        }
    }
}