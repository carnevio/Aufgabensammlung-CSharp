using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace _10_Durch_Quersumme_teilbare_Zahlen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zahl 1:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("Zahl 2:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Zahl, "+ "Quersumme, " +"Division");

            for (int i = number1; i <= number2; i++)
            {
                int quersumme = BerechneQuersumme(i);

                if (quersumme != 0 && i % quersumme == 0)
                {
                    double division = (double)i / quersumme;

                    Console.WriteLine(i + ", " + quersumme +", " +division);
                }
            }
    

            
            int quersumme2 = BerechneQuersumme(number2);



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
