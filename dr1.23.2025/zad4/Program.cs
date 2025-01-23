using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Въведи число ");
            string chisla = Console.ReadLine();
            int[] number = Array.ConvertAll(chisla.Split(' '), int.Parse);
            while (number.Length > 1)
            {

                int[] newNumber = new int[number.Length - 1];
                for (int i = 0; i < number.Length - 1; i++)
                {
                    newNumber[i] = number[i] + number[i + 1];
                }
                number = newNumber;
            }
            Console.WriteLine($"Резулататът е: {number[0]}");

        }
    }
}
