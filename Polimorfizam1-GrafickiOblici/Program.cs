using System;
using System.Collections.Generic;

namespace Polimorfizam1_GrafickiOblici
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program pokrenut");

            /* ZADATAK: Izraditi programski kod za primjer naslijeđivanja temeljen 
             * na grafičkim oblicima. Razmotriti razloge korištenja nasljeđivanja. 
             * Iskoristiti polimorfizam i dinamičko povezivanje */

            // Polimorfizam ? Dinamičko povezivanje? 

            // 1. Korak - Izraditi razrede. Svaki razred ima metodu za iscrtavanje oblika

            // U općenitom slučaju korisnik će pomoću sučelja iscrtati proizvonjam broj
            // grafičkih objekata; ovdje se to simulira u metodi Main (ovoj) tako da 
            // se izrade strukture za pohranu podataka te se pozove iscrtavanje
            // svakog objekta.

            // Strukture za pohranu podataka 
            List<Trokut> trokuti = new List<Trokut>();
            List<Cetverokut> cetverokuti = new List<Cetverokut>();
            List<Kruznica> kruznice = new List<Kruznica>();

            // ... programski kod za dodavanje oblika pomoću korisničkog sučelja

            // Crtež kojeg je korisnik izradio se sastoji od dva trokuta,
            // dve cetverokuta i dvije kružnice
            trokuti.Add(new Trokut());  
            trokuti.Add(new Trokut());
            cetverokuti.Add(new Cetverokut());
            cetverokuti.Add(new Cetverokut());
            kruznice.Add(new Kruznica());
            kruznice.Add(new Kruznica());

            /* Mogli bi za svaki objekt pisati i ovako: */
            // Trokut t1 = new Trokut();
            // trokuti.Add(t1);
            /* Međutim gornji zapis je kraći; reference za objekte se čuvaju
             * u listama, to je dovoljno */

            // Programski kod za iscrtavanje (općenito obradu podataka)
            foreach (Trokut t in trokuti)
            {
                t.nacrtaj();
            }

            foreach(Cetverokut c in cetverokuti)
            {
                c.nacrtaj();
            }

            foreach(Kruznica k in kruznice)
            {
                k.nacrtaj();
            }

            // Program je završen; prezentiran, korisnici zadovoljni! 
            // Međutim, žele još novih mogućnosti za crtanje, 
            // elipse, strelice, zvjezdice. Bilo bi zgodno dodati i
            // opraciju brisanja, pomaka nakon iscrtavanja, još novih mogućnosti!

            // Što je potrebno učiniti da se doda novi grafički oblik? Novih 10? Novih 20?
            // Što je potrebno učiniti da se dodaju nove operacije/funkcije? 


        }
    }
}
