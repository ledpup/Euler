using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace EulerCs
{
    class Program
    {
        static void Main(string[] args)
        {

            var sw = new Stopwatch();
            sw.Start();

            Console.WriteLine(Euler48.LastTenDigitsOfPowers());

            Console.WriteLine(sw.ElapsedMilliseconds);

            Console.ReadKey(true);
        }

                
    }
}
