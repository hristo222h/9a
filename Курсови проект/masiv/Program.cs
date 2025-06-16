using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masiv
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] names = new string[13];
            int[] kolichestvo = new int[13];
            double[] pokupna_cena = new double[13];
            double[] prodajna_cena = new double[13];
            int nachalo = 0;
            Console.Write("Vuvedi stoki (maks 13): ");
            int n = int.Parse(Console.ReadLine());
            while (n <= 13)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write("Vuvedi ime na stoka: ");
                    names[i] = Console.ReadLine();
                    Console.Write("Vuvedi kolichestvo: ");
                    kolichestvo[i] = int.Parse(Console.ReadLine());
                    Console.Write("Vuvedi pokupna cena: ");
                    pokupna_cena[i] = double.Parse(Console.ReadLine());
                    Console.Write("Vuvedi Prodajna cena: ");
                    prodajna_cena[i] = double.Parse(Console.ReadLine());
                    nachalo++;
                }
                Console.WriteLine("Izhod1:");
                Console.WriteLine("Vsichkite artikuli sa: ");
                for (int i = 0; i < nachalo; i++)
                {
                    Console.WriteLine($"Ime: {names[i]}, Kolichestvo: {kolichestvo[i]}, Pokupna cena: {pokupna_cena[i]} lv, Prodajna cena: {prodajna_cena[i]} lv");
                }

                Console.WriteLine("Izhod2:");
                Console.WriteLine("Stoki s maks pechalba: ");
                double maksPechalba = prodajna_cena[0] - pokupna_cena[0];
                int maks = 0;
                for (int i = 1; i < n; i++)
                {
                    double pechalba = prodajna_cena[i] - pokupna_cena[i];
                    if (pechalba > maksPechalba)
                    {

                        maksPechalba = pechalba;
                        maks = i;
                    }
                    Console.WriteLine("Ime: " + names[i] + " Pechalba: " + maksPechalba + "lv");
                }
                Console.WriteLine("Izhod3:");
                Console.WriteLine("Artikul s index 4: ");
                if (n > 4)
                {
                    Console.WriteLine($"Ime:{names[4]},Kolichestvo:{kolichestvo[4]},Pokupna cena:{pokupna_cena[4]} lv,Prodajna cena:{prodajna_cena[4]} lv");
                }
                else
                {
                    Console.WriteLine("Nqma artikul s index 4");
                }
                break;
            }

        }
    }
}
