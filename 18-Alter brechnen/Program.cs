using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Alter_brechnen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Today;

            Console.Write("Bitte gib dein Geburtstag ein: ");
            DateTime birthday = Convert.ToDateTime(Console.ReadLine());

            TimeSpan year = birthday - today;
            Console.WriteLine("Alter in Jahren: " + (year.Days / 365));

            TimeSpan month = birthday - today;
            Console.WriteLine("Alter in Monaten: " + ((month.Days/365)* 12));

            TimeSpan week = birthday - today;
            Console.WriteLine("Alter in Wochen: " + (week.Days/7));

            TimeSpan days = birthday - today;
            Console.WriteLine("Alter in Tagen: " + days.Days);

        }
    }
}
