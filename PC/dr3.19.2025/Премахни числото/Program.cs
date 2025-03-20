using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Премахни_числото
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

           
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int number = nums[nums.Count - 1];

            while (nums.Contains(number))
            {
                nums.Remove(number);
            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
