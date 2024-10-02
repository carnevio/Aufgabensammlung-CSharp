using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Eine_diagonale_Linie_zechnen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie lang solle die Linie sein?");
            int input = Convert.ToInt32(Console.ReadLine());

            int zahl = 0;


            for (int i = 0; i < input; i++)
            {

                for (int j = 0; j < input; j++)
                {
                    if (i == j)
                    {
                        Console.Write(" ");
                        
                    }
                    else
                    {
                        Console.Write("*");
                    }
                    

                    
                    
                }
                Console.Write("\n");
            }
        }
    }
}