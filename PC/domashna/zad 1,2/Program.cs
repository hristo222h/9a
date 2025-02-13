using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10; i < 26; i++)
            {
                int a = i % 2;
                if (a == 1)
                {
                    Console.Write(i + "");
                    int b = i * i * i;
                    Console.WriteLine(" = " + b);
                }
                else
                {
                    int b = i * i;
                    Console.WriteLine("                     " + i + " = " + b);
                }
            }
        }
    }
}
