using System;

namespace OldBooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string theBook = Console.ReadLine();
            int capacityLib = Math.Abs(int.Parse(Console.ReadLine()));
            string othersBook = "";
            int cycleCounter = 0;

            while (capacityLib > cycleCounter && othersBook != theBook)
            {
                othersBook = Console.ReadLine();
                
                if (othersBook == theBook)
                {
                    Console.WriteLine($"You checked {cycleCounter} books and found it.");
                    break;
                }

                cycleCounter++;
            }

            if (capacityLib == cycleCounter)
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {cycleCounter} books.");
            }

            
        }
    }
}
