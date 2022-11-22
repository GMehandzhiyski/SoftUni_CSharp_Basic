using System;

namespace Graduation
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



            while (cycleWhile > cycleCount)
            { 
               grade = double.Parse(Console.ReadLine());

                finalGrade = (finalGrade + grade);

                cycleCount++;
            }

            if (cycleWhile == cycleCount)
            {
                if (finalGrade >= 4.00)
                {
                    Console.WriteLine($"{name} graduated. Average grade: {finalGrade/12:f2}");
                }
              /*  else
                { 
                    Console.WriteLine($"{name} not graduated. Averade grade: {finalGrade:f2}");
                }
               */    

            }
        }
    }
}
