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

            // Struktura za pohranu podataka 
            List<GrafickiOblik> grafickiOblici = new List<GrafickiOblik>();

            // ... programski kod za dodavanje oblika pomoću korisničkog sučelja

            // Crtež kojeg je korisnik izradio se sastoji od dva trokuta,
            // dve cetverokuta i dvije kružnice

            grafickiOblici.Add(new Trokut());
            grafickiOblici.Add(new Trokut());
            grafickiOblici.Add(new Cetverokut());
            grafickiOblici.Add(new Cetverokut());
            grafickiOblici.Add(new Kruznica());
            grafickiOblici.Add(new Kruznica());

            // Programski kod za iscrtavanje (općenito obradu podataka)
            foreach (GrafickiOblik go in grafickiOblici)
            {
                go.nacrtaj();
            }

            // Program je završen; prezentiran, korisnici zadovoljni! 
            // Međutim, žele još novih mogućnosti za crtanje, 
            // elipse, strelice, zvjezdice. Bilo bi zgodno dodati i
            // opraciju brisanja, pomaka nakon iscrtavanja, još novih mogućnosti!

            // Što je potrebno učiniti da se doda novi grafički oblik? Novih 10? Novih 20?
            // Što je potrebno učiniti da se dodaju nove operacije/funkcije? 

            Console.WriteLine();
            Console.WriteLine();

            GrafickiOblik go1 = new Kruznica();
            go1.nacrtaj();

            int vrijednostKojuUnosiKorisnik = 100;

            // kojeg je tipa go2 tijekom prevođenja?
            // kojeg je tipa go2 tijekom izvođenja?
            GrafickiOblik go2;
            if (vrijednostKojuUnosiKorisnik < 50)
            {
                go2 = new Kruznica();
            } else
            {
                go2 = new Trokut();
            }
            go2.nacrtaj();

            GrafickiOblik go3 = new Trokut();
            go3.nacrtaj();








        }
    }
}
