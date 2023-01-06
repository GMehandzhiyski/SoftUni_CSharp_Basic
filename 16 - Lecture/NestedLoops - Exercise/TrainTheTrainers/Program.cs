using System;

namespace TrainTheTrainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
           double score = 0;
           double midScore = 0;
           double totalScore = 0;
           string presentationName = string.Empty;
           double forCounter = 0;

            int jury = int.Parse(Console.ReadLine());

                while ((presentationName = Console.ReadLine()) != "Finish")
                {
                    for (int i = 0; i < jury; i++)
                    {
                        score += double.Parse(Console.ReadLine());
                        
                        forCounter++;   
                        
                    }
                    Console.WriteLine($"{presentationName} - {(score / jury):f2}.");
                    midScore += score;
                    score = 0;
                }
                totalScore = midScore / forCounter;
                Console.WriteLine($"Student's final assessment is {totalScore:f2}.");
        }
    }
}
