using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picariq
{
    internal class Class2
    {
        private string vidpica;
        private int broipici;
        private string razmerpica;

        public string Vidpica
        {
            get { return vidpica; }
            set { vidpica = value; }
        }
        public int Broipici
        {
            get { return broipici; }
            set { broipici = value; }
        }
        public string Razmerpica
        {
            get { return razmerpica; }
            set { razmerpica = value; }
        }
        public void izhod2()
        {
            Console.Write($"Vid Pica: {vidpica}, Broi Pici: {broipici}, Razmer Pica: {razmerpica}");
        }

    }
}
