using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EulerCs
{
    public class Euler31
    {
        private static readonly int[] Coins = new[] {1, 2, 5, 10, 20, 50, 100, 200};

        public static int Combinations(int target)
        {
            var combinations = new int[target + 1];
            combinations[0] = 1;

            foreach (var coin in Coins)
            {
                for (var j = coin; j <= target; j++)
                {
                    combinations[j] += combinations[j - coin];
                }
            }

            return combinations.Last();
        }
    }
}
