using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n, a, b;
            n = int.Parse(Console.ReadLine());
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            if ((n % a == 0) && (n % b != 0))
            {
                Console.WriteLine(n);
            }
            else
            {
                Console.WriteLine("Chisloto ili se deli na b ili ne se deli na nito edno ot dvete ");
            }
        }
    }
}
