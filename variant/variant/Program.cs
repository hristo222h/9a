using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variant
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 5;
            while (true)
            {
                if (a < 10)
                {
                    Console.WriteLine("a = " + a);
                    a++;
                }
                break;
            }

        }
    }
}
