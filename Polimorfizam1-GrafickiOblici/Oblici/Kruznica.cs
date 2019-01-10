using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizam1_GrafickiOblici
{
    class Kruznica : GrafickiOblik
    {
        public override void nacrtaj()
        {
            Console.WriteLine("Razred " + GetType() + " - Metoda: nacrtaj()");
        }
    }
}
