using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pripremaZaIspit2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pocetna = 1900, krajnja = 2100;

            Console.WriteLine(" Sve prijestupne godine u ovom rasponu su slijedeće: ");

            for(int i = pocetna; pocetna < krajnja; pocetna++)
            {
                if((pocetna%400==0) || (pocetna % 4 == 0)  && (pocetna % 100 != 0))
                {
                    Console.WriteLine(pocetna + " je prijestupna. ");
                }
                else
                {
                    Console.WriteLine(pocetna + " nije prijestupna ");
                }
            }
            Console.ReadKey();
        }
    }
}
