using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumirane_na_chisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var s = 0;
            do
            {
                s = s + (n % 10);
                n = n / 10;
            } while (n > 0);
            int u = s % 100/ 10;
            int i = s % 10;
            int o = s / 10;
            Console.WriteLine("sum of digits: {0}", s);
            if (n > 99)
            {
                Console.WriteLine("stotici " + o);
            }
            Console.WriteLine("desetici " + u);
            Console.WriteLine("edinici " + i);

        }
    }
}
