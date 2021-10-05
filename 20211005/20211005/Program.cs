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

            //feladat1();
            //feladat2();
            //feladat3();
            //feladat4();
            //feladat5();
            //feladat6();
            //feladat7();
            //feladat8();
            feladat9();


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
            int i = 15;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 93);
        }
        static void feladat4()
        {
            Console.WriteLine("Ez a program kiírja 1-30 között a páros számokat.");
            int parostalan = 0;
                do
            {
                if (parostalan % 2 == 0)
                {
                    Console.Write("{0} ",parostalan);
                }
                parostalan++;
            }
            while (parostalan < 31);
            Console.WriteLine();

            for (int i = 0; i < 31; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.WriteLine();
        }
        static void feladat5()
        {
            Console.WriteLine("Adj meg egy +E számot és kiírjuk az előtte lévő +E számokat");
            int szam = int.Parse(Console.ReadLine());
            for (int otos = 0; otos < szam; otos++)
            {  
                    Console.Write("{0} ", otos);
            }
            Console.WriteLine();

        }
        static void feladat6()
        {
            Console.WriteLine("Kiírjuk az első 15 szám négzetét");
            for (int szam = 1; szam < 16; szam++)
            {
                Console.WriteLine("A(z) {0} négyzete: {1}",szam, Math.Pow(szam, 2));
            }
            Console.WriteLine();
        }
        static void feladat7()
        {
            Console.WriteLine("Ez a program kiírja a 4-gyel osztható számokat 100-400 között.");
            int oszthatosag = 100;
            do
            {
                if (oszthatosag % 4 == 0)
                {
                    Console.Write("{0} ", oszthatosag);
                }
                oszthatosag++;
            }
            while (oszthatosag < 401);
            Console.WriteLine();
        }
        static void feladat8()
        {
            Console.WriteLine("Ez a program kiírja 9-esével a 30-100 között lévő számokat.");
            int kilencesevel = 30;
            do
            {
                Console.Write("{0} ", kilencesevel);
                kilencesevel = kilencesevel + 9;
            }
            while (kilencesevel < 101);
            Console.WriteLine();
        }
        static void feladat9()
        {
            Console.WriteLine("Ez a varázslatosan szép prg kiírja 120-40 köüzött a számokat 12-esével");
            int tizenketto = 120;
            do
            {
                Console.Write("{0} ", tizenketto);
                tizenketto = tizenketto - 12;
            }
            while (tizenketto > 40);
            Console.WriteLine();
        }
    }
}
