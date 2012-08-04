using System;
using System.Collections.Generic;
using System.Linq;
namespace EulerCs
{
    public class Euler6
    {
        public const int limit = 100;

        public static int Sum()
        {
            return limit * (limit + 1) / 2;
        }

        public static int SummedSquares()
        {
            return (2 * limit + 1) * (limit + 1) * limit / 6;
        }

        public static int Result()
        {
            return (int)(Math.Pow(Sum(), 2.0)) - SummedSquares();
        }
    }
}
