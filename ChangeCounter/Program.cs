using System;
using ChangeCounter.ObjectOriented;
using ChangeCounter.SingleStatement;
using ChangeCounter.Traditional;

namespace ChangeCounter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            SingleCoin2.Solution(67);
            //SingleCoin2.Solution(55);

            Console.ReadKey();
        }
    }
}