using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace niz_email
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Въведи email: ");
            string email = Console.ReadLine();
            int broi = email.Count();
            int znak = email.IndexOf("@");
            int predi = znak - 1;
            int sled = broi - (predi + 3);
            Console.WriteLine(predi);
            Console.WriteLine(sled);

            if (predi >= sled )
            {
                Console.WriteLine("Call her");
            }
            else
            {
                Console.WriteLine("She is not the one");
            }





        }
    }
}
