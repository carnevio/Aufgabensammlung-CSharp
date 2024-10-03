using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Monatsnamen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Gib eine Zahl von 1-12 ein:");
            string eingabe = Console.ReadLine();
            
            string[] months = new string[] { "Januar", "Februar", "März", "April", "Mai", "Juni","Juli",  "August", "September", "Oktober","November", "November" };
            
            if (int.TryParse(eingabe, out int zahl))
            {
                if (zahl > 0 && zahl < 13) 
                {
                    Console.WriteLine(months[zahl - 1]); 
                }
                else 
                {
                    Console.WriteLine("Fehler: Bitte eine Ganzzahl zwischen 1 und 12 eingeben.");
                }
            }
            else
            {
                Console.WriteLine("Fehler: Bitte eine gültige Ganzzahl eingeben.");
            }
        }
    }
}
