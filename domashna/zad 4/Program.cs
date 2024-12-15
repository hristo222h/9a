using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            int n = int.Parse(Console.ReadLine());
            for (i = 1 ;  i <= n; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Nai golqmoto chislo e " + n);
            Console.WriteLine("Nai malkoto chislo e " + (i - n));

        }
    }
}
