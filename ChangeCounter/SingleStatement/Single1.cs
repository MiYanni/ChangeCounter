using System;
using System.Linq;

namespace ChangeCounter.SingleStatement
{
    internal static class Single1
    {
        public static void Solution(int amount)
        {
            //https://stackoverflow.com/a/18005821/294804
            new (int Worth, string Name)[]
            {
                (25, "Quarter"),
                (10, "Dime"),
                (5, "Nickel"),
                (1, "Penny")
            }
            // https://stackoverflow.com/a/17348688/294804
            .Select(x => (Count: Math.DivRem(amount, x.Worth, out amount), Name: x.Name))
            .Where(x => x.Count > 0)
            .ToList().ForEach(x => Console.WriteLine($"{x.Count} {x.Name}"));
        }
    }
}
