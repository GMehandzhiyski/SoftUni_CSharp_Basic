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
           //bool stopCycle;
           
            roomArea = width * length * height;

            string command = Console.ReadLine();

            while (command != "Done")
            {
                int boxDimension =int.Parse(command);
                boxArea = boxDimension + boxArea;

                command = Console.ReadLine();
            }
            if (command == "Done")
            {
                Console.WriteLine(" Cubic meters left.");
            }
            /*
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());
            int freespace = width * length * hight;
            int totalSpace = 0;
            int spaceDiff = 0;
            string command = Console.ReadLine();

            while (command != "Done")
            {
                int cartoonSpace = int.Parse(command);

                totalSpace = totalSpace + cartoonSpace;
                spaceDiff = Math.Abs(totalSpace - freespace);
                if (totalSpace >= freespace)
                    Console.WriteLine("No more free space!You need {0} Cubic meters more.", spaceDiff);

                command = Console.ReadLine();

            }
            if (command == "Done")
            {
                Console.WriteLine("{0} Cubic meters left.", spaceDiff);
            }
            */
        }
    }
}
