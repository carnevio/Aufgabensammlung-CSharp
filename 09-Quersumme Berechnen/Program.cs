using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Quersumme_Berechnen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Bitte eine Zahl eingeben:");
            int zahl = int.Parse(Console.ReadLine());

            int quersumme = BerechneQuersumme(zahl);

            Console.WriteLine("Die Quersumme von " + zahl + " ist: " + quersumme);
        }
        static int BerechneQuersumme(int zahl)
        {
            int sum = 0;

            while (true)
            {


                if (zahl != 0)
                {
                    sum = sum + (zahl % 10);
                    zahl = zahl / 10;
                }

                else
                {
                    return sum;
                    break;
                }

            }
        }
    }
}
