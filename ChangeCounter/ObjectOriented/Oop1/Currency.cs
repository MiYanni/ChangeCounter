using System;

namespace ChangeCounter.ObjectOriented.Oop1
{
    internal abstract class Currency
    {
        public int Worth { get; }

        public string Name { get; }

        protected Currency(int worth, string name)
        {
            Worth = worth;
            Name = name;
        }

        public static (int Count, int Remaining) CalculateCount(int amount, Type currencyType)
        {
            //https://stackoverflow.com/a/755/294804
            var coin = (Currency) Activator.CreateInstance(currencyType);
            return (Math.DivRem(amount, coin.Worth, out amount), amount);
        }
    }
}
