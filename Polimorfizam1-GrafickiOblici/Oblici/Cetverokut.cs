using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizam1_GrafickiOblici
{
    class Cetverokut : GrafickiOblik
    {
        public override void nacrtaj()
        {
            Console.WriteLine("Razred " + GetType() + " - Metoda: nacrtaj()");
        }
    }
}
