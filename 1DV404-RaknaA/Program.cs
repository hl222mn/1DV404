using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV404_RaknaA
{
    class Program
    {
        static void Main(string[] args)
        {
            //läs in textrad

            //char lettera = a;
            //char letterA = A;

            Console.WriteLine("Skriv in en mening:");
            string input= Console.ReadLine();
            
            //räkna ut antal a resp A i meningen 
            // http://stackoverflow.com/questions/10391481/number-of-occurrences-of-a-character-in-a-string
            int counta = 0;
            foreach (char a in input)
            {
                if (a == 'a') counta++;
            }
            int countA = 0;
            foreach (char A in input)
            {
                if (A == 'A') countA++;
            }

            //skriv ut hur många a och A det finns 
            //presentera reultatet
            Console.WriteLine("Meningen: {0} innehåller", input);
            Console.WriteLine("Antal a är: {0}", counta);
            Console.WriteLine("Antal A är: {0}", countA);

           
        }
    }
}
