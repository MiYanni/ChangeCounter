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
            Normal2.Solution(67);
            //Normal2.Solution(55);

            Console.ReadKey();
        }
    }
}