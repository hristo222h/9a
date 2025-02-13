using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if ((i % 4 == 1) && (i % 8 == 1))
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
