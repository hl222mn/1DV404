using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV404_NastStorsta
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            // läs in tio heltal
            int input = 0;
            int highest = 0;
            int almostHighest = 0;

            // Hitta nästa största talet och...
            for (int count = 1; count < 11; count++) //ÄNdRA till 11
            try
            {
                Console.WriteLine("Skriv in heltal {0} av 10", count);
                input = int.Parse(Console.ReadLine());

                {
                    if (count == 1)
                    {
                        highest = input;
                    }
                    
                    else if (input > highest)
                    {
                        almostHighest = highest;
                        highest = input;                
                    }
                    else
                    {
                        if (input > almostHighest)
                        {
                            almostHighest = input;
                        }
                    }
                }
            }
            catch
            {
                Console.WriteLine("Felaktig inmatning - du måste mata in heltal");
            }

            // skriv ut det
            //Console.WriteLine("Högsta talet är: {0}", highest);
            Console.WriteLine("Näst högsta talet är: {0}", almostHighest);

            //LÄtt att ändra inmatade tal?? 
        }
    }
}
