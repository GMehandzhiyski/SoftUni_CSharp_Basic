using System;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;

namespace Combinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int n = int.Parse(Console.ReadLine());
            int ij = 0;

            for (int i = 0; i < n; i++)
            {
                for (int ii = 0; ii <= n; ii++)
                {
                    for (int iii = 0; iii <= n; iii++)
                    {
                        if (i + ii + iii == n)
                        {
                           
                            counter++;
                        }
                      

                    }
                }
                ij = i;
            }
            if (ij == n)
            {
                Console.WriteLine(counter);
            }
            


        }
    }
}
