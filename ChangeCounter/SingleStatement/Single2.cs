using System;
using System.Linq;

namespace ChangeCounter.SingleStatement
{
    internal static class Single2
    {
        public static void Solution(int amount)
        {
            Enum.GetValues(typeof(CurrencyUnits)).Cast<CurrencyUnits>().OrderByDescending(u => u)
                .Select(unit => (Count: Math.DivRem(amount, (int)unit, out amount), Name: unit.ToString()))
                .Where(x => x.Count > 0)
                .ToList().ForEach(x => Console.WriteLine($"{x.Count} {x.Name}"));
        }
    }
}
