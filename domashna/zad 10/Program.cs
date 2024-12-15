using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int a = 0;
            while (n > 0) 
            {
                int b = n % 10;          
                a = a * 10 + b;
                n = n / 10;
            }
            Console.WriteLine(a);

        }
    }
}
