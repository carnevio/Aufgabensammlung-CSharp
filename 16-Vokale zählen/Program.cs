using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Vokale_zählen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gib einen Satz ein");
            string satz = Console.ReadLine();

            int vowel_countA = 0; char A = 'A';
            int vowel_countE = 0; char E = 'E';
            int vowel_countI = 0; char I = 'I';
            int vowel_countO = 0; char O = 'O';
            int vowel_countU = 0; char U = 'U';
            int vowel_countÄ = 0; char Ä = 'Ä';
            int vowel_countÖ = 0; char Ö = 'Ö';
            int vowel_countÜ = 0; char Ü = 'Ü';
            int vowel_counta = 0; char a = 'a';
            int vowel_counte = 0; char e = 'e';
            int vowel_counti = 0; char i = 'i';
            int vowel_counto = 0; char o = 'o';
            int vowel_countu = 0; char u = 'u';
            int vowel_countä = 0; char ä = 'ä';
            int vowel_countö = 0; char ö = 'ö';
            int vowel_countü = 0; char ü = 'ü';
            int vowel_count = 0;


            for (int l = 0; l < satz.Length; l++)
            {
                if (satz[l] == 'a' || satz[l] == 'e' || satz[l] == 'i' || satz[l] == 'o' || satz[l] == 'u' || satz[l] == 'A' || satz[l] == 'E' || satz[l] == 'I' || satz[l] == 'O' || satz[l] == 'U')
                {
                    vowel_count++;
                }
                    if (satz[l] == 'a')
                    {
                        vowel_counta++;

                    }
                    if (satz[l] == 'e')
                    {
                        vowel_counte++;

                    }
                    if (satz[l] == 'i')
                    {
                        vowel_counti++;

                    }

                    if (satz[l] == 'o')
                    {
                        vowel_counto++;

                    }
                    if (satz[l] == 'u')
                    {
                        vowel_countu++;

                    }
                    if (satz[l] == 'ä')
                    {
                        vowel_countä++;

                    }
                    if (satz[l] == 'ö')
                    {
                        vowel_countö++;

                    }
                    if (satz[l] == 'ü')
                    {
                        vowel_countü++;

                    }
                    if (satz[l] == 'A')
                    {
                        vowel_countA++;

                    }
                    if (satz[l] == 'E')
                    {
                        vowel_countE++;

                    }
                    if (satz[l] == 'I')
                    {
                        vowel_countI++;

                    }
                    if (satz[l] == 'O')
                    {
                        vowel_countO++;

                    }
                    if (satz[l] == 'U')
                    {
                        vowel_countU++;

                    }
                    if (satz[l] == 'Ö')
                    {
                        vowel_countÖ++;

                    }
                    if (satz[l] == 'Ä')
                    {
                        vowel_countÄ++;

                    }
                    if (satz[l] == 'Ü')
                    {
                        vowel_countÜ++;

                    }



                }


            Console.WriteLine("Der Satz hat " + vowel_count + " Vokale.");

                if (vowel_countA > 0)
                {

                    Console.WriteLine("Der Buchstabe :" + A + " kommt " + vowel_countA + "mal vor");
                }

                if (vowel_countE > 0)
                {

                    Console.WriteLine("Der Buchstabe :" + E + " kommt " + vowel_countE + "mal vor");
                }

                if (vowel_countI > 0)
                {

                    Console.WriteLine("Der Buchstabe :" + I + " kommt " + vowel_countI + "mal vor");
                }
                if (vowel_countO > 0)
                {

                    Console.WriteLine("Der Buchstabe :" + O + " kommt " + vowel_countO + "mal vor");
                }
                if (vowel_countÄ > 0)
                {

                    Console.WriteLine("Der Buchstabe :" + Ä + " kommt " + vowel_countÄ + "mal vor");
                }
                if (vowel_countÖ > 0)
                {

                    Console.WriteLine("Der Buchstabe :" + Ö + " kommt " + vowel_countÖ + "mal vor");
                }
                if (vowel_countÜ > 0)
                {

                    Console.WriteLine("Der Buchstabe :" + Ü + " kommt " + vowel_countÜ + "mal vor");
                }
                if (vowel_counta > 0)
                {

                    Console.WriteLine("Der Buchstabe :" + a + " kommt " + vowel_counta + "mal vor");
                }
                if (vowel_counte > 0)
                {

                    Console.WriteLine("Der Buchstabe :" + e + " kommt " + vowel_counte + "mal vor");
                }
                if (vowel_counti > 0)
                {

                    Console.WriteLine("Der Buchstabe :" + i + " kommt " + vowel_counti + "mal vor");
                }
                if (vowel_counto > 0)
                {

                    Console.WriteLine("Der Buchstabe :" + o + " kommt " + vowel_counto + "mal vor");
                }
                if (vowel_countu > 0)
                {

                    Console.WriteLine("Der Buchstabe :" + u + " kommt " + vowel_countu + "mal vor");
                }
                if (vowel_countä > 0)
                {

                    Console.WriteLine("Der Buchstabe :" + ä + " kommt " + vowel_countä + "mal vor");
                }
                if (vowel_countö > 0)
                {

                    Console.WriteLine("Der Buchstabe :" + ö + " kommt " + vowel_countö + "mal vor");
                }
                if (vowel_countü > 0)
                {

                    Console.WriteLine("Der Buchstabe :" + ü + " kommt " + vowel_countü + "mal vor");
                }

            }
        }
    }

