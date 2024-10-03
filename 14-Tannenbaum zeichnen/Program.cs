using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Tannenbaum_zeichnen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Breite des Stammes?");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.Write("Höhe des Stammes?");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.Write("Höhe der Krone?");
            int heightcrown = Convert.ToInt32(Console.ReadLine());

            int WertKrone = 1;
            int number = 0;
            int number1 = 3;
            int zusatz = 0;

            //Krone
            for (int e = 2; e <= heightcrown; e++)
            {

                Console.Write(' ');
                for (int l = 0; l <= heightcrown-number1; l++)
                {
                    Console.Write(" ");
                }
                number1++;

                if (number == 0)
                {
                    for (int d = 0; d <= 0; d++)
                    {
                        Console.WriteLine("*");


                    }
                }
                else
                {
                    for (int t = 1; t <= WertKrone; t++)
                    {
                        Console.Write("*");
                        

                    }
                    Console.WriteLine(" ");
                }


                number++;
                WertKrone++;
                WertKrone++;
                
                
                
            }

            //Stamme

            for (int e = 2; e <= (heightcrown * 2); e++)
            {
                Console.Write("*");
                
            }
            Console.WriteLine(" ");

            int middle = heightcrown - (width / 2)-1;
            for (int j = 0; j < height; j++)
            {
                
                for (int l = 0; l < middle; l++)
                {
                    Console.Write(" ");
                }
                for (int i = 0; i < width; i++)
                {

                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            

        }
    }
}
