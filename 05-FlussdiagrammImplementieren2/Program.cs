using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_FlussdiagrammImplementieren2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie viele Kilometer möchtest du rennen?");
            int km = Convert.ToInt32(Console.ReadLine());

            if (km > 42)
            {
                Console.WriteLine("Das schaffst du nicht!");
            }
            else
            {
                double rounds  = km / 0.4;
                Console.WriteLine("Das sind " + rounds + " Runden. Bereit für den Lauf?");

                Console.WriteLine("Wenn Ja, dann klicke die Nummer 1, sonst die nummer 2.");

                int ready = Convert.ToInt32(Console.ReadLine());

                if (ready == 1) 
                {
                    int i = 1;

                    while (i <= rounds)
                    {
                        Console.WriteLine("Du laäufst die Runde " + i);
                        i++;
                    }
                    Console.WriteLine("Du hast es geschaft");
                }

              
            }
        }
    }
}
