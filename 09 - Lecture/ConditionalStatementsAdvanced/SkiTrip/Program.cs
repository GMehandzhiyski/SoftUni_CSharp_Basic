using System;

namespace SkiTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int daysin = int.Parse(Console.ReadLine());
            string rooms = (Console.ReadLine());  
            string rating = Console.ReadLine();
            int night = 0;
            double afterDiscount;
            int days;

            days = Math.Abs(daysin);
            night = days - 1;
            switch (rooms)
            {
                case "room for one person":
                    
                    if (rating == "positive")
                    {
                        Console.WriteLine($"{(night * 18.00) + ((night * 18.00) * 0.25):f2}");
                    }
                    else if (rating == "negative")
                    {
                        Console.WriteLine($"{(night * 18.00) - ((night * 18.00) * 0.10):f2}");
                    }
                    else Console.WriteLine("error");

                    break;

                case "apartment":
                    if (rating == "positive")
                    {
                        if (days < 10)
                        {
                            afterDiscount = (night * 25.00) - ((night * 25.00) * 0.30); // - 30%

                            Console.WriteLine($"{(afterDiscount) + (afterDiscount * 0.25):f2}"); // + 25%
                        }
                        else if (days >= 10 && days <= 15)
                        {
                            afterDiscount = (night * 25.00) - ((night * 25.00) * 0.35); // - 35%

                            Console.WriteLine($"{(afterDiscount) + (afterDiscount * 0.25):f2}"); // + 25%
                        }
                        else if (days > 15)
                        {
                            afterDiscount = (night * 25.00) - ((night * 25.00) * 0.50); // - 50%

                            Console.WriteLine($"{(afterDiscount) + (afterDiscount * 0.25):f2}"); // + 25%
                        }

                    }
                    else if (rating == "negative")
                    {

                        if (days < 10)
                        {
                            afterDiscount = (night * 25.00) - ((night * 25.00) * 0.30); // - 30%

                            Console.WriteLine($"{(afterDiscount) - (afterDiscount * 0.10)}:f2"); // - 10%
                        }
                        else if (days >= 10 && days <= 15)
                        {
                            afterDiscount = (night * 25.00) - ((night * 25.00) * 0.35); // - 35%

                            Console.WriteLine($"{(afterDiscount) - (afterDiscount * 0.10)}:f2"); // - 10%
                        }
                        else if (days > 15)
                        {
                            afterDiscount = (night * 25.00) - ((night * 25.00) * 0.50); // - 50%

                            Console.WriteLine($"{ (afterDiscount) - (afterDiscount * 0.10)}:f2"); // - 10%
                        }

                    }
                    else Console.WriteLine("error");
                    break ;


                case "president apartment":

                    if (rating == "positive")
                    {
                        if (days < 10)
                        {
                            afterDiscount = (night * 35.00) - ((night * 35.00) * 0.10); // - 10%

                            Console.WriteLine($"{(afterDiscount) + (afterDiscount * 0.25):f2}"); // + 25%
                        }
                        else if (days >= 10 && days <= 15)
                        {
                            afterDiscount = (night * 35.00) - ((night * 35.00) * 0.15); // - 15%

                            Console.WriteLine($"{(afterDiscount) + (afterDiscount * 0.25):f2}"); // + 25%
                        }
                        else if (days > 15)
                        {
                            afterDiscount = (night * 35.00) - ((night * 35.00) * 0.20); // - 20%

                            Console.WriteLine($"{(afterDiscount) + (afterDiscount * 0.25):f2}"); // + 25%
                        }

                    }
                    else if (rating == "negative")
                    {

                        if (days < 10)
                        {
                            afterDiscount = (night * 35.00) - ((night * 35.00) * 0.10); // - 10%

                            Console.WriteLine($"{(afterDiscount) - (afterDiscount * 0.10):f2}"); // - 10%
                        }
                        else if (days >= 10 && days <= 15)
                        {
                            afterDiscount = (night * 35.00) - ((night * 35.00) * 0.35); // - 15%

                            Console.WriteLine($"{(afterDiscount) - (afterDiscount * 0.10):f2}"); // - 10%
                        }
                        else if (days > 15)
                        {
                            afterDiscount = (night * 35.00) - ((night * 35.00) * 0.20); // - 20%

                            Console.WriteLine($"{(afterDiscount) - (afterDiscount * 0.10):f2}" ); // - 10%
                        }

                    }
                    else Console.WriteLine("error");
                    break;
            default:
                    Console.WriteLine("error");
                    break;
            
            
            
            
            
            }
        }
    }
}
