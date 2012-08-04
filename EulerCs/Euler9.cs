using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EulerCs
{
    public class Euler9
    {
        public static int Result()
        {
            var range = EulerFsLibrary.Euler9.range;

            foreach (var a in range)
            {
                foreach (var b in range)
                {
                    foreach (var c in range)
                    {
                        if (a < b && b < c)
                            if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
                                if (a + b + c == 1000)
                                    return a*b*c;
                    }
                }
            }
            throw new Exception("Couldn't find result in the range.");
        }
    }
}
