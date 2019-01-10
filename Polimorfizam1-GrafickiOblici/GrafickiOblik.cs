using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfizam1_GrafickiOblici
{
    public abstract class GrafickiOblik
    {
        public int Boja { get; set; } = 0;
        public int SirinaCrte { get; set; } = 1;

        /*
        public virtual void nacrtaj()
        {
            Console.WriteLine("Razred GrafickiOblik"
                + "- Metoda: nacrtaj()");
        }
        */

        public abstract void nacrtaj();
    }
}
