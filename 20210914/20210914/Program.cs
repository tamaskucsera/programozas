using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210914
{
    class Program
    {
        static void Main(string[] args)


        {
            //feladat1();
            //feladat2();
            feladat3();

            Console.WriteLine("Lépjen ki! A program már nem üzemképes!");
            Console.ReadLine();
        }
        static void feladat1()
        {

            Console.Write("Adj meg egy számot!");
            Double szam = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            if (szam % 2 == 0)
            {
                Console.WriteLine(" A(z) {0} szám páros", szam);
            }
            else
            {
                Console.WriteLine(" A(z) {0} szám páratlan", szam);
            }
        }
        static void feladat2()
        {
            Console.Write("Adj meg egy számot!");
            Double jel = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            int np = 0;
            if (np >= 0)
            {
                Console.WriteLine("A szám pozitív");
            }
            else
            {
                Console.WriteLine("A szám negatív vagy nulla");
            }
            Console.ReadLine();
        }
        static void feladat3()
        {
            Console.WriteLine("Add meg a kinti hőmérsékletet! (˙C)");
            Double homerseklet = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            int celsius = 0;
            if (celsius > 0)
            {
                Console.WriteLine("Jó az idő gyerekek! Irány az utca!!!! ;)");
            }
            else
            {
                Console.WriteLine("Fagypont alá csökkent a hőmérséklet!");
            }
        }
    }
}


