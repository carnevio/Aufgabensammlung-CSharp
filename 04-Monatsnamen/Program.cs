﻿using System;
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

            string[] months = new string[] { "Januar", "Februar", "März", "April", "Mai", "Juni", "August", "September", "Oktober","November", "November" };

            

            if (int.TryParse(eingabe, out int zahl))
            {
                Console.WriteLine(months[zahl - 1]); 
            }
            else
            {
                Console.WriteLine("Fehler: Bitte eine gültige Ganzzahl eingeben.");
            }
        }
    }
}
