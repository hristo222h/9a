using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faktoriel
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int p = 1;
            while(n > 1)
            {
                p = p * n;
                n--;
            }
            Console.WriteLine("p = " + p);
        }
    }
}
