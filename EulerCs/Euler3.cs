using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EulerCs
{
    public class Euler3
    {
        public static void Factorize(long n)
        {
            int d = 2;

            if (n < 2) return;

            Console.WriteLine("Prime factors of '{0}': ", n);
            // while the factor being tested is lower than the number to factorize
            while (d < n)
            {
                /* if valid prime factor */
                if (n % d == 0)
                {
                    Console.Write("{0} x ", d);
                    n /= d;
                }
                /* else: invalid prime factor */
                else
                {
                    if (d == 2) d = 3;
                    else d += 2;
                }
            }

            /* print last prime factor */
            Console.Write("{0}\n", d);
        }
    }
}
