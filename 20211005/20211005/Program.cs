using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211005
{
    class Program
    {
        static void Main(string[] args)
        {
            
            feladat1();
            feladat2();
            feladat3();
                Console.WriteLine("Lépjen ki! A program már nem üzemképes!");
                Console.ReadLine();
            

            
        }
        static void feladat1()
        {
            Console.WriteLine("Ez a program kiíratja a számokat 1-20 között egymás mellé.");
            int[] szamok = new int[20];
            for (int i = 0; i < 20; i++)
            {
                szamok[i] = i + 1;
            }
            for (int i = 0; i < 20; i++)
            {
                Console.Write("{0} ",szamok[i]);
            }
            Console.WriteLine("\nEnter");
            Console.ReadKey();
        }
        static void feladat2()
        {
            Console.WriteLine("Ez a program kiíratja a számokat 1-20 között egymás alá.");
            int[] szamok = new int[20];
            for (int i = 0; i < 20; i++)
            {
                szamok[i] = i + 1;
            }
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(szamok[i]);
            }
            Console.ReadKey();
        }
        static void feladat3()
        {
            Console.WriteLine("Ez a program kiíratja a számokat 15-92 között egymás mellé.");
        }
    }
}
