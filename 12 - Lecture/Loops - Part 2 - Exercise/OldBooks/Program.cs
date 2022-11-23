using System;
using static System.Reflection.Metadata.BlobBuilder;

namespace OldBooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string theBook = Console.ReadLine();
            int capacityLib = int.Parse(Console.ReadLine());
            string othersBook ="" ;
            int cycleCounter = 0;
           
            while (capacityLib > cycleCounter && othersBook != theBook)
            {
                othersBook = Console.ReadLine();
                
                cycleCounter++;
            }

            if (capacityLib == cycleCounter)
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {cycleCounter} books.");
            }
       
            if ( othersBook == theBook)
            {
                Console.WriteLine($"You checked {cycleCounter - 1} books and found it.");  
            }
        
        }
    }
}
