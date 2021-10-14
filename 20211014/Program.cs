using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211014
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Köszöntelek a 2021.10.14-én alkotott varázslatos programban.");
            Console.WriteLine();

            feladat14();
            feladat15();
            feladat16();
            feladat17();

            Console.WriteLine("bye");
            Console.ReadLine();
        }
        static void feladat14()
        {
            Console.WriteLine("Írasd ki a 7-es szorzótábla első 25 eleméből azokat, amik 4-gyel oszthatók.");
            for (int i = 1; i < 26; i++)
            {
                if (7*i %4 == 0)
                {
                    Console.Write("{0} ",7*i);
                }
            }
            Console.WriteLine();
        }
        static void feladat15()
        {
            for (int i = 1; i < 145; i++)
            {
                if (144/i %i == 0)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.WriteLine();
        }
        static void feladat16()
        {
            Console.WriteLine(" Írj programot, mely beolvas egy pozitív egész számot, és kiírja az osztóit! ");
            Double szam = Convert.ToDouble(Console.ReadLine());
            for (int oszt = 1; oszt < szam; oszt++)
            {
                if (szam/oszt %oszt ==0)
                {
                    Console.Write("{0} ",oszt);
                }
            }
            Console.WriteLine();
        }
        static void feladat17()
        {
            Console.WriteLine(" Írj programot, mely beolvas egy pozitív egész számot, és kiírja az osztóinak az összegét! ");
            Double szam = Convert.ToDouble(Console.ReadLine());
            for (int oszt = 1; oszt < szam; oszt++)
            {
                if (szam / oszt % oszt == 0)
                {
                    Console.Write("{0} ", oszt);
                }
            }
            Console.WriteLine();
        }
    }
}
