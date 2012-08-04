using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EulerCs
{
    public class Euler7
    {
        public static List<long> Primes = new List<long> { 2, 3 };

        public static bool IsPrime(int number)
        {
            return Primes.All(o => number % o != 0);
        }

        public static int NthPrime(int number)
        {
            var x = 3;
            var count = Primes.Count;
            while (count < number)
            {
                x += 2;
                
                if (!IsPrime(x))
                    continue;

                Primes.Add(x);
                count++;
            }
            return x;
        }

        public static long SumPrimes(int number)
        {
            var x = 3;
            while (x < number)
            {
                x += 2;

                if (IsPrime(x))
                    Primes.Add(x);
            }
            return Primes.Sum();
        }
    }
}
