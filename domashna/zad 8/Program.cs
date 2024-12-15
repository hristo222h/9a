using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // за реда отгоре питахме ai защото иначе изписва въпросителни

            int n = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if ((n % a == 0) && (n % b != 0))
            {

                Console.WriteLine(n);

            }
            else
            {
                Console.WriteLine("Числото или се дели на б или не се дели на нито едно от двете");
            }
        }

    }
}
