﻿using System.Linq;
using static ChangeCounter.CurrencyUnits;
using static System.Linq.Enumerable;
using static System.Math;
using static System.Console;

namespace ChangeCounter.SingleStatement
{
    internal static class SingleCoin2
    {
        // This prints the coins instead of counts of them.
        public static void Solution(int amount)
        {
            new[] { Quarter, Dime, Nickel, Penny }
                .SelectMany(u => Repeat(u, DivRem(amount, (int)u, out amount)))
                .ToList().ForEach(u => WriteLine($"{u.ToString()}"));
        }
    }
}
