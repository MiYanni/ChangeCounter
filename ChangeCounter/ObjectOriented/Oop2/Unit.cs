using System;

namespace ChangeCounter.ObjectOriented.Oop2
{
    internal abstract class Unit
    {
        public int Worth { get; }

        public string Name { get; }

        protected Unit(int worth, string name)
        {
            Worth = worth;
            Name = name;
        }

        public (int Count, int Remaining) CalculateCount(int amount) => 
            (Math.DivRem(amount, Worth, out amount), amount);
    }
}
