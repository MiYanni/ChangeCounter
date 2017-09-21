using System;
using System.Linq;
using System.Reflection;
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
                var results = ((int Count, int Remaining))unit.GetMethod("CalculateCount", BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy)
                    .Invoke(null, new object[] {amount});
                amount = results.Remaining;
                Console.WriteLine($"{results.Count} {unit.Name}");
            }
        }
    }
}
