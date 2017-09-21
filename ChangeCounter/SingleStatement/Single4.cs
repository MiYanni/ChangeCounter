using System;
using System.Linq;

namespace ChangeCounter.SingleStatement
{
    internal static class Single4
    {
        public static void Solution(int amount)
        {
            new[] { 25, 10, 5, 1 }
                .Select(u => Enumerable.Repeat(u, Math.DivRem(amount, u, out amount)).ToList())
                .Where(u => u.Any())
                .ToList().ForEach(u => Console.WriteLine($"{u.Count} {((CurrencyUnits)u.First()).ToString()}"));
        }
    }
}
