using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._31._2025
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //var n = int.Parse(Console.ReadLine());
            //int i = 1;
            //do
            //{
            //    Console.WriteLine(i);
            //    i += 3;

            //}
            //while (i < n);


            var num = int.Parse(Console.ReadLine());
            var i = num;
            do
            {
                Console.WriteLine(num);
                num = num / 4;
            }
            while (i <= 1);


            //var num = int.Parse(Console.ReadLine());
            //var i = 0;
            //while (i <= num)
            //{

            //    Console.WriteLine(num);
            //    num = num * 2 * 2;
            //}


        }
    }
}
