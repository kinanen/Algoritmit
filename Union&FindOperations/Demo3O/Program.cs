using System;
using System.Collections.Generic;

namespace Demo3O


{


    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Alkio> lista = new List<Alkio>();
            Alkio kiuru = new Alkio() { Sana = "kiuru", Kuuluu = -1 };
            lista.Add(kiuru);

            Alkio rastas = new Alkio() { Sana = "rastas", Kuuluu = -1 };
            lista.Add(rastas);

            Alkio lokki = new Alkio() { Sana = "lokki", Kuuluu = -1 };
            lista.Add(lokki);

            Alkio sorsa = new Alkio() { Sana = "sorsa", Kuuluu = -1 };
            lista.Add(sorsa);

            Alkio varis = new Alkio() { Sana = "varis", Kuuluu = -1 };
            lista.Add(varis);


            // Alkutilanne, tulostetaan kaikki alkiot, niiden joukko, int arvona, sekä niiden indeksi listassa.

            foreach (Alkio alkio in lista)
                Console.WriteLine(alkio.Sana +"  " + alkio.Kuuluu + " [" + lista.IndexOf(alkio) + "]");
            Union(lista, varis, sorsa);

            Alkio f = kiuru;
            int x = Find(lista, f);
            Console.WriteLine("\n" + f.Sana + " sijaitsee puussa [" + x + "]");


            Union(lista, varis, sorsa);
            Union(lista, lokki, kiuru);
            Union(lista, lokki, varis);

            Console.WriteLine("\n");
            Console.WriteLine("tehdään union operaatio pareilla, (varis, sorsa), (lokki, kiuru) ja (lokki, varis)\n");

            foreach (Alkio alkio in lista)
                Console.WriteLine( alkio.Sana + "  " + alkio.Kuuluu + " [" + lista.IndexOf(alkio) + "]");

            f = kiuru;

            x = Find(lista, f);

            Console.WriteLine("\n"+ f.Sana + " sijaitsee puussa [" + x + "]");


            f = sorsa;

            x = Find(lista, f);

            Console.WriteLine("\n" + f.Sana + " sijaitsee puussa [" + x + "]");
            Console.WriteLine("\ntehtiin operaatiot find kiuru ja find sorsa\n");

            foreach (Alkio alkio in lista)
                Console.WriteLine(alkio.Sana + "  " + alkio.Kuuluu + " [" + lista.IndexOf(alkio) + "]");
        }

        private static void Union(List<Alkio> l , Alkio a, Alkio b)
        {
            if (a.Kuuluu >= 0 || b.Kuuluu>= 0)
            {
                return;
            }

            int y = a.Kuuluu + b.Kuuluu;
            if(a.Kuuluu <= b.Kuuluu)
            {
                a.Kuuluu = y;
                b.Kuuluu = l.IndexOf(a);
            }
            else
            {
                b.Kuuluu = y;
                a.Kuuluu = l.IndexOf(b);            }
        }


        private static int Find(List<Alkio> l, Alkio a)
        {
            if (a.Kuuluu < 0)
            {
                return l.IndexOf(a);
            }

            int x = a.Kuuluu;
            int y = l.IndexOf(a);

            while (l[x].Kuuluu >= 0)
            {
                x = l[x].Kuuluu;
            }

            while (l[y].Kuuluu >= 0)
            {
                int z = y;
                y = l[y].Kuuluu;
                l[z].Kuuluu = x;
            }


            return x;

            }


    }

    public class Alkio
    {
        public string Sana { get; set; }
        public int Kuuluu { get; set; }
    }



}
