using System;
using System.Linq;

namespace ChangeCounter.Traditional
{
    internal static class Normal1
    {
        public static void Solution(int amount)
        {
            // Note: This solution does not filter on zero counts.
            var units = Enum.GetValues(typeof(CurrencyUnits)).Cast<CurrencyUnits>().OrderByDescending(u => u);
            foreach (var unit in units)
            {
                var count = Math.DivRem(amount, (int) unit, out amount);
                Console.WriteLine($"{count} {unit}");
            }
        }
    }
}
