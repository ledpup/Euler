using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerCs
{
    public class Euler48
    {
        public static ulong LastTenDigitsOfPowers()
        {
            var sum = 0UL;
            var strippedResults = new List<ulong>();
            Parallel.For(1, 1000, i =>
                                      {
                                          var result = Power((ulong)i);
                                          var strippedResult = StripDigits(result);
                                          strippedResults.Add(strippedResult);
                                      });

            strippedResults.ForEach(x =>
                                        {
                                            sum += x;
                                            sum = StripDigits(sum);
                                        });

            return sum;
        }

        private static ulong Power(ulong number)
        {
            var multiplication = number;
            for (ulong i = 1; i < number; i++)
            {
                multiplication = multiplication * number;
                multiplication = StripDigits(multiplication);
            }
            return multiplication;
        }

        private static ulong StripDigits(ulong value)
        {
            var valueAsString = value.ToString();
            if (valueAsString.Length <= 10)
                return value;
            return ulong.Parse(valueAsString.Substring(valueAsString.Length - 10, 10));
        }
    }
}
