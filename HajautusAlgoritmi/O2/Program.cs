using System;

namespace O2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] t = new int[50];
            int[] arr = { 15, 20, 31, 16, 17, 11, 21, 71, 1, 31, 300, 1100, 7000,79, 99, 97 , 88 ,79 ,76};

            foreach (int i in arr)
                Hajautus(i, t);

            //tulostaa hajautustaulukon sen luomisen jälkeen
            foreach (int i in t)
                Console.WriteLine(i);

            int etsittava = 7000;
            int indeksi = Etsi(etsittava, t);

            Console.WriteLine("\r\netsittavan luvun " + etsittava + " indeksi on " + indeksi +"\n");

            int poistettava = 79;

            Poista(poistettava, t);

            foreach (int i in t)
                Console.WriteLine(i);
        }

        static void Hajautus(int a, int[] t)
        {
            int i = a % 47;
            if (t[i] <= 0 || t[i] == a)
            {
                t[i] = a;
            }
            else
            {
                for (int j = 1; j <= t.Length; j++){
                    int y = (j + j * (a % 47))%50;
                    if (t[y] <= 0 || t[y] == a)
                    {
                        t[y] = a;
                        break;
                    }
                }
                
            }


        }

        static void Poista(int a, int [] t)
        {
            int i = Etsi(a, t);
            if (i == -1) { return; }
            else
            {
                t[i] = -1;
            }
            

        }

        static int Etsi(int a, int[] t)
        {
            int i = a % 47;

            if (t[i] == 0)
            {
                return -1;
            }
            else if (t[i] == a)
            {
                return i;
            }
            else
            {
                for (int j = 1; j <= t.Length; j++)
                {
                    int y = (j + j * (a % 47)) % 50;
                    if (t[y] == a)
                    {
                        return y;
                    }

                    else if(t[y] == 0 )
                    {
                        return -1 ;
                    }
                }

                return -1;

            }
            

        }



    }
}

