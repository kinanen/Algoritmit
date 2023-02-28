using System;
namespace Alg2O4
{
	public class KirjaintenMaara
	{
		public KirjaintenMaara()
		{
            int sMaara = LaskeKirjaimet("rrR", 'R');


            int kMaara = LaskeKirjaimet("RisarRSIIarisirisiriRR", 'r');

            int LaskeKirjaimet(string s, char m)
            {
                m = Char.ToLower(m);
                int y = 0;
                char[] taul = s.ToCharArray();

                foreach (char x in taul)
                {
                    char z = Char.ToLower(x);

                    if (z == m)
                    {
                        y = y + 1;
                    }
                }

                return y;

            }

            Console.WriteLine(sMaara);


        }
    }
}

