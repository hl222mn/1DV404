using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV404_RaknaSiffror
{
    class Program
    {
        static void Main(string[] args)
        {
            //läs in heltal från tangentbordet
            Console.Write("Skriv in ett heltal: ");
            int number = int.Parse(Console.ReadLine());

            // tolka antal nollor, antal udda siffror, antal jämna siffror 
            int zero = 0;
            int odd = 0;
            int even = 0;
            string digits = Convert.ToString(number); //http://stackoverflow.com/questions/3081916/convert-int-to-string

            if (number > 0)
            {
                foreach (char c in digits)
                {
                    if (c == 0)
                    {
                        zero++;
                    }
                    else if (c % 2 != 0)
                    {
                        odd++;
                    }
                    else
                    {
                        even++;
                    }
                }
            }
            else
            {
                throw new ArgumentException("Du måste mata in ett positivt heltal.");
            }

            // skriv ut antalet av resp siffra

            Console.WriteLine("Antalet nollor är: {0}", zero);
            Console.WriteLine("Antalet udda siffror är {0}", odd);
            Console.WriteLine("Antalet jämna siffror är {0}", even);
        }
    }
}
