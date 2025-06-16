using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klas
{
    internal class Product
    {

        public string Name { get; set; }
        public int Broi { get; set; }
        public double Cena { get; set; }
        public double ProdajnaCena { get; set; }



        public Product(string name, int broi, double cena, double prodajnaCena)
        {

            Name = name;
            Broi = broi;
            Cena = cena;
            ProdajnaCena = prodajnaCena;

        }

        public double Pechalba
        {
            get { return ProdajnaCena - Cena; }
        }


    }
}
