using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace kucheshka_sreshta
{
    internal class Dog
    {
        private string name;
        public Dog(string name)
        {
            this.name = name;
        }
        public Dog()
        {
            this.name = "Balkan";
        }
        public string Name 
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public void Bark()
        {
            Console.WriteLine("kucheto kaza bal bal i negovo ime e {0}", name);
        }
    

    }
}
