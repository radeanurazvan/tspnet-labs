namespace Lab1.PrimeSearcher
{
    internal sealed class IterativePrimeSearcherStrategy : IPrimeSearcherStrategy
    {
        public int SearchFor(int number)
        {
            for (var current = number - 1; current > 1; current--)
            {
                if (NumbersHelper.IsPrime(current))
                {
                    return current;
                }
            }

            return 0;
        }
    }
}