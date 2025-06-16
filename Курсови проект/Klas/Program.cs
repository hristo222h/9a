using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Product> producti = new List<Product>()
            {
                new Product("Mlqko", 23, 0.80, 1.20),
                new Product("Qica", 62, 0.10, 0.25),
                new Product("Hlqb", 18, 1.10, 2.30),
                new Product("Sirene", 13, 8.00, 14.99),
                new Product("Chips", 31, 1.50, 3.99),
                new Product("Shokolad", 20, 0.89, 2.19)
            };


            Console.WriteLine("Izhod 1: ");
            foreach (var p in producti)
            {
                Console.WriteLine($"Produkt: {p.Name} Kolichestvo: {p.Broi} Cena: {p.Cena} ProdajnaCena: {p.ProdajnaCena}");
            }

            Console.WriteLine("");
            Console.WriteLine("Izhod 2: ");
            foreach (var p in producti)
            {
                Console.WriteLine($"Produkt: {p.Name}, Pechalba za edin broi: {p.Pechalba}");
            }

            Console.WriteLine("");
            Console.WriteLine("Izhod 3: ");
            if (producti.Count > 4)
            {
                var a = producti[4];
                Console.WriteLine($"Produkt: {a.Name}, Kolichestvo: {a.Broi}, Cena: {a.Cena}, ProdajnaCena: {a.ProdajnaCena}");
            }
        }
    }
}
