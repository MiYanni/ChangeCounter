using System;
using ChangeCounter.SingleStatement;

namespace ChangeCounter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //var stopwatch = new Stopwatch();
            //Enumerable.Range(1, 10).Select(v =>
            //{
            //    stopwatch.Restart();
            //    Enumerable.Range(1, 25).ToList().ForEach(i => PrintNumbers2());
            //    stopwatch.Stop();
            //    return $"Pass {v}: {stopwatch.ElapsedMilliseconds}";
            //}).ToList().ForEach(Console.WriteLine);

            Single1.Solution(67);

            Console.ReadKey();
        }
    }
}