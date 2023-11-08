using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pripremaZaIspit1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            double x, y, z, hipotenuza, str1, str2;
            double sum;

            unos1:
            Console.WriteLine(" Unesite 1.stranicu pravokutnog trokuta. ");
            x = double.Parse(Console.ReadLine());

            if(x < 0)
            {
                x = 0;
                Console.WriteLine( "Ponovno unesi vrijednost 1.stranice veću od 0" );
                goto unos1;
            }
            unos2:
            Console.WriteLine(" Unesite 2.stranicu pravokutnog trokuta. ");
            y = double.Parse(Console.ReadLine());

            if (y < 0)
            {
                y = 0;
                Console.WriteLine("Ponovno unesi vrijednost 2.stranice veću od 0");
                goto unos2;
            }
            unos3:
            Console.WriteLine(" Unesite 3.stranicu pravokutnog trokuta. ");
            z = double.Parse(Console.ReadLine());

            if (z < 0)
            {
                z = 0;
                Console.WriteLine("Ponovno unesi vrijednost 3.stranice veću od 0");
                goto unos3;
            }

            if(x > y && x > z)
            {
                Console.WriteLine("x je najveća stranica odnosno hipotenuza");
                hipotenuza = x;
                str1 = y;
                str2 = z;

                sum = Math.Sqrt((y * y) + (z * z));

                if(x == sum)
                {
                    Console.WriteLine(" Stranice pravokutnog trokuta su ispravne. ");
                    
                }
                else
                {
                    Console.WriteLine(" Stranice pravokutnog trokuta su pogrešne!!!. ");
                    
                }

                
            }
            if (y > y && y > z)
            {
                Console.WriteLine("y je najveća stranica odnosno hipotenuza");
                hipotenuza = y;
                str1 = x;
                str2 = z;

                sum = Math.Sqrt((x * x) + (z * z));

                if (y == sum)
                {
                    Console.WriteLine(" Stranice pravokutnog trokuta su ispravne. ");
                  
                }
                else
                {
                    Console.WriteLine(" Stranice pravokutnog trokuta su pogrešne!!!. ");
                   
                }

                
            }
            if (z > y && z > x)
            {
                Console.WriteLine("z je najveća stranica odnosno hipotenuza");
                hipotenuza = z;
                str1 = x;
                str2 = y;

                sum = Math.Sqrt((x * x) + (y * y));

                if (z == sum)
                {
                    Console.WriteLine(" Stranice pravokutnog trokuta su ispravne. ");
                   
                }
                else
                {
                    Console.WriteLine(" Stranice pravokutnog trokuta su pogrešne!!!. ");
                    
                }
                
               
            }
            Console.ReadKey();

        }
    }
}
