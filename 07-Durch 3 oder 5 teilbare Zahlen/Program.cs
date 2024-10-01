using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Durch_3_oder_5_teilbare_Zahlen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zahlen zwischen 1 und 30, die durch 5 und/oder ohne Rest teilbar sind:");

            string result = "";
            
            for(int i = 0; i < 31; i++)
            {
                if(i % 3 == 0|| i % 5 == 0)
                {
                    result += +i + ",";
                }

                            
            
            }
            if (result.EndsWith(","))
            {
                result = result.Remove(result.Length -1);
            }
            Console.WriteLine(result);
        }
    }
}
