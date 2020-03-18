using System;
using System.Linq;

namespace Lab1.PrimeSearcher
{
    internal sealed class RandomPrimeSearcherStrategy : IPrimeSearcherStrategy
    {
        private static Random random = new Random(DateTime.Now.Millisecond);
        private const int MaxIterations = 100000;

        public int SearchFor(int number)
        {
            return Enumerable.Range(0, MaxIterations)
                .Select(iteration => random.Next(0, number))
                .Where(n => NumbersHelper.IsPrime(n))
                .Max();
        }
    }
}