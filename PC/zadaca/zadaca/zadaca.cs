using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaca
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // без този ред ми изписваше само въпросителни знаци добре че има google

            int n;
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());

            if (n == 1)
            {
                Console.WriteLine("Понеделни");
            }
            if (n == 2)
            {
                Console.WriteLine("Вторник");
            }
            if (n == 3)
            {
                Console.WriteLine("Сряда");
            }
            if (n == 4)
            {
                Console.WriteLine("Четвъртък");
            }
            if (n == 5)
            {
                Console.WriteLine("Петък");
            }
            if (n == 6)
            {
                Console.WriteLine("Събота");
            }
            if (n == 7)
            {
                Console.WriteLine("Неделя");
            }
            if (n >= 8)
            {
                Console.WriteLine("Няма такъв ден от седмицата");
            }
        }
    }
}
