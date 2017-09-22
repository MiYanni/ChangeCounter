using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace ChangeCounter.Traditional
{
    internal static class Functional1
    {
        public static void Solution(int amount)
        {
            new[] { 25, 10, 5 }.Sets().Formula(amount)
                .Zip(new[] { "Quarter", "Dime", "Nickel", "Penny" }, (c, n) => (Count: c, Name: n))
                .Where(u => u.Count > 0)
                .ToList().ForEach(u => WriteLine($"{u.Count} {u.Name}"));
        }

        //https://stackoverflow.com/a/3683217/294804
        private static IEnumerable<(int? Previous, int? Current)> Sets(this IEnumerable<int> units)
        {
            using (var iterator = units.GetEnumerator())
            {
                int? previous = null;
                while (iterator.MoveNext())
                {
                    yield return (previous, iterator.Current);
                    previous = iterator.Current;
                }
                yield return (previous, null);
            }
        }

        private static IEnumerable<int> Formula(this IEnumerable<(int? Previous, int? Current)> unitSets, int amount) => 
            unitSets.Select(u =>
            {
                amount = amount % u.Previous ?? amount;
                return amount / u.Current ?? amount;
            });
    }
}
