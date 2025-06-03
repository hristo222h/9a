using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kucheshka_sreshta
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string first = null;
            Console.Write("Vuvedi ime za purvoto kuche: ");
            first = Console.ReadLine();
            Dog dog = new Dog(first);
            Dog secound = new Dog();
            Console.Write("Vuvedi vtoro ime: ");
            string secound1 = Console.ReadLine();
            secound.Name = secound1;
            Dog malkodog1 = new Dog();
            Dog[] dogs = new Dog[] { dog, secound, malkodog1 };
            foreach(Dog malkodog2 in dogs)
            {
                malkodog2.Bark();
            }

        }
    }
}
