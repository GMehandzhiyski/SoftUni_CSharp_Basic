using System;

namespace ProjectCreation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Name = Console.ReadLine();
            int Project = int.Parse(Console.ReadLine());

            int Hours = Project * 3;

            Console.WriteLine($" The architect {Name} will need {Hours} hours to complete {Project} project/s."); 



        }
    }
}
