using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Rechner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Make your calculation (or press Q to quit)");
            string input = Console.ReadLine();

            int num1 = GetNums(input, 0);
            int num2 = GetNums(input, 1);
            char operat = Operator(input);
            int result1 = Calculate(num1, num2, operat);

            Console.WriteLine(result1);


        }

        static int Calculate(int num1, int num2, char op)
        {
            
            int result = 0;

            switch (op)
            {
                case '*':
                    return result=(num1 * num2);
                    

                case '/':
                    return result = num1 / num2;
                    

                case '+':
                    return result = (num1 + num2);
                    

                case '-':
                    return result = (num1 - num2);
                    

                default:
                    return 0;

            }
        }
        static int GetNums(string text, int num)
        {
            int res = int.Parse(text.Split(Operator(text))[num]);

            return res;


        }
        static char Operator(string input)
        {
            if (input.Contains('*'))
            {
                return '*';
            }
            else if (input.Contains('/'))
            {
                return '/';
            }
            else if (input.Contains('+'))
            {
                return '+';
            }
            else if (input.Contains('-'))
            {
                return '-';
            }
            else
            {
                return 'x';
            }
        }
    }
}
