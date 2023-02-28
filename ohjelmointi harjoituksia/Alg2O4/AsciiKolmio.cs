using System;
using System.Text;

namespace Alg2O4
{
	public class AsciiKolmio
	{
		public AsciiKolmio()
		{
            string kolmio = LuoKolmio('@', 8);

            Console.WriteLine(kolmio);




            string LuoKolmio(char m, int x)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        sb.Append(m);
                    }

                    sb.Append("\n");
                }

                string sana = sb.ToString();

                return sana;

            }



        }
    }
}

