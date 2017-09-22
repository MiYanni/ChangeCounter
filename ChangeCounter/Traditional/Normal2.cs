using System;

namespace ChangeCounter.Traditional
{
    internal static class Normal2
    {
        public static void Solution(int amount)
        {
            Console.WriteLine($"{amount / 25} Quarter");
            Console.WriteLine($"{amount % 25 / 10} Dime");
            Console.WriteLine($"{amount % 25 % 10 / 5} Nickel");
            Console.WriteLine($"{amount % 25 % 10 % 5} Penny");
        }
    }
}
