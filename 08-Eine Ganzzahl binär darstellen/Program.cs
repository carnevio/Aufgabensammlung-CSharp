using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Eine_Ganzzahl_binär_darstellen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bin = "";
            int richtig = 0;
            
            Console.Write("Gib eine Ganzzahl ein:");

            int n = Convert.ToInt32(Console.ReadLine());

            do
            {
                int rest = n % 2;

                bin = rest + bin;

                int wert = n / 2;

                n = wert;

                if (n == 0)
                {
                    Console.WriteLine(bin);
                    richtig++;

                }

            }
            while (richtig == 0);
        }
    }
}
