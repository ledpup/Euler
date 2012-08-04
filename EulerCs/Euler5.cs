using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EulerCs
{
    internal class Euler5
    {
        internal static long FindFactor()
        {
            for (long i = 20; i < 10000000000L; i++)
            {
                var count = 0;
                for (var factor = 20; factor > 0; factor--)
                {
                    if (i % factor == 0)
                        count++;
                    else
                        break;
                }

                if (count == 20)
                    return i;
            }
            return 0;
        }
    }
}
