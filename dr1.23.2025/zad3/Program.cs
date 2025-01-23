using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            

            Console.Write("Въведи дума с малки букви: ");
            string duma = Console.ReadLine();
            for (int i = 0; i < duma.Length; i++)
            {
                int n = (int)duma[i] - (int)'a';
                Console.WriteLine($"Буква '{duma[i]}' е на индекс {n}");
            }

        }
    }
}
