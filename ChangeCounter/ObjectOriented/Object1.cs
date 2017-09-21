using System;
using ChangeCounter.ObjectOriented.Oop1;

namespace ChangeCounter.ObjectOriented
{
    internal static class Object1
    {
        public static void Solution(int amount)
        {
            var units = new [] {typeof(Quarter), typeof(Dime), typeof(Nickel), typeof(Penny)};
            foreach (var unit in units)
            {
                var results = Currency.CalculateCount(amount, unit);
                amount = results.Remaining;
                Console.WriteLine($"{results.Count} {unit.Name}");
            }
        }
    }
}
