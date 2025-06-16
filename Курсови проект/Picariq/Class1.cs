using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picariq
{
    internal class Class1
    {

        private string category;
        private int broi;
        private int number;

        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        public int Broi
        {
            get { return broi; }
            set { broi = value; }
        }
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        public void izhod1()
        {
            Console.Write($"Category: {category}, Broi: {broi}, Number: {number}");
        }

    }
}
