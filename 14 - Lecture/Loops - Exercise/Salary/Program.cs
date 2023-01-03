using System;

namespace Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double tabs = double.Parse(Console.ReadLine());
           double salary = double.Parse(Console.ReadLine());

            for (int i = 0; i < tabs; i++)
            {
                string webSite = Console.ReadLine();

                if (webSite == "Facebook")
                {
                    salary -= 150;

                    if (salary <= 0)
                    {
                        Console.WriteLine("You have lost your salary.");
                        break;
                    }
                }
                else if (webSite == "Instagram")
                {
                    salary -= 100;

                    if (salary <= 0)
                    {
                        Console.WriteLine("You have lost your salary.");
                        break;
                    }
                }
                else if (webSite == "Reddit")
                {

                    salary -= 50;

                    if (salary <= 0)
                    {
                        Console.WriteLine("You have lost your salary.");
                        break;
                    }
                }

                if (i == tabs)
                {
                    Console.WriteLine(salary);
                }

            }
        }
    }
}
