using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nz
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string[] arr = { "Христомир", "Христов", "25", "11.03" };
            
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr[1]);
            Console.WriteLine(arr[2]);
            Console.WriteLine(arr[3]);

            Console.Write(arr[0] + "-");
            Console.Write(arr[1] + "-");
            Console.Write(arr[3] + "-");


            

        }
    }
}
