using System;

namespace Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int roomArea = 0;
            int boxArea =0 ;
           
            roomArea = width * length * height;

            string command = Console.ReadLine();

            while (command != "Done")
            {
                int boxDimension =int.Parse(command);
                boxArea = boxDimension + boxArea;

                if (boxArea > roomArea)
                {
                    double missingArea = Math.Abs(roomArea - boxArea);
                    Console.WriteLine($"No more free space! You need {missingArea} Cubic meters more.");

                }

                command = Console.ReadLine();
            }
            if (command == "Done")
            {
               double residue = roomArea - boxArea;
                Console.WriteLine($"{residue} Cubic meters left.");
            }
            
        }
    }
}
