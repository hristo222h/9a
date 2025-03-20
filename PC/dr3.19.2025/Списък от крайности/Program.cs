using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Списък_от_крайности
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //napravena s pomosht ot ai ne pomnq da sme vzimali ConvertAll i bez nego davashe kato reshenie
            //neshto koeto eptem ne sme go vzeli

            List<int> nums = new List<int>(Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse));
            List<int> result = new List<int>();

            int min = nums[0];
            foreach (int num in nums)
            {
                if (num < min)
                {
                    min = num;
                }
            }

            int max = nums[0];
            foreach (int num in nums)
            {
                if (num > max)
                {
                    max = num;
                }
            }

            foreach (int num in nums)
            {
                if (num == min || num == max)
                {
                    result.Add(num);
                }
            }

            Console.WriteLine(string.Join(" ", result));

        }
    }
}
