using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int b = 0; 
            for (int i = 1; i <= n; i++)
            {
                if((i % 2 == 0) || (i % 3 == 0) || (i % 5 == 0) || (i % 7 == 0))
                {
                    if ((i == 2) || (i == 3) || (i == 5) || (i == 7))
                    {
                        b = b + i; 
                    }
                }
                else
                {
                    b = b + i; 
                }
            }
            Console.WriteLine(b); 
            // задачата брои и едно като просто число заради условието и
        }
    }
}
