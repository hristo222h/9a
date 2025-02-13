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

            int n = int.Parse(Console.ReadLine());
            if ((n % 2 == 0) || (n % 3 == 0) || (n % 5 == 0) || (n % 7 == 0))
            {

                if ((n == 2) || (n == 3) || (n == 5) || (n == 7))
                {
                    Console.WriteLine("Chisloto e prosto");
                }
                else
                {
                    Console.WriteLine("Chisloto e slojno");
                }

            }
            else
            {
                Console.WriteLine("Chisloto e prosto");
            }
                    

            

        }
    }
}
