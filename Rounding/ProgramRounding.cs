using System;

namespace Rounding
{
    class ProgramRounding
    {
        static void Main(string[] args)
        {
            double a = 3.123,
                b = 12.5,
                c = 8.76,
                d = -4.3,
                e = -100.5,
                f = -9.9999;
            Console.WriteLine("\t\tCeiling\tFloor\tRound\tTruncate");
            Console.WriteLine("\t" + a + "\t" + Math.Ceiling(a) + "\t"
                                      + Math.Floor(a) + "\t"
                                      + Math.Round(a) + "\t"
                                      + Math.Truncate(a) + "\t");
            Console.WriteLine("\t" + b + "\t" + Math.Ceiling(b) + "\t"
                                      + Math.Floor(b) + "\t"
                                      + Math.Round(b) + "\t"
                                      + Math.Truncate(b) + "\t");
            Console.WriteLine("\t" + c + "\t" + Math.Ceiling(c) + "\t"
                                      + Math.Floor(c) + "\t"
                                      + Math.Round(c) + "\t"
                                      + Math.Truncate(c) + "\t");
            Console.WriteLine("\t" + d + "\t" + Math.Ceiling(d) + "\t"
                                      + Math.Floor(d) + "\t"
                                      + Math.Round(d) + "\t"
                                      + Math.Truncate(d) + "\t");
            Console.WriteLine("\t" + e + "\t" + Math.Ceiling(e) + "\t"
                                      + Math.Floor(e) + "\t"
                                      + Math.Round(e) + "\t"
                                      + Math.Truncate(e) + "\t");
            Console.WriteLine("\t" + f + "\t" + Math.Ceiling(f) + "\t"
                                      + Math.Floor(f) + "\t"
                                      + Math.Round(f) + "\t"
                                      + Math.Truncate(f) + "\t");
        }
    }
}
