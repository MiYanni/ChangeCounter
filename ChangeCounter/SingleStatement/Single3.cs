using System;
using System.Linq;

namespace ChangeCounter.SingleStatement
{
    internal static class Single3
    {
        public static void Solution(int amount)
        {
            new [] {25, 10, 5, 1}
            .Select(u => Math.DivRem(amount, u, out amount))
            .Zip(new [] {"Quarter", "Dime", "Nickel", "Penny"}, (c, n) => (Count: c, Name: n))
            .Where(u => u.Count > 0)
            .ToList().ForEach(u => Console.WriteLine($"{u.Count} {u.Name}"));
        }
    }
}
