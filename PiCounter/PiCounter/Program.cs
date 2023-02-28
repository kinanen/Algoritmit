using System;

namespace O5
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = 500;
            double e = r * r;
            double a = 500;
            double b = 500;
            double kuuluu = 0;
            int n = 100000000;


            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                int c = rnd.Next(0, 1000);
                double x = rnd.NextDouble();
                x = x + c;
                int d = rnd.Next(0, 1000);
                double y = rnd.NextDouble();
                y = y + d;

                double z = a - x;
                z = z * z;
                double t = b - y;
                t = t * t;
                z = z + t;
                if (z <= e)
                {
                    kuuluu++;
                }


            }


            double pii = kuuluu * 4 / n;
            double ero = Math.PI - pii;

            Console.WriteLine(" omalla toteutuksella pii on " + pii + " ja sen erotus math kirjaston arvoon " + ero);
        }
    
    }
}

