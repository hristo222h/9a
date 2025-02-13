using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Въведи числа, разделени с интервал: ");
            string chisla = Console.ReadLine();
            int[] numbers = Array.ConvertAll(chisla.Split(' '), int.Parse);
            Array.Sort(numbers);

            int maxFrequency = 1;
            int currentFrequency = 1;
            int mostFrequentNumber = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentFrequency++;
                }
                else
                {
                    currentFrequency = 1;
                }
                if (currentFrequency > maxFrequency)
                {
                    maxFrequency = currentFrequency;
                    mostFrequentNumber = numbers[i];
                }

                    
            }
            Console.WriteLine($"Наѝ-често срещано число е:{mostFrequentNumber}");
        }
    }
}
    

