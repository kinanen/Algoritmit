// See https://aka.ms/new-console-template for more information
using System.Text;

double testisana = SanojenPituusKeskiarvo("Kolme miestä, myös Pertti, istuskeleepi lauteilla.");
Console.WriteLine(testisana);

double SanojenPituusKeskiarvo(string jono)
{
    double y = 0;
    double x = 0;
    string[] subs = jono.Split(' ', '.', ',');
    int[] taul = new int [subs.Length];
    for (int i = 0; i < subs.Length; i++)
    {
        taul[i] = subs[i].Length;
    }
    for(int i = 0; i<taul.Length; i++)
    {
        if(taul[i] > 0)
        {
            y = y + taul[i];
            x++;
        }
    }
    return y/x;
}
