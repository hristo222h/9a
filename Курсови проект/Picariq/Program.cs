using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picariq
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Class4> poruchka = new List<Class4>();
            Console.Write("Kolko poruchki shte vuvejdash? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Class4 class4 = new Class4();
                class4.class1 = new Class1();
                class4.class2 = new Class2();
                class4.class3 = new Class3();

                Console.Write("Vuvedi Category: ");
                class4.class1.Category = Console.ReadLine();
                Console.Write("Vuvedi Broi Hora: ");
                class4.class1.Broi = int.Parse(Console.ReadLine());
                Console.Write("Vuvedi Number Table: ");
                class4.class1.Number = int.Parse(Console.ReadLine());

                Console.Write("Vuvedi Vid Pica: ");
                class4.class2.Vidpica = Console.ReadLine();
                Console.Write("Vuvedi Broi Pici: ");
                class4.class2.Broipici = int.Parse(Console.ReadLine());
                Console.Write("Vuvedi Razmer Pica: ");
                class4.class2.Razmerpica = Console.ReadLine();

                Console.Write("Vuvedi Pica Price: ");
                class4.class3.PicaPrice = double.Parse(Console.ReadLine());
                Console.Write("Vuvedi Nachin Naplashtane: ");
                class4.class3.NachinNaplashtane = Console.ReadLine();

                poruchka.Add(class4);
            }
            Console.WriteLine("Vsichki poruchki: ");
            foreach (var item in poruchka)
            {
                item.class1.izhod1();
                Console.Write(", ");
                item.class2.izhod2();
                Console.Write(", ");
                item.class3.izhod3();
                Console.WriteLine($", Smetka: {item.smetkapica()}");
            }
            Console.WriteLine("Obshta stoinost na vsqka poruchka");
            foreach (var item in poruchka)
            {
                Console.WriteLine($"Masa {item.class1.Number}: {item.smetkapica()}lv.");
                Console.WriteLine("Malki pici: ");
                foreach (Class4 p in poruchka)
                {
                    if (p.class2.Razmerpica == "malka")
                    {
                        Console.WriteLine($"Broi pici: {p.class2.Broipici}, Vid pici: {p.class2.Vidpica}, Masa: {p.class1.Number}");
                    }
                }
            }
            Console.WriteLine("Golemi pici: ");
            foreach (Class4 p in poruchka)
            {
                if (p.class2.Razmerpica == "golqma")
                {
                    Console.WriteLine($"Broi hora: {p.class1.Broi}, Masa: {p.class1.Number}");
                }
            }
            Console.WriteLine("Poruchki s nomer nad 5: ");
            foreach (Class4 p in poruchka)
            {
                if (p.class1.Number >= 5)
                {
                    Console.WriteLine($"Masa: {p.class1.Number}, Smetka: {p.smetkapica()}lv");
                }
            }
            Console.WriteLine("Sortirani poruchki po cena: ");
            for (int i = 0; i < poruchka.Count; i++)
            {
                for (int j = i + 1; j < poruchka.Count; j++)
                {
                    if (poruchka[i].smetkapica() > poruchka[j].smetkapica())
                    {
                        Class4 temp = poruchka[i];
                        poruchka[i] = poruchka[j];
                        poruchka[j] = temp;
                    }
                }
            }
            foreach (var item in poruchka)
            {
                Console.WriteLine($"Masa {item.class1.Number}: {item.smetkapica()}lv");
            }

        }
    }
}
