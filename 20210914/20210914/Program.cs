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
            //feladat3();
            //feladat4();
            //feladat5();
            //feladat12();
            //feladat13();
            //feladat14();

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
        }
        static void feladat3()
        {
            Console.Write("Add meg a kinti hőmérsékletet! (˙C) ");
            Double homerseklet = Convert.ToDouble(Console.ReadLine());
            if (homerseklet > 0)
            {
                Console.WriteLine("Jó az idő gyerekek! Irány az utca!!!! ;)");
            }
            else if (homerseklet < 0)
            {
                Console.WriteLine("Fagypont alá csökkent a hőmérséklet!");
            }
            else
            {
                Console.WriteLine("Nulla fok van!");
            }
        }
        static void feladat4()
        {
            Console.Write("Adj meg egy számot! ");
            Double szam4= Convert.ToDouble(Console.ReadLine());
            if (40> szam4 && szam4>-30)
            {
                Console.WriteLine("Benne van az említett kategóriában");
            }
            else
            {
                Console.WriteLine("Nem van benne");
            }
           
        }
        static void feladat5()
        {
            Console.WriteLine("Adj meg egy számot!");

        }
        static void feladat12()
        {
            Console.Write("Adj meg egy hónapszámot!");
            int honap = Int32.Parse(Console.ReadLine());

            switch (honap)
            {

                case 1:
                    honap = 1;
                    Console.WriteLine("Január");
                    break;

                case 2:
                    honap = 2;
                    Console.WriteLine("Február");
                    break;

                case 3:
                    honap = 3;
                    Console.WriteLine("Március");
                    break;

                case 4:
                    honap = 4;
                    Console.WriteLine("Április");
                    break;

                case 5:
                    honap = 5;
                    Console.WriteLine("Május");
                    break;

                case 6:
                    honap = 6;
                    Console.WriteLine("Június");
                    break;

                case 7:
                    honap = 7;
                    Console.WriteLine("Július");
                    break;

                case 8:
                    honap = 8;
                    Console.WriteLine("Augusztus");
                    break;

                case 9:
                    honap = 9;
                    Console.WriteLine("Szeptember");
                    break;

                case 10:
                    honap = 10;
                    Console.WriteLine("Október");
                    break;

                case 11:
                    honap = 11;
                    Console.WriteLine("November");
                    break;

                case 12:
                    honap = 12;
                    Console.WriteLine("December");
                    break;
                default:
                    Console.WriteLine("Nem megfelelő számot adtál meg!");
                    break;

            }
        }
        static void feladat13()
        {
            Console.Write("Add meg egy hónap sorszámát, és eldöntjük, hogy melyik évszakban van! ");
            string input;
            input = Console.ReadLine();
            switch (Convert.ToInt32(input))
            {
                case 1:
                    Console.Write("Január");
                    Console.Write(" Tél ");
                    break;
                case 2:
                    Console.Write("Február");
                    Console.Write(" Tél");
                    break;
                case 3:
                    Console.Write("Március");
                    Console.Write(" Tavasz");
                    break;
                case 4:
                    Console.Write("Április");
                    Console.Write(" Tavasz ");
                    break;
                case 5:
                    Console.Write("Május");
                    Console.Write(" Tavasz ");
                    break;
                case 6:
                    Console.Write("Június");
                    Console.Write(" nyáron van");
                    break;
                case 7:
                    Console.Write("Július");
                    Console.Write(" Nyár ");
                    break;
                case 8:
                    Console.Write("Augusztus");
                    Console.Write(" Nyár ");
                    break;
                case 9:
                    Console.Write("Szeptember");
                    Console.Write(" Ősz ");
                    break;
                case 10:
                    Console.Write("Október");
                    Console.Write(" Ősz ");
                    break;
                case 11:
                    Console.Write("November");
                    Console.Write(" Ősz ");
                    break;
                case 12:
                    Console.Write("December");
                    Console.Write(" Tél ");
                    break;
                default:
                    Console.Write("Nincs ilyen sorszámú hónap!");
                    break;
            }
        }
        static void feladat14()
        {
            string input;
            do
            {
                Console.Write("Adj meg egy számot: ");
                input = Console.ReadLine();
            } while (long.Parse(input) > 2000000000);

            switch (input.Length)
            {
                case 1:
                    Console.WriteLine(" Egyjegyű.");
                    break;
                case 2:
                    Console.WriteLine(" Kétjegyű.");
                    break;
                case 3:
                    Console.WriteLine(" Háromjegyű.");
                    break;
                case 4:
                    Console.WriteLine(" Négyjegyű.");
                    break;
                case 5:
                    Console.WriteLine(" Ötjegyű.");
                    break;
                default:
                    Console.WriteLine(" Hatjegyű vagy több");
                    break;
            }
        }
    }
}


