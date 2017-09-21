using System.Linq;
using static ChangeCounter.CurrencyUnits;
using static System.Math;
using static System.Console;

namespace ChangeCounter.SingleStatement
{
    internal static class Single5
    {
        // This prints the coins instead of counts of them.
        public static void Solution(int amount)
        {
            new[] { Quarter, Dime, Nickel, Penny }
                .Select(u => (Count: DivRem(amount, (int)u, out amount), Name: u.ToString()))
                .Where(u => u.Count > 0)
                .ToList().ForEach(u => WriteLine($"{u.Count} {u.Name}"));
        }
    }
}
