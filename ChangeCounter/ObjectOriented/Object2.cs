using System;
using ChangeCounter.ObjectOriented.Oop2;

namespace ChangeCounter.ObjectOriented
{
    internal static class Object2
    {
        public static void Solution(int amount)
        {
            var units = new Unit[] { new Quarter(), new Dime(), new Nickel(), new Penny() };
            foreach (var unit in units)
            {
                var results = unit.CalculateCount(amount);
                amount = results.Remaining;
                Console.WriteLine($"{results.Count} {unit.Name}");
            }
        }
    }
}
