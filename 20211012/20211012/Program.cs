using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211012
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Köszöntelek a 2021.10.12-én alkotott varázslatos programban.");

            feladat1();
            feladat2();
            feladat3();
            feladat4();

            Console.WriteLine("A: A kaland számodra véget ért...");
            Console.WriteLine("B: Kurva");
            Console.WriteLine("A: Nem csinálom ezt tovább, feladtam.");
            Console.WriteLine("B: ok.");
            Console.ReadLine();

        }
        static void feladat1()
        {
            Console.WriteLine("Ez a program kiírja a számokat -30 és 30 között ötösével");
            int ot = -30;
            do
            {
                Console.Write("{0} ", ot);
                ot = ot  +5;
            }
            while (ot < 31);
            Console.WriteLine();
        }
        static void feladat2()
        {
            Console.WriteLine("A következőkben kiírjuk a 3-as szám első 17 többszörösét");
            int tobbszor = 1;
            do
            {
                Console.Write("{0} ", 3*tobbszor);
                
                tobbszor++;
            }
            while (tobbszor <= 17);
            Console.WriteLine();
        }
        static void feladat3()
        {
            Console.WriteLine("A kettő első 16 hatványa következik");
            for (int i = 1; i < 17; i++)
            {
                Console.Write("{0} ", Math.Pow(2,i));
            }
            Console.WriteLine();
        }
        static void feladat4()
        {
            
        }
    }
}
