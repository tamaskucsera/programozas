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
            Console.WriteLine("Adj meg egy számot!");
            int szam = Console.Read();
            szam = Int32.Parse(Console.ReadLine());
            if (szam % 2 == 0)
            {
                Console.WriteLine("Páros");
            }
            else
            {
                Console.WriteLine("Páratlan");
                
            }
        }
    }
}
