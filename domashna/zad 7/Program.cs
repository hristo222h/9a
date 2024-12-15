using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // за реда отгоре питахме ai защото иначе изписва въпросителни


            int n = int.Parse(Console.ReadLine());
            if ((n % 2 == 0) || (n % 3 == 0) || (n % 5 == 0) || (n % 7 == 0))
            {
                if ((n == 2) || (n == 3) || (n == 5) || (n == 7))
                {
                    Console.WriteLine("Числото е просто");
                }
                else
                {
                    Console.WriteLine("Числото е сложно");
                }
            }
            else
            {
                Console.WriteLine("Числото е просто");
            }
            //Разбрах че е грешна чак като стигнах на 13 нз как да я оправя
            //Маѝ го оправих нз

        }
    }
}
