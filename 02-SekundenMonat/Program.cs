using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_SekundenMonat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie viele Tage hat der Monat, für den Sie die Sekundenzahl berechnen wollen?");
            string input = Console.ReadLine();

            int zahl = 0;

            if (MyTryParse(input, out zahl) == true && zahl > 27 && zahl < 32)
            {
               Console.WriteLine("Der Monat hat "+  zahl * 86400 + " Sekunden."); 
            }
            else
            {
                Console.WriteLine("Eingabefehler. Bitte geben Sie einen gültigen Wert ein.");
            }
            Console.ReadKey();
        }


        static bool MyTryParse(string s, out int n)
        {
            n = 0;

            try
            {
                n = Convert.ToInt32(s);
                return true;
            }
            catch
            {
                return false;
            }
       
        }
    }
}
