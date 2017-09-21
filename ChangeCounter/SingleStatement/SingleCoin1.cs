using System;
using System.Linq;

namespace ChangeCounter.SingleStatement
{
    internal static class SingleCoin1
    {
        // This prints the coins instead of counts of them.
        public static void Solution(int amount)
        {
            new[] { 25, 10, 5, 1 }
                .SelectMany(u => Enumerable.Repeat(u, Math.DivRem(amount, u, out amount)))
                .ToList().ForEach(u => Console.WriteLine($"{((CurrencyUnits)u).ToString()}"));
        }
    }
}
