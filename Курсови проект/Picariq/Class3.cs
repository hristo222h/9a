using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picariq
{
    internal class Class3
    {
        private double picaprice;
        private string nachinnaplashtane;

        public double PicaPrice
        {
            get { return picaprice; }
            set { picaprice = value; }
        }
        public string NachinNaplashtane
        {
            get { return nachinnaplashtane; }
            set { nachinnaplashtane = value; }
        }
        public void izhod3()
        {
            Console.Write($"Pica Price: {picaprice}, Nachin Naplashtane: {nachinnaplashtane}");
        }

    }
}
