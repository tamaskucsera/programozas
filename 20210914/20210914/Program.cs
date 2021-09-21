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
            feladat1();

            Console.WriteLine("enter");
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

    }
}
