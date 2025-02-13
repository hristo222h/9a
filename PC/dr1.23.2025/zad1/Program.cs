using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            
           
            Console.Write("Въведи числа, разделени с интервал: ");
            string chisla = Console.ReadLine();
            int[] numbers = chisla.Split(' ').Select(int.Parse).ToArray();
            int minElement = numbers.Min();
            int maxElement = numbers.Max();
            int sum = numbers.Sum();
            double average = numbers.Average();

            Console.WriteLine($"Най-малкият елемент е: {minElement}");
            Console.WriteLine($"Най-големият елемент е: {maxElement}");
            Console.WriteLine($"Сумата на елементите е: {sum}");
            Console.WriteLine($"Средната стойност на елементите е: {average}");

        }
    }
}
