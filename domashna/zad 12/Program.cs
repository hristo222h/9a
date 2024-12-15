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

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // за реда отгоре питахме ai защото иначе изписва въпросителни

            int a, b, c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            if ((a >= 10 && a <= 100) & (b >= 10 && b <= 100) & (c >= 10 && c <= 100))
            {
                int d = a + b + c;
                Console.WriteLine("Сумате от трите числа е " + d);
            }
            else
            {
                Console.WriteLine("Числото/а или са по-малки от 10 или са по-големи от 100");
            }

        }
    }
}
