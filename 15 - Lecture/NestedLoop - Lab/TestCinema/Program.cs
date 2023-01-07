using System;

namespace TestCinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movieName = string.Empty;
            double allStudent = 0.0;
            double allStandat = 0.0;
            double allKid = 0.0;
            double numberOfMovies = 0.0;
            double allSeats = 0.0;

            while ((movieName = Console.ReadLine()) != "Finish")
            {
                int freeSeats = int.Parse(Console.ReadLine());
                string typeOfTicket = string.Empty;
                int studentTicket = 0;
                int standardTicket = 0;
                int kidTicket = 0;
                allSeats += freeSeats;

                while ((typeOfTicket = Console.ReadLine()) != "End")
                {

                    if (typeOfTicket == "student")
                    {
                        studentTicket++;
                        allStudent++;
                    }
                    else if (typeOfTicket == "standard")
                    {
                        standardTicket++;
                        allStandat++;
                    }
                    else if (typeOfTicket == "kid")
                    {
                        kidTicket++;
                        allKid++;
                    }
                    if (freeSeats == (studentTicket + standardTicket + kidTicket))
                    {
                        break;
                    }


                }

                double allTicketsPerMovie = studentTicket + standardTicket + kidTicket;
                double porcentForMovie = allTicketsPerMovie / freeSeats;
                Console.WriteLine($"{movieName} - {porcentForMovie * 100:f2}% full.");
                numberOfMovies++;
            }

            double allTickets = allStudent + allStandat + allKid;
            double porcentStandartTickets = allStandat / allTickets;
            double porcentStudent = allStudent / allTickets;
            double porcentKid = allKid / allTickets;

            Console.WriteLine($"Total tickets: {allTickets}");
            Console.WriteLine($"{porcentStudent * 100:f2}% student tickets.");
            Console.WriteLine($"{porcentStandartTickets * 100:f2}% standard tickets.");
            Console.WriteLine($"{porcentKid * 100:f2}% kids tickets.");
        }
    }
}
