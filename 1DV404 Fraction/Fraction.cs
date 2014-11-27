using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV404_Fraction
{ 
    public class Fraction //skapa en klass...
    {
        //T och N är heltal
        int numerator;
        int denominator;

         //Följande medlemmar
        //konstruktor skapar och init nytt bråktal
        public Fraction myFraction = new Fraction(); //http://msdn.microsoft.com/en-us/library/s53ehcz3.aspx
        {
            this.numerator = numerator;
            this.denominator = denominator;

        // om N är 0 ska felmeddelande lämnas
        if (numerator = 0)
            {
             throw new FormatException("Felaktigt värde - nämnaren kan inte vara 0 i ett bråktal");
            }
        }   
    

        //metoderna getNUmerator och getDenominator som returnerar täljaren resp nämnaren.
    public int getNumerator()
    {
        get 
        {
            return getNumerator;
        }
        set
        {
            numerator = value; 
        }
    }
    public int getDenominator()
    {
        get
        {
            return getDenominator;
        }
            set
        {
            denominator = value;
        }
    }

        //metoden isNegative som ger true om det är neg heltal

public bool isNegative()
    {
    if (getNumerator < 0 || getDenominator < 0)
        {
            return true;
        }
    else 
        {
            return false; 
        }

    }
        //met add och multiply som utför bråktalsoperation på två bråk och returnerar ett nytt (hantera 0?)
public static multiply *(Fraction a, Fraction b)
{
    return new multiply(a.numerator * b.denominator + b.numerator * a.denominator, a.denominator * b.denominator)
}

public static add +(Fraction a, Fraction b)
{
    
}



        //isEqualTo som jämför två Fraction.instanser och ser om de representerar samma bråkltal
public static bool isEqualTo()
    {
    if (getNumerator == getNumerator)
        {
        return true;
        }
    else
        {
        return false; 
        }
    }


        // toString som returnerar en strängrepresentation av bråktalet på form T/N
public string toString()
{
    return string ("{0}/{1}", getNumerator, getDenominator)
}

        //Ev fler metoder som kanske fattas???
        //LÄmpliga argument- och returtyper???
    }
}
