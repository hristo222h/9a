using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace dr_1._28._2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Без тези два реда изкарва на конзолата въпросителни
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8; 

            Console.Write("Как се казваш ");
            string a = Console.ReadLine();
            string[] b = a.Split(' ');
            Console.Write("Колко оценки имаш ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Оценка[{0}]  = ", i + 1, arr[i]);
                arr[i] = int.Parse(Console.ReadLine());
                sum += arr[i];
            }
            Console.WriteLine(a);
            Console.WriteLine("Твоите оценки са:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Оценка {i + 1}: {arr[i]}");
            }
            double average = (double)sum / n;
            Console.WriteLine("Средната оценка е: " + average);

        }
    }
}
