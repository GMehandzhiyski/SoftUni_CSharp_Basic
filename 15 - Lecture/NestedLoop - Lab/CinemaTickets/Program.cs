using System;

namespace CinemaTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string film = string.Empty;
            string ticket = string.Empty;
            int emptyPlace = 0;
            double standartTicket = 0;
            double studenttTicket = 0;
            double kidtTicket = 0;
            int whileCount1 = 0;
            double totalTicket = 0;
            double midTickets = 0;
            double capacity = 0;


            while ((film = Console.ReadLine()) != "Finish")
            {
                emptyPlace = int.Parse(Console.ReadLine());

                while ((ticket = Console.ReadLine()) != "End")
                {
                    if (ticket == "standard")
                    {
                        standartTicket++;
                        midTickets++;
                    }
                    else if (ticket == "student")
                    {
                        studenttTicket++;
                        midTickets++;

                    }
                    else if (ticket == "kid")
                    {
                        kidtTicket++;
                        midTickets++;
                    }
                    if (emptyPlace == midTickets)
                    {
                        break;
                    }
                }
                totalTicket = standartTicket + studenttTicket + kidtTicket;
                capacity = midTickets / emptyPlace;
                midTickets = 0;
                Console.WriteLine($"{film} - {((capacity) * 100):f2}% full.");
            }

            totalTicket = standartTicket + studenttTicket + kidtTicket;
            double studentTicketPrecent = (studenttTicket / totalTicket) * 100;
            double standartTicketPercent = (standartTicket / totalTicket) * 100;
            double kidtTicketPrecent = (kidtTicket / totalTicket) * 100;
           
            Console.WriteLine($"Total tickets: {totalTicket}");
            Console.WriteLine($"{(studentTicketPrecent):f2}% student tickets.");
            Console.WriteLine($"{(standartTicketPercent):f2}% standard tickets.");
            Console.WriteLine($"{(kidtTicketPrecent):f2}% kids tickets.");


        }
    }
}
