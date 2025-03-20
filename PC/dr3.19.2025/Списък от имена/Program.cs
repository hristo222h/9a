using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Списък_от_имена
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();

            List<string> imena = new List<string>(n.Split(' '));
            Console.WriteLine(string.Join("; ", imena) + ";");

        }
    }
}
