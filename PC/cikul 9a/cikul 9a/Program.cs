using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cikul_9a
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Колко числа ще въвеждаш ");
            int n = int.Parse(Console.ReadLine());
            int[] b = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Въведете число: ");
                b[i] = int.Parse(Console.ReadLine());
            }

            // изход1
            Console.WriteLine("Изход 1");
            for (int i = 0; i < b.Length; i++)
            {
                Console.Write(b[i] + " - ");
            }
            Console.WriteLine();
            
            //изход2
            Console.WriteLine("Изход 2");
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] % 2 != 1)
                {
                    Console.WriteLine(b[i]);
                }
                else
                {
                }
            }
            Console.WriteLine("изход 3");
            
            //изход3
            for (int i = b.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(b[i]);
            }

            //изход4
            Console.WriteLine("изход 4");
            for (int i = 0; i < b.Length; i++)
            {
                if(b[i] > 10 && b[i] <= 20 )
                {
                    Console.WriteLine(b[i]);
                }
            }

            //изход5
            Console.WriteLine("изход 5");
            int sum = 0;
            for (int i = 0; i < b.Length; i++)
            {
                sum += b[i];
            }
            Console.WriteLine(sum);

        }
    }
}
