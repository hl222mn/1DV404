using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV404_Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            //läs in inmatning från tangentbord enbart små bokstäver
            Console.WriteLine("Mata in ett ord för att se om det är ett palindrom");
            string input = Console.ReadLine();

            int upper = 0;
             //testa om det är stora bokstäver http://www.java2s.com/Tutorials/CSharp/Data_Types/char/Check_if_a_character_is_Lower_case_in_CSharp.htm
           
                    int i;
                    for (i = 0; i < input.Length; i++)
                    {
                        if (Char.IsUpper(input[i]))
                        {
                            upper++;
                        }
                    }
                    
                    if (upper == 0)
                    {
                        // testa om det är ett palindrom
                        if (input.SequenceEqual(input.Reverse()))
                        {
                            Console.WriteLine("Ditt ord {0} är ett palindrom - dvs likadant baklänges", input);
                        }
                        else
                        {
                            Console.WriteLine("Nej ditt ord är inget palindrom!");
                        }
                    }         
                else
                {
                    Console.WriteLine("Felaktig inmatning - Du kan bara skriva in små bokstäver");
                }
            //ge några exempel som testar funktionaliteten???
        }
    }
}
