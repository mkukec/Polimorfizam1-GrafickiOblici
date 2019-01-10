using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfizam1_GrafickiOblici
{
    class GrafickiOblik
    {
        public int Boja { get; set; } = 0;
        public int SirinaCrte { get; set; } = 1;

        public void nacrtaj()
        {
            Console.WriteLine("Razred GrafickiOblik"
                + "- Metoda: nacrtaj()");
        }

    }
}
