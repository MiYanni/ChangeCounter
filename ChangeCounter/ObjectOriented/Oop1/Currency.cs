using System;

namespace ChangeCounter.ObjectOriented.Oop1
{
    internal abstract class Currency
    {
        public static int Worth { get; protected set; }

        public static string Name { get; protected set; }

        public static (int Count, int Remaining) CalculateCount(int amount) => 
            (Math.DivRem(amount, Worth, out amount), amount);
    }
}
