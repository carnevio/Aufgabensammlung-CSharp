using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Schaltjahr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prüfen, ob es sich bei einem jahr um ein Schaltjahr handelt.");

            int year = Convert.ToInt32(Console.ReadLine());

            if (year % 4 == 0 || year % 400 == 0)
            {
                Console.WriteLine("Das Jahr " + year + "ist ein Schaltjahr.");
                
            }
            else
            {
                Console.WriteLine("Das Jahr " + year + "ist KEIN Schaltjahr.");
            }
        }
    }
}
