using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Zaheln_raten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gib eine Zahl ein, zwischen 1 und 100");
            
            int counter = 0;


            Random rnd = new Random();
            int nums = rnd.Next(0, 100);
            bool game = true;   
            while (game == true)
            {
                counter++;
                int zahl = Convert.ToInt32(Console.ReadLine());
                if (nums < zahl)
                {
                    Console.WriteLine("Zu Hoch.");
                }

                else if (nums > zahl)
                {
                    Console.WriteLine("Zu Tief.");
                }

                else if (nums == zahl)
                {
                    Console.WriteLine("Die zahl Stimmt. Du hast " + counter + " Versuche gebraucht.");
                    game = false;
                }
            }
        }

        
    }
}
