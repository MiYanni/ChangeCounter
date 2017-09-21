using System;
using System.Linq;
using static ChangeCounter.CurrencyUnits;

namespace ChangeCounter.SingleStatement
{
    internal static class SingleCoin2
    {
        // This prints the coins instead of counts of them.
        public static void Solution(int amount)
        {
            new[] { Quarter, Dime, Nickel, Penny }
                .SelectMany(u => Enumerable.Repeat(u, Math.DivRem(amount, (int)u, out amount)))
                .ToList().ForEach(u => Console.WriteLine($"{u.ToString()}"));
        }
    }
}
