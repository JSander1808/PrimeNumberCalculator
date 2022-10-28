using System;
using System.Diagnostics;
using System.Threading;

namespace Primzahlberechnung
{
    class Program
    {

        private static int number = 2;
        private static int maxnumber = 0;
        private static bool prim = false;
        private static int primzahl = 0;
        static void Main(string[] args)
        {
            maxnumber = Int32.Parse(Console.ReadLine());
            calculate();
            Console.ReadKey();
        }

        public static void calculate()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            while (number<=maxnumber)
            {
                number++;
                prim = true;
                for(int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        prim = false;
                        break;
                    }
                }
                if (prim)
                {
                    TimeSpan ts1 = stopwatch.Elapsed;
                    String watch1 = String.Format("{00:00}:{01:00}:{02:00}",ts1.Minutes,ts1.Seconds,ts1.Milliseconds/10);
                    Console.WriteLine(number + "     " + watch1) ;
                    primzahl++;
                }
            }
            TimeSpan ts = stopwatch.Elapsed;
            String watch = String.Format("{00:00}:{01:00}:{02:00}", ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            Console.WriteLine("Benchmark fertig nach:   " + watch + "     Primzahlen:  "+primzahl);
        }
    }
}
