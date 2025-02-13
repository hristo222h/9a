using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domashna1_5
{
    internal class domashna1_5
    {
        static void Main(string[] args)
        {

            int a, b;
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());
            Console.Write("m = ");
            var m = int.Parse(Console.ReadLine());
            m = a;
            if (m < b)
            {
                m = b;
            }
            Console.WriteLine(m);

        }
    }
}
