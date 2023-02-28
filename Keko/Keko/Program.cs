using System;

namespace Algoritmit2
{
    class Program
    {


        public static void Main(string[] args)
        {
            int taulukonPituus = int.Parse(Console.ReadLine());

            int[] t = SatunnaisTalukko(taulukonPituus + 1);

            TeeKeko(t);

            for (int i = 0; i < t.Length; i++)
            { Console.WriteLine(t[i]); }


            OhjelmointiTeht(t);

            for (int i = 0; i < t.Length; i++)
            { Console.WriteLine(t[i]); }

        }


        private static void OhjelmointiTeht(int[] t)
        {
            int n = t[0];
            for (int i = n; i > 1; i--)
            {
                int x = t[1];
                t[1] = t[i];
                t[i] = x;
                t[0]--;
                KorjaaKeko(t, 1);
            }
            t[0] = n;
        }


        public static void KorjaaKeko(int[] t, int i)
        {
            if (2 * i > t[0])
            {
                return;
            }
            int a = t[i];
            int j = 2 * i;

            while (j <= t[0])
            {
                if (j < t[0] && t[j] > t[j + 1])
                {
                    j = j + 1;
                }
                if (a <= t[j])
                {
                    break;
                }
                t[j / 2] = t[j];
                j = 2 * j;
            }
            t[j / 2] = a;

        }



        private static int TarksistaKeko(int[] t)
        {
            if (t[0] == 0)
            {
                return 0;
            }
            if (t[0] == 1)
            {
                return t[1];
            }

            for (int i = 1; i <= t[0]; i++)
            {
                while (2 * i + 1 < t[0])
                {
                    if (t[i] > t[i * 2] | t[i] > t[i * 2 + 1])
                    {
                        return t[i];
                    }
                    break;
                }
                while (2 * i < t[0])
                {
                    if (t[i] > t[i * 2] | t[i] > t[i * 2 + 1])
                    {
                        return t[i];
                    }
                    break;
                }
            }
            return t[0];
        }


        public static int[] SatunnaisTalukko(int pituus)
        {
            // palauttaa kutsutun pituisen taulukon johon on syötetty satunnaislukuja alkaen indeksistä 1,
            // indeksissä 0 on taulukon alkioiden lukumäärrä
            int[] t = new int[pituus];
            for (int i = 1; i < t.Length; i++)
            {
                Random rnd = new Random();
                t[i] = rnd.Next(20);
                t[0]++;
            }
            return t;
        }


        private static void TeeKeko(int[] t)
        {
            for (int i = t[0] / 2; i >= 1; i--)
            {
                KorjaaKeko(t, i);
            }

        }

    }

}




