using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtharvaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Athu dada !!");
            Console.ReadLine();

            int x = 24;
            int y = 47;
            int z = x + y;
            Console.WriteLine("z =" + z);
            Console.ReadLine();

            decimal p = 25.7M;
            decimal q = 23.4M;
            decimal r = Math.Truncate((decimal)(p * q) /(p + q));
            Console.WriteLine("r =" + r);
            Console.ReadLine();
            for(int i=0; i <=500; i++)
            {
                int xx = i + 25;
                if (xx == 200)
                {
                    Console.WriteLine("Yahoo...");
                }
                else if (xx==250)
                {
                    Console.WriteLine("Hi...");
                }
                Console.WriteLine("xx =" + xx);
            }
            Console.ReadLine();
            int a=66;
                int k=47;
                decimal s = (a * k) / (a + k);
                Console.WriteLine("s=" + s);
                Console.ReadLine();
        }
    }
}
