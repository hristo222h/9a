using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a, b, c, d;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            if ((a >= 0 && a <= 100) & (b >= 10 && b <= 100) & (c >= 10 && c <= 100))
            {
                d = a + b * c;
                Console.WriteLine("Sumata na trite chisla e " + d);
            }
            else
            {
                Console.WriteLine("Chislot o/a ili sa po-malki ot 10 ili sa po-golemi ot 100");
            }
        }
    }
}
