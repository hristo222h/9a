using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domashna1_4
{
    internal class domashna1_4
    {
        static void Main(string[] args)
        {

            int a, b;
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            var c = int.Parse(Console.ReadLine());
            c = a;
            a = b;
            b = c;
            Console.WriteLine(a);
            Console.WriteLine(b);

        }
    }
}
