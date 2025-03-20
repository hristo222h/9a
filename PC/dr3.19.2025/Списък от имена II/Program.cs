using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Списък_от_имена_II
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            
            string n = Console.ReadLine();
            List<string> imena = n.Split(',').ToList();


            foreach (var name in imena)
            {
                var parts = name.Split(' ');
                string name1 = parts[0];
                string name2 = parts[1];
                Console.Write(name2 + " ");
                Console.WriteLine(name1 + " ");

            }

        }
    }
}
